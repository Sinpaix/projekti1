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
    public partial class TyontekijaForm : Form
    {

        private Tyontekija tyontekija;
        private Tyonimike tyonimike;
        private List<Tyonimike> tyonimikkeet = new List<Tyonimike>();

        private Controller c = new Controller();

        public TyontekijaForm(Tyontekija tyontekija)
        {
            InitializeComponent();

            // ladataan nimikkeet kannasta
            tyonimikkeet = c.LoadTyonimikkeet();
            PopulateTyonimikkeetCombobox();

            this.tyontekija = tyontekija;
            FillFields();
        }

        private void PopulateTyonimikkeetCombobox()
        {
            BindingSource source = new BindingSource();
            source.DataSource = tyonimikkeet;
            comboBox1.DataSource = source;
            comboBox1.DisplayMember = "nimike";
            comboBox1.ValueMember = "idnimike";
        }

        private void FillFields()
        {
            if (null != this.tyontekija)
            {
                this.textBox1.Text = tyontekija.Idtyontekija.ToString();
                this.textBox2.Text = tyontekija.Etunimi;
                this.textBox3.Text = tyontekija.Sukunimi;
                this.textBox4.Text = tyontekija.Puhelin;
                this.textBox5.Text = tyontekija.Email;
                this.comboBox1.Text = tyonimike.Nimike;
            }
        }

        private void tallennabtn_Click(object sender, EventArgs e)
        {
            if (false == this.ValidateChildren())
            {
                //tietoja ei ollut syötetty halutulla tavalla
                // HUOM tämä return ei estä dialog tyylisen lomakkeen sulkautumista
                //lomakkeen avannut sovellus saa edelleen buttonsave nappiin liitetyn dialogresult vastauksen
                return;
            }

            string etunimi = this.textBox2.Text;
            string sukunimi = this.textBox3.Text;
            string puhelin = this.textBox4.Text;
            string email = this.textBox5.Text;
            int idnimike = (int)this.comboBox1.SelectedValue;

            if (null == tyontekija)
            {
                // luodaan uusi työntekijä
                // id ei tiedossa koska tulee kannasta
                tyontekija = new Tyontekija(0, etunimi, sukunimi, puhelin, email, idnimike);
            }
            else
            {
                // muokataan olemassa olevaa työntekijää

                tyontekija.Etunimi = etunimi;
                tyontekija.Sukunimi = sukunimi;
                tyontekija.Puhelin = puhelin;
                tyontekija.Email = email;
                tyontekija.Tyonimike_idnimike = idnimike;

            }
        }

        public Tyontekija GetTyontekija()
        {
            return tyontekija;
        }

        private void TyontekijaForm_Load(object sender, EventArgs e)
        {

        }

        private void peruutabtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

