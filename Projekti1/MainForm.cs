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
        private List<Tarve> vuorolista = new List<Tarve>();

        private Tyonimike tyonimike;
        private Tyotehtava tyotehtava;
        private Tyovuoro tyovuoro;
        private Tarve tarve;

        private DateTime alkaa;
        private DateTime loppuu;

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
            vuorolista = contr.LoadVuorolista(DateTime.Now, DateTime.Now);
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
            PopulateTyonimikeListView();
            PopulateTyontekijatComboBox();

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
        # region Kiinnitys
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
                t.Maara.ToString(),
                t.Kiinnitetty.ToString()}));
                
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
                tarpeet = contr.LataaTarpeet();
            }

            PopulateKiinnitykset(valittuVuoro.TyovuoroID, valittuVuoro.TehtavaID);
            PopulateTarveListView();

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
                tarpeet = contr.LataaTarpeet();
            }

            PopulateKiinnitykset(valittuKiinnitys.IDtyovuoro, valittuKiinnitys.IDtehtava);
            PopulateTarveListView();

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

        #endregion

        /// <summary>
        /// Tästä alkaa työntekijän hallinta-välilehden koodit
        /// </summary>
        /// 
        #region Työntekijän hallinta
        private void PopulateTyonimikeListView()
        {
            lvNimikkeet.Items.Clear();

            foreach (Tyonimike item in tyonimikkeet)
            {
                lvNimikkeet.Items.Add(new ListViewItem(new string[]{
                    item.Idnimike.ToString(),
                    item.Nimike.ToString(),
                }));

            }
        }

        private void btnLisaaNimike_Click(object sender, EventArgs e)
        {
            Tyonimike tyonimike = new Tyonimike();
            //tyonimike.Idnimike = null;
            tyonimike.Nimike = tbTyonimike.Text;

            tyonimikkeet.Add(tyonimike);
            contr.AddTyonimike(tyonimike);
            tyonimikkeet = contr.LoadTyonimikkeet();
            PopulateTyonimikeCombobox();
            PopulateTyonimikkeetCombobox();
            PopulateTyonimikeListView();

            tbTyonimike.Text = "";
        }

        private void btnPoistaNimike_Click(object sender, EventArgs e)
        {
            if (lvNimikkeet.SelectedIndices.Count > 0)
            {

                int valittuIndeksi = lvNimikkeet.SelectedIndices[0];
                Tyonimike a = tyonimikkeet[valittuIndeksi];

                contr.RemoveTyonimike(a);


                tyonimikkeet.RemoveAt(valittuIndeksi);
                PopulateTyonimikeCombobox();
                PopulateTyonimikkeetCombobox();
                PopulateTyonimikeListView();

            }
        }


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

            tyontekija.Idtyontekija = int.Parse(idtyontekijatb.Text);
            tyontekija.Etunimi = etunimitb.Text;
            tyontekija.Sukunimi = sukunimitb.Text;
            tyontekija.Puhelin = puhelintb.Text;
            tyontekija.Email = emailtb.Text;
            tyontekija.Nimike = nimikecmb.Text;
            tyontekija.Tyonimike_idnimike = int.Parse(idnimiketb.Text);

            contr.EditTyontekija(tyontekija);

            MessageBox.Show("Työntekijä päivitetty");

            tyontekijat = contr.LataaTyontekijat();

            PopulateTyontekijaDGW();
        }

        #endregion

        /// <summary>
        /// Tästä alkaa työvuorojen sekä työtehtävien hallinta-välilehtien koodit
        /// </summary>
        ///
        #region Työvuorojen ja työtehtävien hallinta

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
            dgvTarpeet.Columns[8].Visible = false; // Piilotetaan Kiinnitys
            dgvTarpeet.Columns[9].Visible = false; // Piilotetaan Etunimi
            dgvTarpeet.Columns[10].Visible = false; // Piilotetaan Sukunimi
            dgvTarpeet.Columns[11].Visible = false; // Piilotetaan puhelinnumero 
        }

        private void comboTehtavat_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Tyotehtava item in tyotehtavat)
            {
                if (comboTehtavat.Text == item.Tehtava)
                {
                    lblTehtavaID.Text = item.Idtyotehtava.ToString();
                }
            }
        }

        private void AddTarve()
        {
            //luodaan uusi tarve
            tarve = new Tarve();
            tarve.TyovuoroID = int.Parse(lblVuoroId.Text);
            tarve.TehtavaID = int.Parse(lblTehtavaID.Text);
            tarve.Maara = (int)numMaara.Value;

            contr.AddTarve(tarve);

        }

        private void DeleteTarve()
        {
            if (this.dgvTarpeet.SelectedRows.Count > 0)
            {
                int rowIndex = this.dgvTarpeet.CurrentRow.Index;

                //poistaa tarvelistasta objektin valitusta indeksistä
                Tarve trv = tarpeet[rowIndex];
                int count = contr.RemoveTarve(trv);
                if (count > 0)
                {

                    tarpeet.RemoveAt(rowIndex);

                }
                else
                {
                    MessageBox.Show("Tarpeen poistaminen epäonnistui!");
                }

                tarpeet = contr.LataaTarpeet();
                PopulatedTarpeetDGV();
                PopulateTarveListView();

            }
        }

        private void btnTallennaTarve_Click(object sender, EventArgs e)
        {
            if(lblVuoroId.Text == "VuoroID" || lblTehtavaID.Text == "TehtavaID" || numMaara.Value == 0)
            {
                MessageBox.Show("Täytä kaikki kentät");
            }
            else
            {
                AddTarve();
                tarpeet = contr.LataaTarpeet();
                PopulatedTarpeetDGV();
                PopulateTarveListView();
            }
        }

        private void btnPoistaTarve_Click(object sender, EventArgs e)
        {
            DeleteTarve();
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

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (tbTehtava.Text == "" || comboPaikka.Text == "" || lblidnimike.Text == "NimikeID")
                MessageBox.Show("Täytä kaikki kentät");
            else
            {
                AddTyotehtava();
            }
        }

        private void AddTyotehtava()
        {
            string sTehtava = this.tbTehtava.Text;
            string sPaikka = this.comboPaikka.Text;
            string sNimikeid = this.lblidnimike.Text;
            string sNimike = this.comboNimike.Text;


            tyotehtava = new Tyotehtava(0, sTehtava, sPaikka, int.Parse(sNimikeid), sNimike);

            Tyotehtava createdTyotehtava = GetTyotehtava();
            contr.AddTyotehtava(createdTyotehtava);

            tyotehtavat = contr.LoadTyotehtavat();


            PopulatedTyotehtavaDGV();
            PopulateTyotehtavaComboBox();

        }

        private Tyotehtava GetTyotehtava()
        {
            return tyotehtava;
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
                    
                    tyotehtavat.RemoveAt(rowIndex);

                }
                else
                {
                    MessageBox.Show("Tehtävän poisto epäonnistui!");
                }

                tyotehtavat = contr.LoadTyotehtavat();
                PopulatedTyotehtavaDGV();
                PopulateTyotehtavaComboBox();


            }

        }


        private void btnPoista_Click(object sender, EventArgs e)
        {
            DeleteTyotehtava();
        }

        private void dgvTehtavat_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvTehtavat.SelectedRows.Count > 0)
            {
                btnMuokkaa.Enabled = true;
                btnPoista.Enabled = true;

                tyotehtava = tyotehtavat.ElementAt(dgvTehtavat.CurrentRow.Index);
                tbTehtava.Text = tyotehtava.Tehtava;
                comboPaikka.Text = tyotehtava.Paikka;
                comboNimike.Text = tyotehtava.Nimike;
            }
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            // muokataan olemassa olevaa tehtävää
            tyotehtava.Tehtava = tbTehtava.Text;
            tyotehtava.Paikka = comboPaikka.Text;
            tyotehtava.Nimike = comboNimike.Text;
            tyotehtava.Tyonimike_idnimike = int.Parse(lblidnimike.Text);

            contr.EditTyotehtava(tyotehtava);
            PopulatedTyotehtavaDGV();

        }

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
                
                // Haetaan valittu rivi työvuorotaulukosta ja viedään se tarve valikon textboxiin
                int selectedIndex = listviewTyoVuorot.SelectedIndices[0];
                Tyovuoro vuoro = tyovuorot[selectedIndex];

                lblVuoroId.Text = vuoro.Idtyovuoro.ToString();
                tbTyovuoroValinta.Text = vuoro.Alkaa.ToString("dd.MM.yy HH:mm") + " - " + vuoro.Loppuu.ToString("dd.MM.yy HH:mm");

            }
        }

            private void btnTallennaVuoro_Click(object sender, EventArgs e)
        {
            AddTyovuoro();
            tyovuorot = contr.LataaTyovuorot();
            PopulateTyovuorotListView();
        }

        private void btnPoistaVuoro_Click(object sender, EventArgs e)
        {
            DeleteTyovuoro();
            tyovuorot = contr.LataaTyovuorot();
            PopulateTyovuorotListView();
        }

        private void AddTyovuoro()
        {
            //luodaan uusi työvuoro
            Tyovuoro tyovuoro = new Tyovuoro();
            tyovuoro.Idtyovuoro = 0;
            DateTime alkaa = DateTime.Parse(dtpPvmAlkaa.Value.ToString("yyyy-MM-dd") + " " + comboAlkaa.Text);
            DateTime loppuu = DateTime.Parse(dtpPvmLoppuu.Value.ToString("yyyy-MM-dd") + " " + comboLoppuu.Text);

            tyovuoro.Alkaa = alkaa;
            tyovuoro.Loppuu = loppuu;
            tyovuorot.Add(tyovuoro);
            contr.AddTyovuoro(tyovuoro);

            
        }

        private void DeleteTyovuoro()
        {
            // poista valittu vuoro
            if (this.listviewTyoVuorot.SelectedIndices.Count > 0)
            {
                int selectedIndex = listviewTyoVuorot.SelectedIndices[0];

                //poistaa tyotehtävälistasta objektin valitusta indeksistä
                Tyovuoro tv = tyovuorot[selectedIndex];
                int count = contr.RemoveTyovuoro(tv);
                if (count > 0)
                {

                    tyovuorot.RemoveAt(selectedIndex);

                }
                else
                {
                    MessageBox.Show("Vuoron poistaminen epäonnistui!");
                }
            }
        }

        #endregion


        /// <summary>
        /// Työntekijän vuorolista-sivun koodit
        /// </summary>
        # region Työntekijän vuorolista

        private void PopulateTyontekijatComboBox()
        {
            BindingSource source = new BindingSource();
            source.DataSource = tyontekijat;
            comboTyontekijat.DataSource = source;

            comboTyontekijat.DisplayMember = "Etunimi";
            comboTyontekijat.ValueMember = "Idtyontekija";
        }

        private void btnTyontekijanLista_Click(object sender, EventArgs e)
        {
            DateTime alkaa = dtpAlkupvm.Value.Date;
            DateTime loppuu = dtpLoppupvm.Value.Date;
            int tyontekijaID = int.Parse(comboTyontekijat.SelectedValue.ToString());

            lwTyontekijanVuorot.Items.Clear();

            // Käydään läpi kiinnitykset joihin valittu työntekijä on kiinnitetty
            foreach (Kiinnitys k in kiinnitykset)
            {
                if (k.IDtyontekija == tyontekijaID)
                {
                    // Käydään läpi kaikki työvuorotarpeet ja tulostetaan ne joihin työntekijä on kiinnitetty, jos se on valittujen päivämäärien sisällä
                    foreach (Tarve t in tarpeet)
                    {
                        if ((t.TyovuoroID == k.IDtyovuoro) && (t.TehtavaID == k.IDtehtava) && (t.Alkaa >= alkaa && t.Alkaa <= loppuu))
                        {
                            lwTyontekijanVuorot.Items.Add(new ListViewItem(new string[]{
                            t.Alkaa.ToString(),
                            t.Loppuu.ToString(),
                            t.Tehtava,
                            t.Paikka
                            }));
                        }
                    }
                }
            }

        }

        #endregion

        /// <summary>
        /// Työvuorolista
        /// </summary>
        /// 
        #region Työvuorolista
        private void btnHaeTyovuorolista_Click(object sender, EventArgs e)
        {
            vuorolista = contr.LoadVuorolista(alkaa, loppuu);
            lvVuorolista.Items.Clear();

            

            foreach (Tarve item in vuorolista)
            {
                lvVuorolista.Items.Add(new ListViewItem(new string[] { 
                item.Alkaa.ToString("dd.MM.yy HH:mm"),
                item.Loppuu.ToString("dd.MM.yy HH:mm"),
                item.Paikka,
                item.Tehtava,
                item.Etunimi,
                item.Sukunimi,
                item.Puhelin,
                item.Nimike}));

            }
        }

        private void dtpVuorolistaAlkaa_ValueChanged(object sender, EventArgs e)
        {
            this.alkaa = dtpVuorolistaAlkaa.Value;
        }

        private void dtpVuorolistaLoppuu_ValueChanged(object sender, EventArgs e)
        {
            this.loppuu = dtpVuorolistaLoppuu.Value;
        }

        #endregion

        /// <summary>
        /// Etusivun napit
        /// </summary>
        #region Etusivun napit

        private void btnTyovuorot_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void btnKiinnitykset_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
        }


        private void btnTtVuorolista_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(3);
        }

        private void btnTyovuorolistat_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(4);
        }

        private void btnVapaatLista_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(5);
        }

        private void btnTyontekijat_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(6);
        }

        private void btnTyotehtavat_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(7);
        }







        #endregion

       
    }
}
