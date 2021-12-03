
namespace Projekti1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEtusivu = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnTyotehtavat = new System.Windows.Forms.Button();
            this.btnTyovuorolistat = new System.Windows.Forms.Button();
            this.btnTtVuorolista = new System.Windows.Forms.Button();
            this.btnTyovuorot = new System.Windows.Forms.Button();
            this.btnKiinnitykset = new System.Windows.Forms.Button();
            this.btnTyontekijat = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.tabVuorot = new System.Windows.Forms.TabPage();
            this.tbvuoroloppuu = new System.Windows.Forms.TextBox();
            this.tbvuoroalkaa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listviewTyoVuorot = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alkaa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loppuu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTyovuoroValinta = new System.Windows.Forms.TextBox();
            this.comboTehtavat = new System.Windows.Forms.ComboBox();
            this.numMaara = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTyhjennaKentatTarve = new System.Windows.Forms.Button();
            this.btnTyhjennaKentatVuoro = new System.Windows.Forms.Button();
            this.comboLoppuu = new System.Windows.Forms.ComboBox();
            this.comboAlkaa = new System.Windows.Forms.ComboBox();
            this.btnPoistaTarve = new System.Windows.Forms.Button();
            this.btnMuokkaaTarve = new System.Windows.Forms.Button();
            this.btnPoistaVuoro = new System.Windows.Forms.Button();
            this.btnTallennaTarve = new System.Windows.Forms.Button();
            this.btnMuokkaaVuoroa = new System.Windows.Forms.Button();
            this.btnTallennaVuoro = new System.Windows.Forms.Button();
            this.dgvTarpeet = new System.Windows.Forms.DataGridView();
            this.dtpPvmLoppuu = new System.Windows.Forms.DateTimePicker();
            this.dtpPvmAlkaa = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabKiinnitys = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_tyontekijavalittu = new System.Windows.Forms.TextBox();
            this.tb_vuorovalittu = new System.Windows.Forms.TextBox();
            this.btn_PeruutaTyontekija = new System.Windows.Forms.Button();
            this.btn_PeruutaVuoro = new System.Windows.Forms.Button();
            this.btn_ValitseVuoro = new System.Windows.Forms.Button();
            this.btn_ValitseTyontekija = new System.Windows.Forms.Button();
            this.btnPoistaKiinnitys = new System.Windows.Forms.Button();
            this.btn_Kiinnita = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lwKiinnitykset = new System.Windows.Forms.ListView();
            this.vuoroID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TehtavaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tyontekijaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sukunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lwVapaatHenkilot = new System.Windows.Forms.ListView();
            this.lw_henkiloID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_HenkiloEtunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_HenkiloSukunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_HenkiloNimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lwVuorot = new System.Windows.Forms.ListView();
            this.lw_tyovuoroID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Aloitus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Lopetus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Tehtava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Paikka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Nimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Maara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Valittu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabTyöntekijänVuorot = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabTyövuorolista = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.tabTyöntekijät = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lvNimikkeet = new System.Windows.Forms.ListView();
            this.IdNimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Työnimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPoistaNimike = new System.Windows.Forms.Button();
            this.btnLisaaNimike = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.tbTyonimike = new System.Windows.Forms.TextBox();
            this.tyontekijatdgv = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.idnimiketb = new System.Windows.Forms.TextBox();
            this.idtyontekijatb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nimikecmb = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.puhelintb = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.sukunimitb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.etunimitb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tallennabtn = new System.Windows.Forms.Button();
            this.tyhjennabtn = new System.Windows.Forms.Button();
            this.lisaabtn = new System.Windows.Forms.Button();
            this.poistabtn = new System.Windows.Forms.Button();
            this.muokkaabtn = new System.Windows.Forms.Button();
            this.tabTehtävät = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblOhjeKentta = new System.Windows.Forms.Label();
            this.lblidnimike = new System.Windows.Forms.Label();
            this.dgvTehtavat = new System.Windows.Forms.DataGridView();
            this.btnTyhjennaKentatTehtava = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.comboNimike = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPaikka = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.tbTehtava = new System.Windows.Forms.TextBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabEtusivu.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabVuorot.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarpeet)).BeginInit();
            this.tabKiinnitys.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTyöntekijänVuorot.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabTyövuorolista.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabTyöntekijät.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tyontekijatdgv)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabTehtävät.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTehtavat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabEtusivu);
            this.tabControl.Controls.Add(this.tabVuorot);
            this.tabControl.Controls.Add(this.tabKiinnitys);
            this.tabControl.Controls.Add(this.tabTyöntekijänVuorot);
            this.tabControl.Controls.Add(this.tabTyövuorolista);
            this.tabControl.Controls.Add(this.tabTyöntekijät);
            this.tabControl.Controls.Add(this.tabTehtävät);
            this.tabControl.Location = new System.Drawing.Point(5, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(3185, 1659);
            this.tabControl.TabIndex = 0;
            // 
            // tabEtusivu
            // 
            this.tabEtusivu.Controls.Add(this.panel7);
            this.tabEtusivu.Controls.Add(this.panel6);
            this.tabEtusivu.Location = new System.Drawing.Point(4, 25);
            this.tabEtusivu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEtusivu.Name = "tabEtusivu";
            this.tabEtusivu.Size = new System.Drawing.Size(3177, 1630);
            this.tabEtusivu.TabIndex = 6;
            this.tabEtusivu.Text = "Etusivu";
            this.tabEtusivu.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnTyotehtavat);
            this.panel7.Controls.Add(this.btnTyovuorolistat);
            this.panel7.Controls.Add(this.btnTtVuorolista);
            this.panel7.Controls.Add(this.btnTyovuorot);
            this.panel7.Controls.Add(this.btnKiinnitykset);
            this.panel7.Controls.Add(this.btnTyontekijat);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 166);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3177, 1464);
            this.panel7.TabIndex = 3;
            // 
            // btnTyotehtavat
            // 
            this.btnTyotehtavat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyotehtavat.Location = new System.Drawing.Point(1120, 12);
            this.btnTyotehtavat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTyotehtavat.Name = "btnTyotehtavat";
            this.btnTyotehtavat.Size = new System.Drawing.Size(195, 103);
            this.btnTyotehtavat.TabIndex = 5;
            this.btnTyotehtavat.Text = "Työtehtävien hallinta";
            this.btnTyotehtavat.UseVisualStyleBackColor = true;
            this.btnTyotehtavat.Click += new System.EventHandler(this.btnTyotehtavat_Click);
            // 
            // btnTyovuorolistat
            // 
            this.btnTyovuorolistat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyovuorolistat.Location = new System.Drawing.Point(689, 12);
            this.btnTyovuorolistat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTyovuorolistat.Name = "btnTyovuorolistat";
            this.btnTyovuorolistat.Size = new System.Drawing.Size(195, 103);
            this.btnTyovuorolistat.TabIndex = 4;
            this.btnTyovuorolistat.Text = "Työvuorolista";
            this.btnTyovuorolistat.UseVisualStyleBackColor = true;
            this.btnTyovuorolistat.Click += new System.EventHandler(this.btnTyovuorolistat_Click);
            // 
            // btnTtVuorolista
            // 
            this.btnTtVuorolista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTtVuorolista.Location = new System.Drawing.Point(475, 12);
            this.btnTtVuorolista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTtVuorolista.Name = "btnTtVuorolista";
            this.btnTtVuorolista.Size = new System.Drawing.Size(195, 103);
            this.btnTtVuorolista.TabIndex = 3;
            this.btnTtVuorolista.Text = "Työntekijän vuorolista";
            this.btnTtVuorolista.UseVisualStyleBackColor = true;
            this.btnTtVuorolista.Click += new System.EventHandler(this.btnTtVuorolista_Click);
            // 
            // btnTyovuorot
            // 
            this.btnTyovuorot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyovuorot.Location = new System.Drawing.Point(49, 12);
            this.btnTyovuorot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTyovuorot.Name = "btnTyovuorot";
            this.btnTyovuorot.Size = new System.Drawing.Size(195, 103);
            this.btnTyovuorot.TabIndex = 2;
            this.btnTyovuorot.Text = "Työvuorojen hallinta";
            this.btnTyovuorot.UseVisualStyleBackColor = true;
            this.btnTyovuorot.Click += new System.EventHandler(this.btnTyovuorot_Click);
            // 
            // btnKiinnitykset
            // 
            this.btnKiinnitykset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiinnitykset.Location = new System.Drawing.Point(260, 12);
            this.btnKiinnitykset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKiinnitykset.Name = "btnKiinnitykset";
            this.btnKiinnitykset.Size = new System.Drawing.Size(195, 103);
            this.btnKiinnitykset.TabIndex = 1;
            this.btnKiinnitykset.Text = "Työntekijöiden kiinnitys";
            this.btnKiinnitykset.UseVisualStyleBackColor = true;
            this.btnKiinnitykset.Click += new System.EventHandler(this.btnKiinnitykset_Click);
            // 
            // btnTyontekijat
            // 
            this.btnTyontekijat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyontekijat.Location = new System.Drawing.Point(905, 12);
            this.btnTyontekijat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTyontekijat.Name = "btnTyontekijat";
            this.btnTyontekijat.Size = new System.Drawing.Size(195, 103);
            this.btnTyontekijat.TabIndex = 0;
            this.btnTyontekijat.Text = "Työntekijöiden hallinta";
            this.btnTyontekijat.UseVisualStyleBackColor = true;
            this.btnTyontekijat.Click += new System.EventHandler(this.btnTyontekijat_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label24);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3177, 166);
            this.panel6.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(39, 49);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(262, 44);
            this.label24.TabIndex = 1;
            this.label24.Text = "SairaalaSofta";
            // 
            // tabVuorot
            // 
            this.tabVuorot.Controls.Add(this.tbvuoroloppuu);
            this.tabVuorot.Controls.Add(this.tbvuoroalkaa);
            this.tabVuorot.Controls.Add(this.panel2);
            this.tabVuorot.Location = new System.Drawing.Point(4, 25);
            this.tabVuorot.Margin = new System.Windows.Forms.Padding(4);
            this.tabVuorot.Name = "tabVuorot";
            this.tabVuorot.Padding = new System.Windows.Forms.Padding(4);
            this.tabVuorot.Size = new System.Drawing.Size(3177, 1630);
            this.tabVuorot.TabIndex = 1;
            this.tabVuorot.Text = "Työvuorojen hallinta";
            this.tabVuorot.UseVisualStyleBackColor = true;
            // 
            // tbvuoroloppuu
            // 
            this.tbvuoroloppuu.Location = new System.Drawing.Point(345, 799);
            this.tbvuoroloppuu.Margin = new System.Windows.Forms.Padding(4);
            this.tbvuoroloppuu.Name = "tbvuoroloppuu";
            this.tbvuoroloppuu.Size = new System.Drawing.Size(324, 22);
            this.tbvuoroloppuu.TabIndex = 1;
            // 
            // tbvuoroalkaa
            // 
            this.tbvuoroalkaa.Location = new System.Drawing.Point(12, 799);
            this.tbvuoroalkaa.Margin = new System.Windows.Forms.Padding(4);
            this.tbvuoroalkaa.Name = "tbvuoroalkaa";
            this.tbvuoroalkaa.Size = new System.Drawing.Size(324, 22);
            this.tbvuoroalkaa.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listviewTyoVuorot);
            this.panel2.Controls.Add(this.tbTyovuoroValinta);
            this.panel2.Controls.Add(this.comboTehtavat);
            this.panel2.Controls.Add(this.numMaara);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnTyhjennaKentatTarve);
            this.panel2.Controls.Add(this.btnTyhjennaKentatVuoro);
            this.panel2.Controls.Add(this.comboLoppuu);
            this.panel2.Controls.Add(this.comboAlkaa);
            this.panel2.Controls.Add(this.btnPoistaTarve);
            this.panel2.Controls.Add(this.btnMuokkaaTarve);
            this.panel2.Controls.Add(this.btnPoistaVuoro);
            this.panel2.Controls.Add(this.btnTallennaTarve);
            this.panel2.Controls.Add(this.btnMuokkaaVuoroa);
            this.panel2.Controls.Add(this.btnTallennaVuoro);
            this.panel2.Controls.Add(this.dgvTarpeet);
            this.panel2.Controls.Add(this.dtpPvmLoppuu);
            this.panel2.Controls.Add(this.dtpPvmAlkaa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1728, 778);
            this.panel2.TabIndex = 0;
            // 
            // listviewTyoVuorot
            // 
            this.listviewTyoVuorot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Alkaa,
            this.Loppuu});
            this.listviewTyoVuorot.FullRowSelect = true;
            this.listviewTyoVuorot.HideSelection = false;
            this.listviewTyoVuorot.Location = new System.Drawing.Point(503, 26);
            this.listviewTyoVuorot.Margin = new System.Windows.Forms.Padding(4);
            this.listviewTyoVuorot.Name = "listviewTyoVuorot";
            this.listviewTyoVuorot.Size = new System.Drawing.Size(531, 323);
            this.listviewTyoVuorot.TabIndex = 39;
            this.listviewTyoVuorot.UseCompatibleStateImageBehavior = false;
            this.listviewTyoVuorot.View = System.Windows.Forms.View.Details;
            this.listviewTyoVuorot.SelectedIndexChanged += new System.EventHandler(this.listviewTyoVuorot_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Alkaa
            // 
            this.Alkaa.Text = "Alkaa";
            this.Alkaa.Width = 150;
            // 
            // Loppuu
            // 
            this.Loppuu.Text = "Loppuu";
            this.Loppuu.Width = 150;
            // 
            // tbTyovuoroValinta
            // 
            this.tbTyovuoroValinta.Location = new System.Drawing.Point(177, 431);
            this.tbTyovuoroValinta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTyovuoroValinta.Name = "tbTyovuoroValinta";
            this.tbTyovuoroValinta.Size = new System.Drawing.Size(267, 23);
            this.tbTyovuoroValinta.TabIndex = 38;
            this.tbTyovuoroValinta.Text = "Valitse työvuorolistalta vuoro";
            // 
            // comboTehtavat
            // 
            this.comboTehtavat.FormattingEnabled = true;
            this.comboTehtavat.Location = new System.Drawing.Point(177, 491);
            this.comboTehtavat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboTehtavat.Name = "comboTehtavat";
            this.comboTehtavat.Size = new System.Drawing.Size(268, 24);
            this.comboTehtavat.TabIndex = 37;
            // 
            // numMaara
            // 
            this.numMaara.Location = new System.Drawing.Point(177, 545);
            this.numMaara.Margin = new System.Windows.Forms.Padding(4);
            this.numMaara.Name = "numMaara";
            this.numMaara.Size = new System.Drawing.Size(84, 23);
            this.numMaara.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Määrä";
            // 
            // btnTyhjennaKentatTarve
            // 
            this.btnTyhjennaKentatTarve.Location = new System.Drawing.Point(348, 620);
            this.btnTyhjennaKentatTarve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTyhjennaKentatTarve.Name = "btnTyhjennaKentatTarve";
            this.btnTyhjennaKentatTarve.Size = new System.Drawing.Size(109, 34);
            this.btnTyhjennaKentatTarve.TabIndex = 22;
            this.btnTyhjennaKentatTarve.Text = "Tyhjennä";
            this.btnTyhjennaKentatTarve.UseVisualStyleBackColor = true;
            // 
            // btnTyhjennaKentatVuoro
            // 
            this.btnTyhjennaKentatVuoro.Location = new System.Drawing.Point(348, 255);
            this.btnTyhjennaKentatVuoro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTyhjennaKentatVuoro.Name = "btnTyhjennaKentatVuoro";
            this.btnTyhjennaKentatVuoro.Size = new System.Drawing.Size(109, 34);
            this.btnTyhjennaKentatVuoro.TabIndex = 22;
            this.btnTyhjennaKentatVuoro.Text = "Tyhjennä";
            this.btnTyhjennaKentatVuoro.UseVisualStyleBackColor = true;
            // 
            // comboLoppuu
            // 
            this.comboLoppuu.FormattingEnabled = true;
            this.comboLoppuu.Items.AddRange(new object[] {
            "06:00:00",
            "06:15",
            "06:30",
            "06:45",
            "07:00",
            "07:15",
            "07:30",
            "07:45",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00",
            "18:15",
            "18:30",
            "18:45",
            "19:00",
            "19:15",
            "19:30",
            "19:45",
            "20:00",
            "20:15",
            "20:30",
            "20:45",
            "21:00",
            "21:15",
            "21:30",
            "21:45",
            "22:00",
            "22:15",
            "22:30",
            "22:45",
            "23:00",
            "23:15",
            "23:30",
            "23:45",
            "00:00",
            "00:15",
            "00:30",
            "00:45",
            "01:00",
            "01:15",
            "01:30",
            "01:45",
            "02:00",
            "02:15",
            "02:30",
            "02:45",
            "03:00",
            "03:15",
            "03:30",
            "03:45",
            "04:00",
            "04:15",
            "04:30",
            "04:45",
            "05:00",
            "05:15",
            "05:30",
            "05:45"});
            this.comboLoppuu.Location = new System.Drawing.Point(177, 198);
            this.comboLoppuu.Margin = new System.Windows.Forms.Padding(4);
            this.comboLoppuu.Name = "comboLoppuu";
            this.comboLoppuu.Size = new System.Drawing.Size(87, 24);
            this.comboLoppuu.TabIndex = 21;
            this.comboLoppuu.SelectedValueChanged += new System.EventHandler(this.dtpPvmAlkaa_ValueChanged);
            // 
            // comboAlkaa
            // 
            this.comboAlkaa.FormattingEnabled = true;
            this.comboAlkaa.Items.AddRange(new object[] {
            "06:00:00",
            "06:15",
            "06:30",
            "06:45",
            "07:00",
            "07:15",
            "07:30",
            "07:45",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00",
            "18:15",
            "18:30",
            "18:45",
            "19:00",
            "19:15",
            "19:30",
            "19:45",
            "20:00",
            "20:15",
            "20:30",
            "20:45",
            "21:00",
            "21:15",
            "21:30",
            "21:45",
            "22:00",
            "22:15",
            "22:30",
            "22:45",
            "23:00",
            "23:15",
            "23:30",
            "23:45",
            "00:00",
            "00:15",
            "00:30",
            "00:45",
            "01:00",
            "01:15",
            "01:30",
            "01:45",
            "02:00",
            "02:15",
            "02:30",
            "02:45",
            "03:00",
            "03:15",
            "03:30",
            "03:45",
            "04:00",
            "04:15",
            "04:30",
            "04:45",
            "05:00",
            "05:15",
            "05:30",
            "05:45"});
            this.comboAlkaa.Location = new System.Drawing.Point(177, 116);
            this.comboAlkaa.Margin = new System.Windows.Forms.Padding(4);
            this.comboAlkaa.Name = "comboAlkaa";
            this.comboAlkaa.Size = new System.Drawing.Size(87, 24);
            this.comboAlkaa.TabIndex = 21;
            this.comboAlkaa.SelectedValueChanged += new System.EventHandler(this.dtpPvmAlkaa_ValueChanged);
            // 
            // btnPoistaTarve
            // 
            this.btnPoistaTarve.Location = new System.Drawing.Point(245, 620);
            this.btnPoistaTarve.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPoistaTarve.Name = "btnPoistaTarve";
            this.btnPoistaTarve.Size = new System.Drawing.Size(97, 34);
            this.btnPoistaTarve.TabIndex = 18;
            this.btnPoistaTarve.Text = "Poista";
            this.btnPoistaTarve.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaaTarve
            // 
            this.btnMuokkaaTarve.Location = new System.Drawing.Point(143, 620);
            this.btnMuokkaaTarve.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMuokkaaTarve.Name = "btnMuokkaaTarve";
            this.btnMuokkaaTarve.Size = new System.Drawing.Size(97, 34);
            this.btnMuokkaaTarve.TabIndex = 18;
            this.btnMuokkaaTarve.Text = "Muokkaa";
            this.btnMuokkaaTarve.UseVisualStyleBackColor = true;
            // 
            // btnPoistaVuoro
            // 
            this.btnPoistaVuoro.Location = new System.Drawing.Point(244, 255);
            this.btnPoistaVuoro.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPoistaVuoro.Name = "btnPoistaVuoro";
            this.btnPoistaVuoro.Size = new System.Drawing.Size(97, 34);
            this.btnPoistaVuoro.TabIndex = 18;
            this.btnPoistaVuoro.Text = "Poista";
            this.btnPoistaVuoro.UseVisualStyleBackColor = true;
            // 
            // btnTallennaTarve
            // 
            this.btnTallennaTarve.Location = new System.Drawing.Point(40, 620);
            this.btnTallennaTarve.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnTallennaTarve.Name = "btnTallennaTarve";
            this.btnTallennaTarve.Size = new System.Drawing.Size(97, 34);
            this.btnTallennaTarve.TabIndex = 17;
            this.btnTallennaTarve.Text = "Tallenna";
            this.btnTallennaTarve.UseVisualStyleBackColor = true;
            this.btnTallennaTarve.Click += new System.EventHandler(this.btnTallennaTarve_Click);
            // 
            // btnMuokkaaVuoroa
            // 
            this.btnMuokkaaVuoroa.Location = new System.Drawing.Point(141, 255);
            this.btnMuokkaaVuoroa.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMuokkaaVuoroa.Name = "btnMuokkaaVuoroa";
            this.btnMuokkaaVuoroa.Size = new System.Drawing.Size(97, 34);
            this.btnMuokkaaVuoroa.TabIndex = 18;
            this.btnMuokkaaVuoroa.Text = "Muokkaa";
            this.btnMuokkaaVuoroa.UseVisualStyleBackColor = true;
            // 
            // btnTallennaVuoro
            // 
            this.btnTallennaVuoro.Location = new System.Drawing.Point(40, 255);
            this.btnTallennaVuoro.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnTallennaVuoro.Name = "btnTallennaVuoro";
            this.btnTallennaVuoro.Size = new System.Drawing.Size(97, 34);
            this.btnTallennaVuoro.TabIndex = 17;
            this.btnTallennaVuoro.Text = "Tallenna";
            this.btnTallennaVuoro.UseVisualStyleBackColor = true;
            this.btnTallennaVuoro.Click += new System.EventHandler(this.btnTallennaVuoro_Click);
            // 
            // dgvTarpeet
            // 
            this.dgvTarpeet.AllowUserToAddRows = false;
            this.dgvTarpeet.AllowUserToDeleteRows = false;
            this.dgvTarpeet.AllowUserToOrderColumns = true;
            this.dgvTarpeet.AllowUserToResizeColumns = false;
            this.dgvTarpeet.AllowUserToResizeRows = false;
            this.dgvTarpeet.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarpeet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarpeet.Location = new System.Drawing.Point(503, 388);
            this.dgvTarpeet.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvTarpeet.Name = "dgvTarpeet";
            this.dgvTarpeet.ReadOnly = true;
            this.dgvTarpeet.RowHeadersWidth = 60;
            this.dgvTarpeet.RowTemplate.Height = 24;
            this.dgvTarpeet.Size = new System.Drawing.Size(1137, 351);
            this.dgvTarpeet.TabIndex = 13;
            // 
            // dtpPvmLoppuu
            // 
            this.dtpPvmLoppuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPvmLoppuu.Location = new System.Drawing.Point(177, 164);
            this.dtpPvmLoppuu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtpPvmLoppuu.Name = "dtpPvmLoppuu";
            this.dtpPvmLoppuu.Size = new System.Drawing.Size(268, 23);
            this.dtpPvmLoppuu.TabIndex = 4;
            this.dtpPvmLoppuu.ValueChanged += new System.EventHandler(this.dtpPvmAlkaa_ValueChanged);
            // 
            // dtpPvmAlkaa
            // 
            this.dtpPvmAlkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPvmAlkaa.Location = new System.Drawing.Point(177, 79);
            this.dtpPvmAlkaa.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtpPvmAlkaa.Name = "dtpPvmAlkaa";
            this.dtpPvmAlkaa.Size = new System.Drawing.Size(268, 23);
            this.dtpPvmAlkaa.TabIndex = 4;
            this.dtpPvmAlkaa.ValueChanged += new System.EventHandler(this.dtpPvmAlkaa_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loppuu";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(41, 491);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 17);
            this.label23.TabIndex = 2;
            this.label23.Text = "Tehtävä";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(41, 437);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 17);
            this.label22.TabIndex = 2;
            this.label22.Text = "Työvuoro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alkaa";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(41, 388);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Lisää tarve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lisää työvuoro";
            // 
            // tabKiinnitys
            // 
            this.tabKiinnitys.Controls.Add(this.panel1);
            this.tabKiinnitys.Controls.Add(this.groupBox4);
            this.tabKiinnitys.Controls.Add(this.groupBox2);
            this.tabKiinnitys.Controls.Add(this.groupBox1);
            this.tabKiinnitys.Location = new System.Drawing.Point(4, 25);
            this.tabKiinnitys.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabKiinnitys.Name = "tabKiinnitys";
            this.tabKiinnitys.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabKiinnitys.Size = new System.Drawing.Size(3177, 1630);
            this.tabKiinnitys.TabIndex = 4;
            this.tabKiinnitys.Text = "Työntekijöiden kiinnitys";
            this.tabKiinnitys.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_tyontekijavalittu);
            this.panel1.Controls.Add(this.tb_vuorovalittu);
            this.panel1.Controls.Add(this.btn_PeruutaTyontekija);
            this.panel1.Controls.Add(this.btn_PeruutaVuoro);
            this.panel1.Controls.Add(this.btn_ValitseVuoro);
            this.panel1.Controls.Add(this.btn_ValitseTyontekija);
            this.panel1.Controls.Add(this.btnPoistaKiinnitys);
            this.panel1.Controls.Add(this.btn_Kiinnita);
            this.panel1.Location = new System.Drawing.Point(913, 421);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 364);
            this.panel1.TabIndex = 4;
            // 
            // tb_tyontekijavalittu
            // 
            this.tb_tyontekijavalittu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_tyontekijavalittu.Location = new System.Drawing.Point(303, 84);
            this.tb_tyontekijavalittu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tb_tyontekijavalittu.Name = "tb_tyontekijavalittu";
            this.tb_tyontekijavalittu.Size = new System.Drawing.Size(176, 15);
            this.tb_tyontekijavalittu.TabIndex = 10;
            // 
            // tb_vuorovalittu
            // 
            this.tb_vuorovalittu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_vuorovalittu.Location = new System.Drawing.Point(303, 26);
            this.tb_vuorovalittu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tb_vuorovalittu.Name = "tb_vuorovalittu";
            this.tb_vuorovalittu.Size = new System.Drawing.Size(176, 15);
            this.tb_vuorovalittu.TabIndex = 9;
            // 
            // btn_PeruutaTyontekija
            // 
            this.btn_PeruutaTyontekija.Enabled = false;
            this.btn_PeruutaTyontekija.Location = new System.Drawing.Point(167, 71);
            this.btn_PeruutaTyontekija.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_PeruutaTyontekija.Name = "btn_PeruutaTyontekija";
            this.btn_PeruutaTyontekija.Size = new System.Drawing.Size(131, 44);
            this.btn_PeruutaTyontekija.TabIndex = 8;
            this.btn_PeruutaTyontekija.Text = "Peruuta";
            this.btn_PeruutaTyontekija.UseVisualStyleBackColor = true;
            this.btn_PeruutaTyontekija.Click += new System.EventHandler(this.btn_PeruutaTyontekija_Click);
            // 
            // btn_PeruutaVuoro
            // 
            this.btn_PeruutaVuoro.Enabled = false;
            this.btn_PeruutaVuoro.Location = new System.Drawing.Point(167, 15);
            this.btn_PeruutaVuoro.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_PeruutaVuoro.Name = "btn_PeruutaVuoro";
            this.btn_PeruutaVuoro.Size = new System.Drawing.Size(131, 44);
            this.btn_PeruutaVuoro.TabIndex = 7;
            this.btn_PeruutaVuoro.Text = "Peruuta";
            this.btn_PeruutaVuoro.UseVisualStyleBackColor = true;
            this.btn_PeruutaVuoro.Click += new System.EventHandler(this.btn_PeruutaVuoro_Click);
            // 
            // btn_ValitseVuoro
            // 
            this.btn_ValitseVuoro.Enabled = false;
            this.btn_ValitseVuoro.Location = new System.Drawing.Point(31, 15);
            this.btn_ValitseVuoro.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_ValitseVuoro.Name = "btn_ValitseVuoro";
            this.btn_ValitseVuoro.Size = new System.Drawing.Size(131, 44);
            this.btn_ValitseVuoro.TabIndex = 6;
            this.btn_ValitseVuoro.Text = "Valitse vuoro";
            this.btn_ValitseVuoro.UseVisualStyleBackColor = true;
            this.btn_ValitseVuoro.Click += new System.EventHandler(this.btn_ValitseVuoro_Click);
            // 
            // btn_ValitseTyontekija
            // 
            this.btn_ValitseTyontekija.Enabled = false;
            this.btn_ValitseTyontekija.Location = new System.Drawing.Point(31, 71);
            this.btn_ValitseTyontekija.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_ValitseTyontekija.Name = "btn_ValitseTyontekija";
            this.btn_ValitseTyontekija.Size = new System.Drawing.Size(131, 44);
            this.btn_ValitseTyontekija.TabIndex = 5;
            this.btn_ValitseTyontekija.Text = "Valitse Työntekijä";
            this.btn_ValitseTyontekija.UseVisualStyleBackColor = true;
            this.btn_ValitseTyontekija.Click += new System.EventHandler(this.btn_ValitseTyontekija_Click);
            // 
            // btnPoistaKiinnitys
            // 
            this.btnPoistaKiinnitys.Enabled = false;
            this.btnPoistaKiinnitys.Location = new System.Drawing.Point(167, 308);
            this.btnPoistaKiinnitys.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPoistaKiinnitys.Name = "btnPoistaKiinnitys";
            this.btnPoistaKiinnitys.Size = new System.Drawing.Size(131, 44);
            this.btnPoistaKiinnitys.TabIndex = 4;
            this.btnPoistaKiinnitys.Text = "Poista";
            this.btnPoistaKiinnitys.UseVisualStyleBackColor = true;
            this.btnPoistaKiinnitys.Click += new System.EventHandler(this.btnPoistaKiinnitys_Click);
            // 
            // btn_Kiinnita
            // 
            this.btn_Kiinnita.Enabled = false;
            this.btn_Kiinnita.Location = new System.Drawing.Point(31, 308);
            this.btn_Kiinnita.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_Kiinnita.Name = "btn_Kiinnita";
            this.btn_Kiinnita.Size = new System.Drawing.Size(131, 44);
            this.btn_Kiinnita.TabIndex = 3;
            this.btn_Kiinnita.Text = "Kiinnitä";
            this.btn_Kiinnita.UseVisualStyleBackColor = true;
            this.btn_Kiinnita.Click += new System.EventHandler(this.btn_Kiinnita_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lwKiinnitykset);
            this.groupBox4.Location = new System.Drawing.Point(12, 400);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox4.Size = new System.Drawing.Size(873, 390);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kiinnitykset";
            // 
            // lwKiinnitykset
            // 
            this.lwKiinnitykset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vuoroID,
            this.TehtavaID,
            this.tyontekijaID,
            this.Etunimi,
            this.Sukunimi,
            this.Nimike});
            this.lwKiinnitykset.FullRowSelect = true;
            this.lwKiinnitykset.HideSelection = false;
            this.lwKiinnitykset.Location = new System.Drawing.Point(11, 20);
            this.lwKiinnitykset.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lwKiinnitykset.Name = "lwKiinnitykset";
            this.lwKiinnitykset.Size = new System.Drawing.Size(857, 366);
            this.lwKiinnitykset.TabIndex = 1;
            this.lwKiinnitykset.UseCompatibleStateImageBehavior = false;
            this.lwKiinnitykset.View = System.Windows.Forms.View.Details;
            this.lwKiinnitykset.SelectedIndexChanged += new System.EventHandler(this.lwKiinnitykset_SelectedIndexChanged);
            // 
            // vuoroID
            // 
            this.vuoroID.Text = "Vuoron ID";
            this.vuoroID.Width = 100;
            // 
            // TehtavaID
            // 
            this.TehtavaID.Text = "Tehtävän ID";
            this.TehtavaID.Width = 100;
            // 
            // tyontekijaID
            // 
            this.tyontekijaID.Text = "Työntekijän ID";
            this.tyontekijaID.Width = 100;
            // 
            // Etunimi
            // 
            this.Etunimi.Text = "Etunimi";
            this.Etunimi.Width = 150;
            // 
            // Sukunimi
            // 
            this.Sukunimi.Text = "Sukunimi";
            this.Sukunimi.Width = 150;
            // 
            // Nimike
            // 
            this.Nimike.Text = "Nimike";
            this.Nimike.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lwVapaatHenkilot);
            this.groupBox2.Location = new System.Drawing.Point(1168, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox2.Size = new System.Drawing.Size(595, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vapaat henkilöt";
            // 
            // lwVapaatHenkilot
            // 
            this.lwVapaatHenkilot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lw_henkiloID,
            this.lw_HenkiloEtunimi,
            this.lv_HenkiloSukunimi,
            this.lw_HenkiloNimike});
            this.lwVapaatHenkilot.FullRowSelect = true;
            this.lwVapaatHenkilot.HideSelection = false;
            this.lwVapaatHenkilot.Location = new System.Drawing.Point(5, 21);
            this.lwVapaatHenkilot.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lwVapaatHenkilot.Name = "lwVapaatHenkilot";
            this.lwVapaatHenkilot.Size = new System.Drawing.Size(581, 366);
            this.lwVapaatHenkilot.TabIndex = 1;
            this.lwVapaatHenkilot.UseCompatibleStateImageBehavior = false;
            this.lwVapaatHenkilot.View = System.Windows.Forms.View.Details;
            this.lwVapaatHenkilot.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lwVapaatHenkilot_ItemSelectionChanged);
            // 
            // lw_henkiloID
            // 
            this.lw_henkiloID.Text = "ID";
            // 
            // lw_HenkiloEtunimi
            // 
            this.lw_HenkiloEtunimi.Text = "Etunimi";
            this.lw_HenkiloEtunimi.Width = 100;
            // 
            // lv_HenkiloSukunimi
            // 
            this.lv_HenkiloSukunimi.Text = "Sukunimi";
            this.lv_HenkiloSukunimi.Width = 150;
            // 
            // lw_HenkiloNimike
            // 
            this.lw_HenkiloNimike.Text = "Nimike";
            this.lw_HenkiloNimike.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lwVuorot);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(1156, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vuorot";
            // 
            // lwVuorot
            // 
            this.lwVuorot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lw_tyovuoroID,
            this.lw_Aloitus,
            this.lw_Lopetus,
            this.lw_Tehtava,
            this.lw_Paikka,
            this.lw_Nimike,
            this.lw_Maara,
            this.lw_Valittu});
            this.lwVuorot.FullRowSelect = true;
            this.lwVuorot.HideSelection = false;
            this.lwVuorot.Location = new System.Drawing.Point(5, 20);
            this.lwVuorot.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lwVuorot.Name = "lwVuorot";
            this.lwVuorot.Size = new System.Drawing.Size(1144, 366);
            this.lwVuorot.TabIndex = 0;
            this.lwVuorot.UseCompatibleStateImageBehavior = false;
            this.lwVuorot.View = System.Windows.Forms.View.Details;
            this.lwVuorot.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lwVuorot_ItemSelectionChanged);
            // 
            // lw_tyovuoroID
            // 
            this.lw_tyovuoroID.Text = "Vuoron ID";
            // 
            // lw_Aloitus
            // 
            this.lw_Aloitus.Text = "Aloitus";
            this.lw_Aloitus.Width = 150;
            // 
            // lw_Lopetus
            // 
            this.lw_Lopetus.Text = "Lopetus";
            this.lw_Lopetus.Width = 150;
            // 
            // lw_Tehtava
            // 
            this.lw_Tehtava.Text = "Tehtävä";
            this.lw_Tehtava.Width = 120;
            // 
            // lw_Paikka
            // 
            this.lw_Paikka.Text = "Paikka";
            this.lw_Paikka.Width = 75;
            // 
            // lw_Nimike
            // 
            this.lw_Nimike.Text = "Nimike";
            this.lw_Nimike.Width = 100;
            // 
            // lw_Maara
            // 
            this.lw_Maara.Text = "Määrä";
            this.lw_Maara.Width = 70;
            // 
            // lw_Valittu
            // 
            this.lw_Valittu.Text = "Kiinnitetyt";
            this.lw_Valittu.Width = 70;
            // 
            // tabTyöntekijänVuorot
            // 
            this.tabTyöntekijänVuorot.Controls.Add(this.panel3);
            this.tabTyöntekijänVuorot.Location = new System.Drawing.Point(4, 25);
            this.tabTyöntekijänVuorot.Margin = new System.Windows.Forms.Padding(4);
            this.tabTyöntekijänVuorot.Name = "tabTyöntekijänVuorot";
            this.tabTyöntekijänVuorot.Padding = new System.Windows.Forms.Padding(4);
            this.tabTyöntekijänVuorot.Size = new System.Drawing.Size(3177, 1630);
            this.tabTyöntekijänVuorot.TabIndex = 2;
            this.tabTyöntekijänVuorot.Text = "Työntekijän vuorolista";
            this.tabTyöntekijänVuorot.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dateTimePicker3);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.listBox5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(9, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 543);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(37, 287);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(549, 218);
            this.dataGridView2.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "-";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(357, 215);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(231, 22);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(37, 215);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(223, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Näytä työvuorot ajalta:";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(139, 44);
            this.listBox5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(449, 84);
            this.listBox5.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Työntekijä";
            // 
            // tabTyövuorolista
            // 
            this.tabTyövuorolista.Controls.Add(this.panel4);
            this.tabTyövuorolista.Location = new System.Drawing.Point(4, 25);
            this.tabTyövuorolista.Margin = new System.Windows.Forms.Padding(4);
            this.tabTyövuorolista.Name = "tabTyövuorolista";
            this.tabTyövuorolista.Padding = new System.Windows.Forms.Padding(4);
            this.tabTyövuorolista.Size = new System.Drawing.Size(3177, 1630);
            this.tabTyövuorolista.TabIndex = 3;
            this.tabTyövuorolista.Text = "Työvuorolista";
            this.tabTyövuorolista.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView3);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.dateTimePicker5);
            this.panel4.Controls.Add(this.dateTimePicker4);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(9, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 575);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(27, 134);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(557, 404);
            this.dataGridView3.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "-";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(355, 65);
            this.dateTimePicker5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(231, 22);
            this.dateTimePicker5.TabIndex = 2;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(27, 65);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(231, 22);
            this.dateTimePicker4.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Näytä työvuorolista ajalta:";
            // 
            // tabTyöntekijät
            // 
            this.tabTyöntekijät.Controls.Add(this.groupBox6);
            this.tabTyöntekijät.Controls.Add(this.tyontekijatdgv);
            this.tabTyöntekijät.Controls.Add(this.groupBox5);
            this.tabTyöntekijät.Controls.Add(this.groupBox3);
            this.tabTyöntekijät.Location = new System.Drawing.Point(4, 25);
            this.tabTyöntekijät.Margin = new System.Windows.Forms.Padding(4);
            this.tabTyöntekijät.Name = "tabTyöntekijät";
            this.tabTyöntekijät.Padding = new System.Windows.Forms.Padding(4);
            this.tabTyöntekijät.Size = new System.Drawing.Size(3177, 1630);
            this.tabTyöntekijät.TabIndex = 0;
            this.tabTyöntekijät.Text = "Työntekijähallinta";
            this.tabTyöntekijät.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lvNimikkeet);
            this.groupBox6.Controls.Add(this.btnPoistaNimike);
            this.groupBox6.Controls.Add(this.btnLisaaNimike);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.tbTyonimike);
            this.groupBox6.Location = new System.Drawing.Point(1700, 16);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(423, 790);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lisää työnimike";
            // 
            // lvNimikkeet
            // 
            this.lvNimikkeet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdNimike,
            this.Työnimike});
            this.lvNimikkeet.FullRowSelect = true;
            this.lvNimikkeet.HideSelection = false;
            this.lvNimikkeet.Location = new System.Drawing.Point(9, 231);
            this.lvNimikkeet.Margin = new System.Windows.Forms.Padding(4);
            this.lvNimikkeet.Name = "lvNimikkeet";
            this.lvNimikkeet.Size = new System.Drawing.Size(403, 550);
            this.lvNimikkeet.TabIndex = 41;
            this.lvNimikkeet.UseCompatibleStateImageBehavior = false;
            this.lvNimikkeet.View = System.Windows.Forms.View.Details;
            // 
            // IdNimike
            // 
            this.IdNimike.Text = "ID";
            // 
            // Työnimike
            // 
            this.Työnimike.Text = "Nimike";
            this.Työnimike.Width = 124;
            // 
            // btnPoistaNimike
            // 
            this.btnPoistaNimike.Location = new System.Drawing.Point(120, 94);
            this.btnPoistaNimike.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoistaNimike.Name = "btnPoistaNimike";
            this.btnPoistaNimike.Size = new System.Drawing.Size(100, 28);
            this.btnPoistaNimike.TabIndex = 10;
            this.btnPoistaNimike.Text = "Poista";
            this.btnPoistaNimike.UseVisualStyleBackColor = true;
            this.btnPoistaNimike.Click += new System.EventHandler(this.btnPoistaNimike_Click);
            // 
            // btnLisaaNimike
            // 
            this.btnLisaaNimike.Location = new System.Drawing.Point(12, 94);
            this.btnLisaaNimike.Margin = new System.Windows.Forms.Padding(4);
            this.btnLisaaNimike.Name = "btnLisaaNimike";
            this.btnLisaaNimike.Size = new System.Drawing.Size(100, 28);
            this.btnLisaaNimike.TabIndex = 10;
            this.btnLisaaNimike.Text = "Lisää";
            this.btnLisaaNimike.UseVisualStyleBackColor = true;
            this.btnLisaaNimike.Click += new System.EventHandler(this.btnLisaaNimike_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 37);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 16);
            this.label25.TabIndex = 9;
            this.label25.Text = "Työnimike";
            // 
            // tbTyonimike
            // 
            this.tbTyonimike.Location = new System.Drawing.Point(105, 38);
            this.tbTyonimike.Margin = new System.Windows.Forms.Padding(4);
            this.tbTyonimike.Name = "tbTyonimike";
            this.tbTyonimike.Size = new System.Drawing.Size(180, 22);
            this.tbTyonimike.TabIndex = 8;
            // 
            // tyontekijatdgv
            // 
            this.tyontekijatdgv.AllowUserToAddRows = false;
            this.tyontekijatdgv.AllowUserToDeleteRows = false;
            this.tyontekijatdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tyontekijatdgv.Location = new System.Drawing.Point(9, 247);
            this.tyontekijatdgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tyontekijatdgv.Name = "tyontekijatdgv";
            this.tyontekijatdgv.ReadOnly = true;
            this.tyontekijatdgv.RowHeadersWidth = 51;
            this.tyontekijatdgv.RowTemplate.Height = 24;
            this.tyontekijatdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tyontekijatdgv.Size = new System.Drawing.Size(1685, 559);
            this.tyontekijatdgv.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.idnimiketb);
            this.groupBox5.Controls.Add(this.idtyontekijatb);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.nimikecmb);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.emailtb);
            this.groupBox5.Controls.Add(this.puhelintb);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.sukunimitb);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.etunimitb);
            this.groupBox5.Location = new System.Drawing.Point(9, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(872, 224);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Syötä tiedot";
            // 
            // idnimiketb
            // 
            this.idnimiketb.Enabled = false;
            this.idnimiketb.Location = new System.Drawing.Point(553, 118);
            this.idnimiketb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idnimiketb.Name = "idnimiketb";
            this.idnimiketb.Size = new System.Drawing.Size(299, 22);
            this.idnimiketb.TabIndex = 20;
            // 
            // idtyontekijatb
            // 
            this.idtyontekijatb.Enabled = false;
            this.idtyontekijatb.Location = new System.Drawing.Point(135, 43);
            this.idtyontekijatb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idtyontekijatb.Name = "idtyontekijatb";
            this.idtyontekijatb.Size = new System.Drawing.Size(309, 22);
            this.idtyontekijatb.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(477, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 16);
            this.label17.TabIndex = 19;
            this.label17.Text = "Idnimike";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID";
            // 
            // nimikecmb
            // 
            this.nimikecmb.FormattingEnabled = true;
            this.nimikecmb.Location = new System.Drawing.Point(553, 76);
            this.nimikecmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nimikecmb.Name = "nimikecmb";
            this.nimikecmb.Size = new System.Drawing.Size(299, 24);
            this.nimikecmb.TabIndex = 18;
            this.nimikecmb.SelectedValueChanged += new System.EventHandler(this.nimikecmb_SelectedValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 18;
            this.label16.Text = "Sukunimi";
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(553, 39);
            this.emailtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(299, 22);
            this.emailtb.TabIndex = 17;
            // 
            // puhelintb
            // 
            this.puhelintb.Location = new System.Drawing.Point(135, 161);
            this.puhelintb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.puhelintb.Name = "puhelintb";
            this.puhelintb.Size = new System.Drawing.Size(309, 22);
            this.puhelintb.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(479, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 16);
            this.label18.TabIndex = 16;
            this.label18.Text = "Nimike";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Etunimi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(477, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 16);
            this.label19.TabIndex = 15;
            this.label19.Text = "Email";
            // 
            // sukunimitb
            // 
            this.sukunimitb.Location = new System.Drawing.Point(135, 123);
            this.sukunimitb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sukunimitb.Name = "sukunimitb";
            this.sukunimitb.Size = new System.Drawing.Size(309, 22);
            this.sukunimitb.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "Puhelin";
            // 
            // etunimitb
            // 
            this.etunimitb.Location = new System.Drawing.Point(135, 84);
            this.etunimitb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.etunimitb.Name = "etunimitb";
            this.etunimitb.Size = new System.Drawing.Size(309, 22);
            this.etunimitb.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tallennabtn);
            this.groupBox3.Controls.Add(this.tyhjennabtn);
            this.groupBox3.Controls.Add(this.lisaabtn);
            this.groupBox3.Controls.Add(this.poistabtn);
            this.groupBox3.Controls.Add(this.muokkaabtn);
            this.groupBox3.Location = new System.Drawing.Point(887, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox3.Size = new System.Drawing.Size(807, 224);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Työntekijöiden hallinta";
            // 
            // tallennabtn
            // 
            this.tallennabtn.Location = new System.Drawing.Point(628, 154);
            this.tallennabtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tallennabtn.Name = "tallennabtn";
            this.tallennabtn.Size = new System.Drawing.Size(161, 36);
            this.tallennabtn.TabIndex = 4;
            this.tallennabtn.Text = "Tallenna";
            this.tallennabtn.UseVisualStyleBackColor = true;
            this.tallennabtn.Click += new System.EventHandler(this.tallennabtn_Click);
            // 
            // tyhjennabtn
            // 
            this.tyhjennabtn.Location = new System.Drawing.Point(628, 37);
            this.tyhjennabtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tyhjennabtn.Name = "tyhjennabtn";
            this.tyhjennabtn.Size = new System.Drawing.Size(161, 36);
            this.tyhjennabtn.TabIndex = 3;
            this.tyhjennabtn.Text = "Tyhjennä";
            this.tyhjennabtn.UseVisualStyleBackColor = true;
            this.tyhjennabtn.Click += new System.EventHandler(this.tyhjennabtn_Click);
            // 
            // lisaabtn
            // 
            this.lisaabtn.Location = new System.Drawing.Point(31, 33);
            this.lisaabtn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lisaabtn.Name = "lisaabtn";
            this.lisaabtn.Size = new System.Drawing.Size(161, 36);
            this.lisaabtn.TabIndex = 2;
            this.lisaabtn.Text = "Lisää";
            this.lisaabtn.UseVisualStyleBackColor = true;
            this.lisaabtn.Click += new System.EventHandler(this.lisaabtn_Click);
            // 
            // poistabtn
            // 
            this.poistabtn.Location = new System.Drawing.Point(31, 151);
            this.poistabtn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.poistabtn.Name = "poistabtn";
            this.poistabtn.Size = new System.Drawing.Size(161, 36);
            this.poistabtn.TabIndex = 1;
            this.poistabtn.Text = "Poista";
            this.poistabtn.UseVisualStyleBackColor = true;
            this.poistabtn.Click += new System.EventHandler(this.poistabtn_Click);
            // 
            // muokkaabtn
            // 
            this.muokkaabtn.Location = new System.Drawing.Point(31, 95);
            this.muokkaabtn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.muokkaabtn.Name = "muokkaabtn";
            this.muokkaabtn.Size = new System.Drawing.Size(161, 33);
            this.muokkaabtn.TabIndex = 0;
            this.muokkaabtn.Text = "Muokkaa";
            this.muokkaabtn.UseVisualStyleBackColor = true;
            this.muokkaabtn.Click += new System.EventHandler(this.muokkaabtn_Click);
            // 
            // tabTehtävät
            // 
            this.tabTehtävät.Controls.Add(this.panel5);
            this.tabTehtävät.Location = new System.Drawing.Point(4, 25);
            this.tabTehtävät.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTehtävät.Name = "tabTehtävät";
            this.tabTehtävät.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTehtävät.Size = new System.Drawing.Size(3177, 1630);
            this.tabTehtävät.TabIndex = 5;
            this.tabTehtävät.Text = "Työtehtävien hallinta";
            this.tabTehtävät.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblOhjeKentta);
            this.panel5.Controls.Add(this.lblidnimike);
            this.panel5.Controls.Add(this.dgvTehtavat);
            this.panel5.Controls.Add(this.btnTyhjennaKentatTehtava);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.comboNimike);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.comboPaikka);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.btnPoista);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.btnMuokkaa);
            this.panel5.Controls.Add(this.tbTehtava);
            this.panel5.Controls.Add(this.btnTallenna);
            this.panel5.Location = new System.Drawing.Point(23, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1713, 785);
            this.panel5.TabIndex = 35;
            // 
            // lblOhjeKentta
            // 
            this.lblOhjeKentta.AutoSize = true;
            this.lblOhjeKentta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOhjeKentta.Location = new System.Drawing.Point(495, 740);
            this.lblOhjeKentta.Name = "lblOhjeKentta";
            this.lblOhjeKentta.Size = new System.Drawing.Size(84, 20);
            this.lblOhjeKentta.TabIndex = 37;
            this.lblOhjeKentta.Text = "Info label";
            // 
            // lblidnimike
            // 
            this.lblidnimike.AutoSize = true;
            this.lblidnimike.Location = new System.Drawing.Point(20, 198);
            this.lblidnimike.Name = "lblidnimike";
            this.lblidnimike.Size = new System.Drawing.Size(63, 16);
            this.lblidnimike.TabIndex = 36;
            this.lblidnimike.Text = "NimikeID";
            this.lblidnimike.Visible = false;
            // 
            // dgvTehtavat
            // 
            this.dgvTehtavat.AllowUserToAddRows = false;
            this.dgvTehtavat.AllowUserToDeleteRows = false;
            this.dgvTehtavat.AllowUserToOrderColumns = true;
            this.dgvTehtavat.AllowUserToResizeRows = false;
            this.dgvTehtavat.BackgroundColor = System.Drawing.Color.White;
            this.dgvTehtavat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTehtavat.Location = new System.Drawing.Point(497, 15);
            this.dgvTehtavat.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvTehtavat.Name = "dgvTehtavat";
            this.dgvTehtavat.ReadOnly = true;
            this.dgvTehtavat.RowHeadersWidth = 60;
            this.dgvTehtavat.RowTemplate.Height = 24;
            this.dgvTehtavat.Size = new System.Drawing.Size(1113, 709);
            this.dgvTehtavat.TabIndex = 35;
            this.dgvTehtavat.SelectionChanged += new System.EventHandler(this.dgvTehtavat_SelectionChanged);
            // 
            // btnTyhjennaKentatTehtava
            // 
            this.btnTyhjennaKentatTehtava.Location = new System.Drawing.Point(23, 367);
            this.btnTyhjennaKentatTehtava.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTyhjennaKentatTehtava.Name = "btnTyhjennaKentatTehtava";
            this.btnTyhjennaKentatTehtava.Size = new System.Drawing.Size(163, 39);
            this.btnTyhjennaKentatTehtava.TabIndex = 34;
            this.btnTyhjennaKentatTehtava.Text = "Tyhjennä kentät";
            this.btnTyhjennaKentatTehtava.UseVisualStyleBackColor = true;
            this.btnTyhjennaKentatTehtava.Click += new System.EventHandler(this.btnTyhjennaKentatTehtava_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(19, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "Lisää työtehtävä";
            // 
            // comboNimike
            // 
            this.comboNimike.FormattingEnabled = true;
            this.comboNimike.Location = new System.Drawing.Point(156, 177);
            this.comboNimike.Margin = new System.Windows.Forms.Padding(4);
            this.comboNimike.Name = "comboNimike";
            this.comboNimike.Size = new System.Drawing.Size(268, 24);
            this.comboNimike.TabIndex = 32;
            this.comboNimike.SelectedIndexChanged += new System.EventHandler(this.comboNimike_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Paikka";
            // 
            // comboPaikka
            // 
            this.comboPaikka.FormattingEnabled = true;
            this.comboPaikka.Items.AddRange(new object[] {
            "Osasto A",
            "Osasto B"});
            this.comboPaikka.Location = new System.Drawing.Point(156, 117);
            this.comboPaikka.Margin = new System.Windows.Forms.Padding(4);
            this.comboPaikka.Name = "comboPaikka";
            this.comboPaikka.Size = new System.Drawing.Size(267, 24);
            this.comboPaikka.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nimike";
            // 
            // btnPoista
            // 
            this.btnPoista.Enabled = false;
            this.btnPoista.Location = new System.Drawing.Point(202, 299);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(163, 39);
            this.btnPoista.TabIndex = 30;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tehtävä";
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Enabled = false;
            this.btnMuokkaa.Location = new System.Drawing.Point(202, 367);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(163, 39);
            this.btnMuokkaa.TabIndex = 31;
            this.btnMuokkaa.Text = "Tallenna muutokset";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // tbTehtava
            // 
            this.tbTehtava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTehtava.Location = new System.Drawing.Point(156, 54);
            this.tbTehtava.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbTehtava.Name = "tbTehtava";
            this.tbTehtava.Size = new System.Drawing.Size(268, 23);
            this.tbTehtava.TabIndex = 28;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(23, 299);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(163, 39);
            this.btnTallenna.TabIndex = 29;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Työvuorosuunnittelu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tabEtusivu.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabVuorot.ResumeLayout(false);
            this.tabVuorot.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarpeet)).EndInit();
            this.tabKiinnitys.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabTyöntekijänVuorot.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabTyövuorolista.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabTyöntekijät.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tyontekijatdgv)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabTehtävät.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTehtavat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTyöntekijät;
        private System.Windows.Forms.TabPage tabVuorot;
        private System.Windows.Forms.TabPage tabTyöntekijänVuorot;
        private System.Windows.Forms.TabPage tabTyövuorolista;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabKiinnitys;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lwVuorot;
        private System.Windows.Forms.ColumnHeader lw_tyovuoroID;
        private System.Windows.Forms.ColumnHeader lw_Aloitus;
        private System.Windows.Forms.ColumnHeader lw_Lopetus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button lisaabtn;
        private System.Windows.Forms.Button poistabtn;
        private System.Windows.Forms.Button muokkaabtn;
        private System.Windows.Forms.ColumnHeader lw_Tehtava;
        private System.Windows.Forms.ColumnHeader lw_Paikka;
        private System.Windows.Forms.ColumnHeader lw_Nimike;
        private System.Windows.Forms.ColumnHeader lw_Maara;
        private System.Windows.Forms.TextBox tbvuoroloppuu;
        private System.Windows.Forms.TextBox tbvuoroalkaa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lwKiinnitykset;
        private System.Windows.Forms.ColumnHeader vuoroID;
        private System.Windows.Forms.ColumnHeader TehtavaID;
        private System.Windows.Forms.ColumnHeader Etunimi;
        private System.Windows.Forms.ColumnHeader Sukunimi;
        private System.Windows.Forms.ListView lwVapaatHenkilot;
        private System.Windows.Forms.ColumnHeader lw_henkiloID;
        private System.Windows.Forms.ColumnHeader lw_HenkiloEtunimi;
        private System.Windows.Forms.ColumnHeader lv_HenkiloSukunimi;
        private System.Windows.Forms.ColumnHeader lw_HenkiloNimike;
        private System.Windows.Forms.ColumnHeader lw_Valittu;
        private System.Windows.Forms.ColumnHeader Nimike;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPoistaKiinnitys;
        private System.Windows.Forms.Button btn_Kiinnita;
        private System.Windows.Forms.Button btn_PeruutaTyontekija;
        private System.Windows.Forms.Button btn_PeruutaVuoro;
        private System.Windows.Forms.Button btn_ValitseVuoro;
        private System.Windows.Forms.Button btn_ValitseTyontekija;
        private System.Windows.Forms.TextBox tb_tyontekijavalittu;
        private System.Windows.Forms.TextBox tb_vuorovalittu;
        private System.Windows.Forms.ColumnHeader tyontekijaID;
        private System.Windows.Forms.Button tyhjennabtn;
        private System.Windows.Forms.DataGridView tyontekijatdgv;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox idnimiketb;
        private System.Windows.Forms.TextBox idtyontekijatb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nimikecmb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox puhelintb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox sukunimitb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox etunimitb;
        private System.Windows.Forms.Button tallennabtn;
        private System.Windows.Forms.TabPage tabTehtävät;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvTehtavat;
        private System.Windows.Forms.Button btnTyhjennaKentatTehtava;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboNimike;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPaikka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.TextBox tbTehtava;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numMaara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTyhjennaKentatTarve;
        private System.Windows.Forms.Button btnTyhjennaKentatVuoro;
        private System.Windows.Forms.ComboBox comboLoppuu;
        private System.Windows.Forms.ComboBox comboAlkaa;
        private System.Windows.Forms.Button btnPoistaTarve;
        private System.Windows.Forms.Button btnMuokkaaTarve;
        private System.Windows.Forms.Button btnPoistaVuoro;
        private System.Windows.Forms.Button btnTallennaTarve;
        private System.Windows.Forms.Button btnMuokkaaVuoroa;
        private System.Windows.Forms.Button btnTallennaVuoro;
        private System.Windows.Forms.DateTimePicker dtpPvmLoppuu;
        private System.Windows.Forms.DateTimePicker dtpPvmAlkaa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTarpeet;
        private System.Windows.Forms.ComboBox comboTehtavat;
        private System.Windows.Forms.TextBox tbTyovuoroValinta;
        private System.Windows.Forms.Label lblidnimike;
        private System.Windows.Forms.Label lblOhjeKentta;
        private System.Windows.Forms.TabPage tabEtusivu;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnTyontekijat;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnTyotehtavat;
        private System.Windows.Forms.Button btnTyovuorolistat;
        private System.Windows.Forms.Button btnTtVuorolista;
        private System.Windows.Forms.Button btnTyovuorot;
        private System.Windows.Forms.Button btnKiinnitykset;
        private System.Windows.Forms.ListView listviewTyoVuorot;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Alkaa;
        private System.Windows.Forms.ColumnHeader Loppuu;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbTyonimike;
        private System.Windows.Forms.Button btnLisaaNimike;
        private System.Windows.Forms.ListView lvNimikkeet;
        private System.Windows.Forms.Button btnPoistaNimike;
        private System.Windows.Forms.ColumnHeader IdNimike;
        private System.Windows.Forms.ColumnHeader Työnimike;
    }
}

