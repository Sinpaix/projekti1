using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekti1.Models;

namespace Projekti1
{
    public partial class MainForm : Form
    {
        private List<Tyontekija> tyontekijat = new List<Tyontekija>();
        private List<Tyovuoro> tyovuorot = new List<Tyovuoro>();
        private List<Tyotehtava> tyotehtavat = new List<Tyotehtava>();
        private List<Tarve> tarpeet = new List<Tarve>();
        private List<Kiinnitys> kiinnitykset = new List<Kiinnitys>();
        private List<Tyonimike> nimikkeet = new List<Tyonimike>();

        private Tyotehtava tyotehtava;
        private Tyovuoro tyovuoro;

        private Controller contr = new Controller();

        public MainForm()
        {
            InitializeComponent();

            // Tähän funktiot millä ladataan tarvittavat tiedot tietokannasta heti kun ohjelma ajetaan
            tyontekijat = contr.LataaTyontekijat();
            tarpeet = contr.LataaTarpeet();
            tyovuorot = contr.LataaTyovuorot();
            tyotehtavat = contr.LoadTyotehtavat();
            


            // Laitetaan haetut tiedot ohjelman näytöille
            PopulateTarveListView();
            PopulateTyontekijaListView();
            PopulatedTyotehtavaDGW();

            //Syötetyt tiedot
            FillFieldsTehtava();

        }


        // Esitetään tarve-taulun tiedot listviewissä
        public void PopulateTarveListView()
        {
            lwVuorot.Items.Clear();

            foreach (Tarve t in tarpeet)
            {
                lwVuorot.Items.Add(new ListViewItem(new string[] { t.TyovuoroID.ToString(),
                t.Alkaa.ToString(),
                t.Loppuu.ToString(),
                t.Tehtava,
                t.Paikka,
                t.Nimike,
                t.Maara.ToString()}));
            }
        }


        private void PopulateTyontekijaListView()
        {
            //tyhjennetään lista
            this.listView1.Items.Clear();
            //lisätään kaikki näyttelijät listaan
            foreach (var item in tyontekijat)
            {
                //lisätään listalla uusi listviewitem
                //alustetaan uusi listviewitem käyttämällä muodostinta joka ottaa vastaan string taulukon
                //alustetaan uusi string taulukko ja asetetaan samalla arvot taulukolle, jokainen luokan instanssi omana alkiona

                this.listView1.Items.Add(new ListViewItem(new string[] { item.Idtyontekija.ToString(), item.Etunimi, item.Sukunimi, item.Puhelin, item.Email, item.Nimike }));
            }
        }

        private void lisaabtn_Click(object sender, EventArgs e)
        {
            // avaa työntekijäform ja luodaan uuden työntekijän tiedot
            // palauta luodun työntekijän tiedot

            TyontekijaForm tyontekijaForm = new TyontekijaForm(null);
            DialogResult result = tyontekijaForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // käyttäjä painoi tallenna nappia --> tallenna uusi työntekijä
                Tyontekija createdTyontekija = tyontekijaForm.GetTyontekija();
                int count = contr.AddTyontekija(createdTyontekija);
                if (count > 0)
                {


                    MessageBox.Show("Työntekijä lisätty");

                    // haetaan kannasta työntekijät. Näin saadaan id

                    tyontekijat = contr.LataaTyontekijat();
                    PopulateTyontekijaListView();
                }
            }
        }

        private void poistabtn_Click(object sender, EventArgs e)
        {
            // poista valittu työntekijä
            if (this.listView1.SelectedIndices.Count > 0)
            {
                int selectedIndex = this.listView1.SelectedIndices[0];
                //poistaa työntekijälistalta objekti valitusta indeksistä
                Tyontekija a = tyontekijat[selectedIndex];
                int count = contr.RemoveTyontekija(a);
                if (count > 0)
                {
                    MessageBox.Show("Työntekijä poistettu");
                    tyontekijat.RemoveAt(selectedIndex);
                    PopulateTyontekijaListView();
                }
            }
        }

        private void muokkaabtn_Click(object sender, EventArgs e)
        {

            // hae listalta valitun tiedot
            // huom listview componentille asetettu että voi valita vain yhden kerrallaan
            if (this.listView1.SelectedIndices.Count > 0)
            {
                int selectedIndex = this.listView1.SelectedIndices[0];

                //avaa työntekijä form ja välitä sinne tiedot muokattavaksi
                Tyontekija selectedTyontekija = tyontekijat[selectedIndex];
                TyontekijaForm tyontekijaForm = new TyontekijaForm(selectedTyontekija);
                DialogResult result = tyontekijaForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // käyttäjä painoi tallenna nappia --> päivitetään tiedot kannassa

                    int count = contr.EditTyontekija(selectedTyontekija);
                    if (count > 0)
                    {
                        MessageBox.Show("Työntekijä päivitetty");

                        PopulateTyontekijaListView();
                    }

                }
            }
        }

        private void PopulatedTyotehtavaDGW()
        {
            BindingSource source = new BindingSource();
            source.DataSource = tyotehtavat;
            dgwTehtavat.DataSource = source;
            dgwTehtavat.Columns[0].Visible = false; // Piilotetaan ID 
        }

        private void FillFieldsTehtava()
        {
            if (null != this.tyotehtava)
            {
                this.tbTehtava.Text = tyotehtava.Tehtava;
                this.comboPaikka.Text = tyotehtava.Paikka;
                this.tbNimike.Text = tyotehtava.Tyonimike_idnimike.ToString();
                //this.comboNimike.Text = tyotehtava.
            }
        }

        private void AddTyotehtava()
        {

            string sTehtava = this.tbTehtava.Text;
            string sPaikka = this.comboPaikka.Text;
            string sNimikeid = this.tbNimike.Text;

            if (null == tyotehtava)
            {
                // luodaan uusi tehtävä
                // Id ei tiedossa, koska tulee kannasta
                tyotehtava = new Tyotehtava(0, sTehtava, sPaikka, int.Parse(sNimikeid));
            }
            else
            {
                MessageBox.Show("ei toimi");

                // muokataan olemassa olevaa tehtävää
                tyotehtava.Tehtava = this.tbTehtava.Text;
                tyotehtava.Paikka = this.comboPaikka.Text;
                tyotehtava.Tyonimike_idnimike = int.Parse(this.tbNimike.Text);

            }

            Tyotehtava createdTyotehtava = GetTyotehtava();

            int count = contr.AddTyotehtava(createdTyotehtava);

            if (count > 0)
            {
                //MessageBox.Show("tehtävä lisätty");

                // Haetaan kannasta työtehtävät. Näin saadaan ID
                tyotehtavat = contr.LoadTyotehtavat();

            }
        }

        private Tyotehtava GetTyotehtava()
        {
            return tyotehtava;
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            AddTyotehtava();
            PopulatedTyotehtavaDGW();
        }

        //private void AddTyovuoro()
        //{
        //    if (false == this.ValidateChildren())
        //    {
        //        // tietoja ei ollut syötetty halutulla tavalla
        //        // HUOM! tämä return-lause ei estä Dialog-tyylisen lomakkeen sulkeutumista!!
        //        // lomakkeen avannut sovellus saa edelleen buttonSave-nappiin liitetyn DialogResult-vastauksen
        //        return;
        //    }

        //    DateTime sAlkaa = 0;
        //    DateTime sLoppuu = 0;

        //    if (rbalkaa06.Checked == true)
        //        sAlkaa = DateTime.Parse(dtpPvmAlkaa.Value.ToString("yyyy-MM-dd") + rbalkaa06.Text);

        //    if (rbalkaa14.Checked == true)
        //        sAlkaa = DateTime.Parse(dtpPvmAlkaa.Value.ToString("yyyy-MM-dd") + " " + rbalkaa14.Text);

        //    if (rbalkaa22.Checked == true)
        //        sAlkaa = DateTime.Parse(dtpPvmAlkaa.Value.ToString("yyyy-MM-dd") + rbalkaa22.Text);

        //    if (rbloppuu06.Checked == true)
        //        sLoppuu = DateTime.Parse(dtpPvmLoppuu.Value.ToString("yyyy-MM-dd") + rbloppuu06.Text);

        //    if (rbloppuu14.Checked == true)
        //        sLoppuu = DateTime.Parse(dtpPvmLoppuu.Value.ToString("yyyy-MM-dd") + rbloppuu14.Text);

        //    if (rbloppuu22.Checked == true)
        //        sLoppuu = DateTime.Parse(dtpPvmLoppuu.Value.ToString("yyyy-MM-dd") + rbloppuu22.Text);

        //    if (null == tyovuoro)
        //    {
        //        // luodaan uusi tehtävä
        //        // Id ei tiedossa, koska tulee kannasta
        //        tyovuoro = new Tyovuoro(0, sAlkaa, sLoppuu);
        //    }
        //    else
        //    {
        //        MessageBox.Show("ei toimi");

        //        // muokataan olemassa olevaa tehtävää
        //        tyotehtava.Tehtava = this.tbTehtava.Text;
        //        tyotehtava.Paikka = this.comboPaikka.Text;
        //        tyotehtava.Tyonimike_idnimike = int.Parse(this.tbNimike.Text);

        //    }
        //    Tyovuoro createdTyovuoro = GetTyovuorot();

        //    int count = contr.AddTyovuoro(createdTyovuoro);

        //    if (count > 0)
        //    {
        //        //MessageBox.Show("tehtävä lisätty");

        //        // Haetaan kannasta työtehtävät. Näin saadaan ID
        //        tyovuorot = contr.LataaTyovuorot();

        //    }
        //}

    
        //private Tyovuoro GetTyovuorot()
        //{
        //    return tyovuorot;
        //}
    }
}
