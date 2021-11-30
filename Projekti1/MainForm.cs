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
        private Tarve tarve;

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

            PopulatedTarpeetDGV();
            PopulateTyovuorotListView();
            PopulatedTyotehtavaDGV();
            PopulateTyonimikkeetCombobox();

            PopulateTyontekijaDGW();
            PopulateTyonimikeCombobox();
            PopulateTyotehtavaComboBox();

            //Syötetyt tiedot
            //FillFieldsTehtava();
            //FillFieldsTyovuoro();

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

        public void PopulateVapaatTyontekijat(string nimike, int vuoroID)
        {
            lwVapaatHenkilot.Items.Clear();

            // Kyseiseen vuoroon eli tuona päivänä kiinnitetyt työntekijät
            List<int> varatut = new List<int>();

            foreach (Kiinnitys k in kiinnitykset)
            {
                if (vuoroID == k.IDtyovuoro)
                {
                    varatut.Add(k.IDtyontekija);
                }
            }

            foreach (Tyontekija t in tyontekijat)
            {

                if (!varatut.Contains(t.Idtyontekija))
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

        }



        public void PopulateKiinnitykset(int tyovuoroID, int tehtavaID)
        {
            lwKiinnitykset.Items.Clear();

            foreach (Kiinnitys k in kiinnitykset)
            {
                if (k.IDtyovuoro == tyovuoroID && k.IDtehtava == tehtavaID)
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
            btn_ValitseTyontekija.Enabled = false;
            btnPoistaKiinnitys.Enabled = false;

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

            PopulateVapaatTyontekijat(nimike, tyovuoroID);
            PopulateKiinnitykset(tyovuoroID, tehtavaID);
        }

        // Kun käyttäjä klikkaa haluttua vapaata työntekijä, mahdollistetaan napin painaminen
        private void lwVapaatHenkilot_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_ValitseVuoro.Enabled = false;
            btn_ValitseTyontekija.Enabled = true;
            btnPoistaKiinnitys.Enabled = false;
        }

        // kun käyttäjä painaa Valitse vuoro -nappia niin tallennetaan valittu vuoro
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

            // Jos työntekijä on jo valittu niin mahdollistetaan kiinnityksen tekeminen
            if (valittuTyontekija != null)
            {
                btn_Kiinnita.Enabled = true;
            }
        }
        // kun käyttäjä painaa Valitse työntekijä -nappia niin tallennetaan valittu työntekijä
        private void btn_ValitseTyontekija_Click(object sender, EventArgs e)
        {
            btn_ValitseTyontekija.Enabled = false;
            btn_PeruutaTyontekija.Enabled = true;
            tb_tyontekijavalittu.Text = "Työntekijä valittu";

            ListView.SelectedListViewItemCollection valittu = lwVapaatHenkilot.SelectedItems;
            int valittuID = 0;

            foreach (ListViewItem item in valittu)
            {
                valittuID = int.Parse(item.SubItems[0].Text);
            }

            foreach (Tyontekija t in tyontekijat)
            {
                if (t.Idtyontekija == valittuID)
                {
                    valittuTyontekija = t;
                }
            }

            // Jos vuoro on jo valittu niin mahdollistetaan kiinnityksen tekeminen
            if (valittuVuoro != null)
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
            btn_ValitseVuoro.Enabled = false;
            btn_ValitseTyontekija.Enabled = false;
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

        private void PopulateTyontekijaDGW()
        {
            BindingSource source = new BindingSource();
            source.DataSource = tyontekijat;
            tyontekijatdgv.DataSource = source;
            tyontekijatdgv.Columns[6].Visible = false;

        }
        private void PopulateTyonimikeCombobox()
        {
            BindingSource source = new BindingSource();
            source.DataSource = tyonimikkeet;
            nimikecmb.DataSource = source;
            nimikecmb.DisplayMember = "nimike";
            nimikecmb.ValueMember = "idnimike";
        }
        private void lisaabtn_Click(object sender, EventArgs e)
        {
            Tyontekija tyontekija = new Tyontekija();
            tyontekija.Etunimi = etunimitb.Text;
            tyontekija.Sukunimi = sukunimitb.Text;
            tyontekija.Puhelin = puhelintb.Text;
            tyontekija.Email = emailtb.Text;
            tyontekija.Nimike = nimikecmb.Text;
            tyontekija.Tyonimike_idnimike = int.Parse(idnimiketb.Text);

            tyontekijat.Add(tyontekija);

            contr.AddTyontekija(tyontekija);


            MessageBox.Show("Työntekijä lisätty");

            // haetaan kannasta työntekijät. Näin saadaan id

            tyontekijat = contr.LataaTyontekijat();


            PopulateTyontekijaDGW();
        }

        // lisäsin funktion mikä muuttaa nimikeid:n sitä mukaa kun droppi valikosta valitaan nimikkeen nimi
        private void nimikecmb_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Tyonimike t in tyonimikkeet)
            {
                if (nimikecmb.Text == t.Nimike)
                {
                    idnimiketb.Text = t.Idnimike.ToString();
                }
            }
        }


        private void poistabtn_Click(object sender, EventArgs e)
        {
            int rowIndex = tyontekijatdgv.CurrentRow.Index;
            Tyontekija tyontekija = tyontekijat.ElementAt(rowIndex);

            Tyontekija a = tyontekijat[rowIndex];
            contr.RemoveTyontekija(a);

            MessageBox.Show("Työntekijä poistettu");

            tyontekijat.RemoveAt(rowIndex);
            PopulateTyontekijaDGW();
        }

        private void muokkaabtn_Click(object sender, EventArgs e)
        {

            int rowIndex = tyontekijatdgv.CurrentRow.Index;
            Tyontekija tyontekija = tyontekijat.ElementAt(rowIndex);

            idtyontekijatb.Text = tyontekija.Idtyontekija.ToString();
            etunimitb.Text = tyontekija.Etunimi;
            sukunimitb.Text = tyontekija.Sukunimi;
            puhelintb.Text = tyontekija.Puhelin;
            emailtb.Text = tyontekija.Email;
            nimikecmb.Text = tyontekija.Nimike;
            idnimiketb.Text = tyontekija.Tyonimike_idnimike.ToString();
        }

        private void tyhjennabtn_Click(object sender, EventArgs e)
        {
            idtyontekijatb.Clear();
            etunimitb.Clear();
            sukunimitb.Clear();
            puhelintb.Clear();
            emailtb.Clear();
            idnimiketb.Clear();
            nimikecmb.SelectedIndex = 0;
        }

        private void tallennabtn_Click(object sender, EventArgs e)
        {
            Tyontekija tyontekija = new Tyontekija();

            tyontekija.Etunimi = etunimitb.Text;
            tyontekija.Sukunimi = sukunimitb.Text;
            tyontekija.Puhelin = puhelintb.Text;
            tyontekija.Email = emailtb.Text;
            tyontekija.Nimike = nimikecmb.Text;
            tyontekija.Tyonimike_idnimike = int.Parse(idnimiketb.Text);

            contr.EditTyontekija(tyontekija);

            MessageBox.Show("Työntekijä päivitetty");

            PopulateTyontekijaDGW();
        }

        private void PopulatedTyotehtavaDGV()
        {
            BindingSource source = new BindingSource();
            source.DataSource = tyotehtavat;
            dgvTehtavat.DataSource = source;
            //dgwTehtavat.Columns[0].Visible = false; // Piilotetaan työvuoron ID 
            dgvTehtavat.Columns[3].Visible = false; // Piilotetaan tehtävän ID 
            //dgwTehtavat.Columns[6].Visible = false; // Piilotetaan nimikkeen ID 
        }


        private void PopulatedTarpeetDGV()
        {
            BindingSource source = new BindingSource();
            source.DataSource = tarpeet;
            dgvTarpeet.DataSource = source;
            dgvTarpeet.Columns[3].Visible = false; // Piilotetaan tehtävän ID
            dgvTarpeet.Columns[5].Visible = false; // Piilotetaan paikka
            dgvTarpeet.Columns[6].Visible = false; // Piilotetaan nimike 
        }

        //private void FillFieldsTehtava()
        //{
        //    if (null != this.tyotehtava)
        //    {
        //        this.tbTehtava.Text = tyotehtava.Tehtava;
        //        this.comboPaikka.Text = tyotehtava.Paikka;
        //        //this.tbNimike.Text = tyotehtava.Tyonimike_idnimike.ToString();
        //        this.comboNimike.Text = tyotehtava.Nimike;
        //    }
        //}


        private void btnTallenna_Click(object sender, EventArgs e)
        {
            AddTyotehtava();
            PopulatedTyotehtavaDGV();

        }

        //    btnPoistaKiinnitys.Enabled = true;
        //    btn_ValitseVuoro.Enabled = false;
        //        btn_ValitseTyontekija.Enabled = false;
        //        ListView.SelectedListViewItemCollection valittu = lwKiinnitykset.SelectedItems;

        //    int tyontekijaID = 0;
        //    int vuoroID = 0;
        //    int tehtavaID = 0;

        //        foreach (ListViewItem item in valittu)
        //        {
        //            vuoroID = int.Parse(item.SubItems[0].Text);
        //    tehtavaID = int.Parse(item.SubItems[1].Text);
        //    tyontekijaID = int.Parse(item.SubItems[2].Text);

        //}

        //        // Käydään kiinnitykset läpi ja valitaan oikea
        //        foreach (Kiinnitys k in kiinnitykset)
        //        {
        //            if (k.IDtyovuoro == vuoroID && k.IDtehtava == tehtavaID && k.IDtyontekija == tyontekijaID)
        //            {
        //                valittuKiinnitys = k;
        //            }
        //        }

        //    }

        private void AddTarve()
        {

            //hieman vielä tekemistä tässä...

            //int iTyovuoroId = int.Parse(dgvTyovuorot.SelectedRows[0].Cells[0].Value + string.Empty);
            //int iTyotehtavaId = int.Parse(dgvTyovuorot.SelectedRows[0].Cells[2].Value + string.Empty);
            //int iMaara = int.Parse(dgvTyovuorot.SelectedRows[0].Cells[3].Value + string.Empty);

            //Tarve tarve = new Tarve();
            //tarve.TyovuoroID = iTyovuoroId;
            //tarve.TehtavaID = int.Parse(comboTehtavat.Text);
            //tarve.Maara = int.Parse(numMaara.Value.ToString());



            //if (tarve == null)
            //{
            //    tarve = new Tarve(

            //        tarve.TyovuoroID = int.Parse(dgvTyovuorot.SelectedRows[0].Cells[1].Value + string.Empty),
            //        tarve.TehtavaID = int.Parse(comboTehtavat.Text),
            //        tarve.Maara = int.Parse(numMaara.Value.ToString())

            //        ); 
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTarve();
        }

        private void comboNimike_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Tyonimike t in tyonimikkeet)
            {
                if (comboNimike.Text == t.Nimike)
                {
                    lblidnimike.Text = t.Idnimike.ToString();
                }
            }
        }

        private void AddTyotehtava()
        {
            string sTehtava = this.tbTehtava.Text;
            string sPaikka = this.comboPaikka.Text;
            string sNimikeid = this.lblidnimike.Text;
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
                //MessageBox.Show("tehtävä lisätty");
                // Haetaan kannasta työtehtävät.
                tyotehtavat = contr.LoadTyotehtavat();

                lblOhjeKentta.Text = "Uusi tehtävä lisätty";

            }
        }

        private void DeleteTyotehtava()
        {
            // poista valittu työtehtävä
            if (this.dgvTehtavat.SelectedRows.Count > 0)
            {
                int rowIndex = this.dgvTehtavat.CurrentRow.Index;

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
                PopulatedTyotehtavaDGV();
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

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            if (this.dgvTehtavat.SelectedRows.Count > 0)
            {
                string tehtava = dgvTehtavat.SelectedRows[0].Cells[1].Value + string.Empty;
                string paikka = dgvTehtavat.SelectedRows[0].Cells[2].Value + string.Empty;
                string nimike = dgvTehtavat.SelectedRows[0].Cells[3].Value + string.Empty;

                Tyotehtava tyotehtava = new Tyotehtava();
                tyotehtava.Tehtava = tehtava;
                tyotehtava.Paikka = paikka;
                tyotehtava.Tyonimike_idnimike = int.Parse(nimike);

                tbTehtava.Text = tehtava;
                comboPaikka.Text = paikka;
                lblidnimike.Text = nimike;

            }
        }



        //private void FillFieldsTyovuoro()
        //{
        //    if (null != this.tyovuoro)
        //    {
        //        //tyovuoro.Alkaa = DateTime.Parse(this.dtpPvmAlkaa.Value.ToString("yyyy-MM-dd") + " " + comboAlkaa.Text);
        //        //tyovuoro.Loppuu = DateTime.Parse(this.dtpPvmLoppuu.Value.ToString("yyyy-MM-dd") + " " + comboLoppuu.Text);
        //    }
        //}

        private void PopulateTyotehtavaComboBox()
        {
            BindingSource source = new BindingSource();
            source.DataSource = tyotehtavat;
            comboTehtavat.DataSource = source;
            comboTehtavat.DisplayMember = "tehtava";
            comboTehtavat.ValueMember = "idtyotehtava";
        }

        private void PopulateTyovuorotListView()
        {
            listviewTyoVuorot.Items.Clear();

            foreach (Tyovuoro item in tyovuorot)
            {
                listviewTyoVuorot.Items.Add(new ListViewItem(new string[]{
                    item.Idtyovuoro.ToString(),
                    item.Alkaa.ToString(),
                    item.Loppuu.ToString()
                }));

            }
        }

        private void listviewTyoVuorot_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listviewTyoVuorot.SelectedIndices.Count > 0)
            {
                // Haetaan valittu rivi työvuorotaulukosta
                int selectedIndex = listviewTyoVuorot.SelectedIndices[0];

                tbTyovuoroValinta.Text = selectedIndex.ToString();
            }
        }

            private void btnTallennaVuoro_Click(object sender, EventArgs e)
        {
            AddTyovuoro();
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



        private void btnTyhjennaKentatTehtava_Click(object sender, EventArgs e)
        {
            tbTehtava.Text = "";
            comboPaikka.Text = "";
            comboNimike.Text = "";

        }


        // Etusivun napit
        private void btnTyontekijat_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(5);
        }

        private void btnKiinnitykset_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void btnTyovuorot_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void btnTtVuorolista_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(3);
        }

        private void btnTyovuorolistat_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(4);
        }

        private void btnTyotehtavat_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(6);
        }

       


        }
    }
