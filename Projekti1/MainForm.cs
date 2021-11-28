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
        private List<Tyonimike> tyonimikkeet = new List<Tyonimike>();

        private Tyotehtava tyotehtava;
        private Tyovuoro tyovuoro;

        private Controller contr = new Controller();

        // kiinnityksen apuoliot
        private Tarve valittuVuoro = null;
        private Tyontekija valittuTyontekija = null;
        private Kiinnitys valittuKiinnitys = null;

        public MainForm()
        {
            InitializeComponent();

            // Tähän funktiot millä ladataan tarvittavat tiedot tietokannasta heti kun ohjelma ajetaan
            tyontekijat = contr.LataaTyontekijat();
            tarpeet = contr.LataaTarpeet();
            tyovuorot = contr.LataaTyovuorot();
            tyotehtavat = contr.LoadTyotehtavat();
            tyonimikkeet = contr.LoadTyonimikkeet();
            kiinnitykset = contr.LataaKiinnitykset();



            // Laitetaan haetut tiedot ohjelman näytöille
            PopulateTarveListView();

            PopulateTyontekijaListView();
            PopulatedTyotehtavaDGW();
            PopulateTyonimikkeetCombobox();

            //Syötetyt tiedot
            FillFieldsTehtava();
            FillFieldsTyovuoro();

        }

        private void PopulateTyonimikkeetCombobox()
        {
            BindingSource source = new BindingSource();
            source.DataSource = tyonimikkeet;
            comboNimike.DataSource = source;
            comboNimike.DisplayMember = "nimike";
            comboNimike.ValueMember = "idnimike";
        }

        /// <summary>
        /// Tästä alkaa kiinnitys-välilehden koodit
        /// </summary>
        /// 
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

        public void PopulateVapaatTyontekijat(string nimike)
        {
            lwVapaatHenkilot.Items.Clear();

            foreach (Tyontekija t in tyontekijat)
            {
                if (t.Nimike == nimike)
                {
                    lwVapaatHenkilot.Items.Add(new ListViewItem(new string[]
                    {
                        t.Idtyontekija.ToString(),
                        t.Etunimi,
                        t.Sukunimi,
                        t.Nimike
                    }));
                }

            }

        }

        public void PopulateKiinnitykset(int tyovuoroID, int tehtavaID)
        {
            lwKiinnitykset.Items.Clear();

            foreach (Kiinnitys k in kiinnitykset)
            {
                if (k.IDtyovuoro ==  tyovuoroID && k.IDtehtava == tehtavaID)
                {
                    lwKiinnitykset.Items.Add(new ListViewItem(new string[]{
                        k.IDtyovuoro.ToString(),
                        k.IDtehtava.ToString(),
                        k.IDtyontekija.ToString(),
                        k.Etunimi,
                        k.Sukunimi,
                        k.Nimike
                    }));
                }
            }
        }

        // Kun käyttäjä klikkaa haluttua vuorotarvetta, näytetään vastaavat työntekijät ja kyseiseen vuoroon kiinnitetyt työntekijät
        private void lwVuorot_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_ValitseVuoro.Enabled = true;
            string nimike = "";
            int tyovuoroID = int.MinValue;
            int tehtavaID = int.MinValue;

            if (lwVuorot.SelectedIndices.Count > 0)
            {
                // Haetaan valittu rivi tarve-taulukosta
                int valittuIndeksi = lwVuorot.SelectedIndices[0];
                Tarve t = tarpeet[valittuIndeksi];
                nimike = t.Nimike;
                tyovuoroID = t.TyovuoroID;
                tehtavaID = t.TehtavaID;
                
            }

            PopulateVapaatTyontekijat(nimike);
            PopulateKiinnitykset(tyovuoroID, tehtavaID);
        }

        // Kun käyttäjä klikkaa haluttua vapaata työntekijä, mahdollistetaan napin painaminen
        private void lwVapaatHenkilot_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_ValitseTyontekija.Enabled = true;
        }

        private void btn_ValitseVuoro_Click(object sender, EventArgs e)
        {
            btn_ValitseVuoro.Enabled = false;
            btn_PeruutaVuoro.Enabled = true;
            tb_vuorovalittu.Text = "Vuoro valittu";

            if (lwVuorot.SelectedIndices.Count > 0)
            {
                // Haetaan valittu rivi tarve-taulukosta
                int valittuIndeksi = lwVuorot.SelectedIndices[0];
                valittuVuoro = tarpeet[valittuIndeksi];

            }

            if (valittuTyontekija != null)
            {
                btn_Kiinnita.Enabled = true;
            }
        }

        // Luodaan uusi kiinnitys valituilla vuorolla ja työntekijällä sekä tallennetaan se kantaan
        private void btn_Kiinnita_Click(object sender, EventArgs e)
        {
            Kiinnitys k = new Kiinnitys(
                valittuTyontekija.Idtyontekija, valittuVuoro.TyovuoroID, valittuVuoro.TehtavaID, valittuTyontekija.Etunimi, valittuTyontekija.Sukunimi, valittuTyontekija.Nimike);

            int count = contr.LisaaKiinnitys(k);
            if (count > 0)
            {
                MessageBox.Show("Kiinnitys lisätty");
                kiinnitykset = contr.LataaKiinnitykset();
            }

            PopulateKiinnitykset(valittuVuoro.TyovuoroID, valittuVuoro.TehtavaID);

            btn_ValitseTyontekija.Enabled = false;
            btn_PeruutaTyontekija.Enabled = false;
            tb_tyontekijavalittu.Text = null;
            btn_ValitseVuoro.Enabled = false;
            btn_PeruutaVuoro.Enabled = false;
            tb_vuorovalittu.Text = null;
            btn_Kiinnita.Enabled = false;

        }

        // Käyttäjän valitseman kiinnityksen haku
        private void lwKiinnitykset_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPoistaKiinnitys.Enabled = true;
            ListView.SelectedListViewItemCollection valittu = lwKiinnitykset.SelectedItems;

            int tyontekijaID = 0;
            int vuoroID = 0;
            int tehtavaID = 0;

            foreach (ListViewItem item in valittu)
            {
                vuoroID = int.Parse(item.SubItems[0].Text);
                tehtavaID = int.Parse(item.SubItems[1].Text);
                tyontekijaID = int.Parse(item.SubItems[2].Text);

            }

            // Käydään kiinnitykset läpi ja valitaan oikea
            foreach (Kiinnitys k in kiinnitykset)
            {
                if (k.IDtyovuoro == vuoroID && k.IDtehtava == tehtavaID && k.IDtyontekija == tyontekijaID)
                {
                    valittuKiinnitys = k;
                }
            }

        }

        // Poistetaan valittu kiinnitys tietokannasta ja päivitetään listview
        private void btnPoistaKiinnitys_Click(object sender, EventArgs e)
        {
            int count = contr.PoistaKiinnitys(valittuKiinnitys);
            if (count > 0)
            {
                MessageBox.Show("Kiinnitys poistettu");
                kiinnitykset = contr.LataaKiinnitykset();

            }

            PopulateKiinnitykset(valittuKiinnitys.IDtyovuoro, valittuKiinnitys.IDtehtava);

            btn_ValitseTyontekija.Enabled = false;
            btn_PeruutaTyontekija.Enabled = false;
            btn_ValitseVuoro.Enabled = false;
            btn_PeruutaVuoro.Enabled = false;
            btn_Kiinnita.Enabled = false;
            btnPoistaKiinnitys.Enabled = false;
            valittuKiinnitys = null;
        }

        // Nappien funktioita
        private void btn_ValitseTyontekija_Click(object sender, EventArgs e)
        {
            btn_ValitseTyontekija.Enabled = false;
            btn_PeruutaTyontekija.Enabled = true;
            tb_tyontekijavalittu.Text = "Työntekijä valittu";

            valittuTyontekija = tyontekijat[0]; // tämä pitää muuttaa niin että tulee valinnan mukaan listviewistä


            if (valittuVuoro != null)
            {
                btn_Kiinnita.Enabled = true;
            }
        }

        private void btn_PeruutaVuoro_Click(object sender, EventArgs e)
        {
            valittuVuoro = null;
            btn_PeruutaVuoro.Enabled = false;
            tb_vuorovalittu.Text = null;
        }

        private void btn_PeruutaTyontekija_Click(object sender, EventArgs e)
        {
            valittuTyontekija = null;
            btn_PeruutaTyontekija.Enabled = false;
            tb_tyontekijavalittu.Text = null;
        }



        /// <summary>
        /// Tästä alkaa työntekijän hallinta-välilehden koodit
        /// </summary>
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
            //dgwTehtavat.Columns[0].Visible = false; // Piilotetaan työvuoron ID 
            dgwTehtavat.Columns[3].Visible = false; // Piilotetaan tehtävän ID 
            //dgwTehtavat.Columns[6].Visible = false; // Piilotetaan nimikkeen ID 

        }

        private void FillFieldsTehtava()
        {
            if (null != this.tyotehtava)
            {
                this.tbTehtava.Text = tyotehtava.Tehtava;
                this.comboPaikka.Text = tyotehtava.Paikka;
                //this.tbNimike.Text = tyotehtava.Tyonimike_idnimike.ToString();
                this.comboNimike.Text = tyotehtava.Nimike;
            }
        }


        private void AddTyotehtava()
        {

            string sTehtava = this.tbTehtava.Text;
            string sPaikka = this.comboPaikka.Text;
            string sNimikeid = this.tbNimike.Text;
            string sNimike = this.comboNimike.Text;

            if (null == tyotehtava)
            {
                // luodaan uusi tehtävä
                // Id ei tiedossa, koska tulee kannasta
                tyotehtava = new Tyotehtava(0, sTehtava, sPaikka, int.Parse(sNimikeid), sNimike);
            }
            else
            {
                //MessageBox.Show("ei toimi?");

                // muokataan olemassa olevaa tehtävää

                //tyotehtava.Tehtava = this.tbTehtava.Text;
                //tyotehtava.Paikka = this.comboPaikka.Text;
                //tyotehtava.Tyonimike_idnimike = int.Parse(this.tbNimike.Text);

                //TÄHÄN TYÖTEHTÄVÄN MUUTOSKOODI??

            }
            Tyotehtava createdTyotehtava = GetTyotehtava();

            int count = contr.AddTyotehtava(createdTyotehtava);

            if (count > 0)
            {
                MessageBox.Show("tehtävä lisätty");

                // Haetaan kannasta työtehtävät.
                tyotehtavat = contr.LoadTyotehtavat();

            }
        }

        private void DeleteTyotehtava()
        {
            // poista valittu työtehtävä
            if (this.dgwTehtavat.SelectedRows.Count > 0)
            {
                int rowIndex = this.dgwTehtavat.CurrentRow.Index;

                //poistaa tyotehtävälistasta objektin valitusta indeksistä
                Tyotehtava tt = tyotehtavat[rowIndex];
                int count = contr.RemoveTyotehtava(tt);
                if (count > 0)
                {
                    MessageBox.Show("Työtehtävä poistettu");
                    tyontekijat.RemoveAt(rowIndex);
                    
                }
                else
                {
                    MessageBox.Show("Tehtävän poistaminen epäonnistui");
                }

                tyotehtavat = contr.LoadTyotehtavat();
                PopulatedTyotehtavaDGW();
            }
        }

        private Tyotehtava GetTyotehtava()
        {
            return tyotehtava;
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            DeleteTyotehtava();
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //AddTyovuoro();    /*EI TOIMI*/
            AddTyotehtava();
            PopulatedTyotehtavaDGW();
            
        }

        private void FillFieldsTyovuoro()
        {
            if (null != this.tyovuoro)
            {
                //tyovuoro.Alkaa = DateTime.Parse(this.dtpPvmAlkaa.Value.ToString("yyyy-MM-dd") + " " + comboAlkaa.Text);
                //tyovuoro.Loppuu = DateTime.Parse(this.dtpPvmLoppuu.Value.ToString("yyyy-MM-dd") + " " + comboLoppuu.Text);
            }
        }

        private void AddTyovuoro()
        {
            //if (false == this.ValidateChildren())
            //{
            //    // tietoja ei ollut syötetty halutulla tavalla
            //    // HUOM! tämä return-lause ei estä Dialog-tyylisen lomakkeen sulkeutumista!!
            //    // lomakkeen avannut sovellus saa edelleen buttonSave-nappiin liitetyn DialogResult-vastauksen
            //    return;
            //}


            dtpPvmAlkaa.Format = DateTimePickerFormat.Custom;
            dtpPvmAlkaa.CustomFormat = "yyyy-MM-dd";
            dtpPvmLoppuu.CustomFormat = "yyyy-MM-dd";

            DateTime vuoroAlkaa = DateTime.Parse(dtpPvmAlkaa.Value.ToString("yyyy-MM-dd") + " " + comboAlkaa.Text);
            DateTime vuoroLoppuu = DateTime.Parse(dtpPvmLoppuu.Value.ToString("yyyy-MM-dd") + " " + comboLoppuu.Text);

            
                if (null == tyovuoro)
                {
                    // luodaan uusi vuoro
                    // Id ei tiedossa, koska tulee kannasta
                    tyovuoro = new Tyovuoro(0,
                        tyovuoro.Alkaa = vuoroAlkaa,
                        tyovuoro.Loppuu = vuoroLoppuu);

                }
                else
                {
                    MessageBox.Show("ei toimi");

                    // muokataan olemassa olevaa vuoroa
                    //tyovuoro.Alkaa = DateTime.Parse(this.dtpPvmAlkaa.Value.ToString("yyyy-MM-dd") + " " + comboAlkaa.Text);
                    //tyovuoro.Loppuu = DateTime.Parse(this.dtpPvmLoppuu.Value.ToString("yyyy-MM-dd") + " " + comboLoppuu.Text);
                }
            
         
           

            Tyovuoro createdTyovuoro = LataaTyovuorot();

            int count = contr.AddTyovuoro(createdTyovuoro);

            if (count > 0)
            {
                MessageBox.Show("vuoro lisätty");

                // Haetaan kannasta työtehtävät. Näin saadaan ID
                tyovuorot = contr.LataaTyovuorot();

            }
        }

        private Tyovuoro LataaTyovuorot()
        {
            return tyovuoro;
        }

        private void Testi()
        {

            tbvuoroalkaa.Text = dtpPvmAlkaa.Value.ToString("yyyy-MM-dd") + " " + comboAlkaa.Text;
            tbvuoroloppuu.Text = dtpPvmLoppuu.Value.ToString("yyyy-MM-dd") + " " + comboLoppuu.Text;
        }

        private void dtpPvmAlkaa_ValueChanged(object sender, EventArgs e)
        {
            Testi();
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            if (this.dgwTehtavat.SelectedRows.Count > 0)
            {
                string tehtava = dgwTehtavat.SelectedRows[0].Cells[1].Value + string.Empty;
                string paikka = dgwTehtavat.SelectedRows[0].Cells[2].Value + string.Empty;
                string nimike = dgwTehtavat.SelectedRows[0].Cells[3].Value + string.Empty;

                Tyotehtava tyotehtava = new Tyotehtava();
                tyotehtava.Tehtava = tehtava;
                tyotehtava.Paikka = paikka;
                tyotehtava.Tyonimike_idnimike = int.Parse(nimike);

                tbTehtava.Text = tehtava;
                comboPaikka.Text = paikka;
                tbNimike.Text = nimike;

                

            }
        }


    }
}
