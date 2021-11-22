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

        private Controller contr = new Controller();

        public MainForm()
        {
            InitializeComponent();

            // Tähän funktiot millä ladataan tarvittavat tiedot tietokannasta heti kun ohjelma ajetaan
            tyontekijat = contr.LataaTyontekijat();
            tarpeet = contr.LataaTarpeet();
            tyovuorot = contr.LataaTyovuorot();
            


            // Laitetaan haetut tiedot ohjelman näytöille
            PopulateTarveListView();
            PopulateTyontekijaListView();

        }


        // Esitetään työvuorot-taulun tiedot listviewissä
        public void PopulateTarveListView()
        {
            lwVuorot.Items.Clear();

            foreach (Tyovuoro t in tyovuorot)
            {
                lwVuorot.Items.Add(new ListViewItem(new string[] { t.Idtyovuoro.ToString(),
                t.Alkaa.ToString(),
                t.Loppuu.ToString() }));
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

                this.listView1.Items.Add(new ListViewItem(new string[] { item.Idtyontekija.ToString(), item.Etunimi, item.Sukunimi, item.Puhelin, item.Email }));
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
    }
}
