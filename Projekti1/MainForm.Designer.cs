
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
            this.tabVapaalista = new System.Windows.Forms.TabPage();
            this.btnVapaalista = new System.Windows.Forms.Button();
            this.dtpVapaaLoppuu = new System.Windows.Forms.DateTimePicker();
            this.dtpVapaaAlkaa = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.tabTehtävät = new System.Windows.Forms.TabPage();
            this.dgvTehtavat = new System.Windows.Forms.DataGridView();
            this.tabTyöntekijät = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPoistaNimike = new System.Windows.Forms.Button();
            this.btnLisaaNimike = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.tbTyonimike = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tyhjennabtn = new System.Windows.Forms.Button();
            this.tallennabtn = new System.Windows.Forms.Button();
            this.idnimiketb = new System.Windows.Forms.TextBox();
            this.idtyontekijatb = new System.Windows.Forms.TextBox();
            this.poistabtn = new System.Windows.Forms.Button();
            this.lisaabtn = new System.Windows.Forms.Button();
            this.muokkaabtn = new System.Windows.Forms.Button();
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
            this.tabTyövuorolista = new System.Windows.Forms.TabPage();
            this.lvVuorolista = new System.Windows.Forms.ListView();
            this.TyövuoroAlku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TyövuoroLoppu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paikka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tehtävä = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Enimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sNimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Puhnumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tehtavanimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHaeTyovuorolista = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpVuorolistaLoppuu = new System.Windows.Forms.DateTimePicker();
            this.dtpVuorolistaAlkaa = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.tabTyöntekijänVuorot = new System.Windows.Forms.TabPage();
            this.lwTyontekijanVuorot = new System.Windows.Forms.ListView();
            this.vAlkaa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vLoppuu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vTehtava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vPaikka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTyontekijanLista = new System.Windows.Forms.Button();
            this.comboTyontekijat = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.dtpAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabKiinnitys = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lwKiinnitykset = new System.Windows.Forms.ListView();
            this.vuoroID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TehtavaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tyontekijaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sukunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPoistaKiinnitys = new System.Windows.Forms.Button();
            this.btn_Kiinnita = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_tyontekijavalittu = new System.Windows.Forms.TextBox();
            this.btn_PeruutaTyontekija = new System.Windows.Forms.Button();
            this.lwVapaatHenkilot = new System.Windows.Forms.ListView();
            this.lw_henkiloID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_HenkiloEtunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_HenkiloSukunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_HenkiloNimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ValitseTyontekija = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_vuorovalittu = new System.Windows.Forms.TextBox();
            this.lwVuorot = new System.Windows.Forms.ListView();
            this.lw_tyovuoroID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Aloitus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Lopetus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Tehtava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Paikka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Nimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Maara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lw_Valittu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_PeruutaVuoro = new System.Windows.Forms.Button();
            this.btn_ValitseVuoro = new System.Windows.Forms.Button();
            this.tabVuorot = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVuoroId = new System.Windows.Forms.Label();
            this.lblTehtavaID = new System.Windows.Forms.Label();
            this.listviewTyoVuorot = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alkaa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loppuu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTyovuoroValinta = new System.Windows.Forms.TextBox();
            this.comboTehtavat = new System.Windows.Forms.ComboBox();
            this.numMaara = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboLoppuu = new System.Windows.Forms.ComboBox();
            this.comboAlkaa = new System.Windows.Forms.ComboBox();
            this.btnPoistaTarve = new System.Windows.Forms.Button();
            this.btnPoistaVuoro = new System.Windows.Forms.Button();
            this.btnTallennaTarve = new System.Windows.Forms.Button();
            this.btnTallennaVuoro = new System.Windows.Forms.Button();
            this.dgvTarpeet = new System.Windows.Forms.DataGridView();
            this.dtpPvmLoppuu = new System.Windows.Forms.DateTimePicker();
            this.dtpPvmAlkaa = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabEtusivu = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnTyotehtavat = new System.Windows.Forms.Button();
            this.btnVapaatLista = new System.Windows.Forms.Button();
            this.btnTyovuorolistat = new System.Windows.Forms.Button();
            this.btnTtVuorolista = new System.Windows.Forms.Button();
            this.btnTyovuorot = new System.Windows.Forms.Button();
            this.btnKiinnitykset = new System.Windows.Forms.Button();
            this.btnTyontekijat = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tyontekijatdgv = new System.Windows.Forms.DataGridView();
            this.lvNimikkeet = new System.Windows.Forms.ListView();
            this.IdNimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Työnimike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.tbTehtava = new System.Windows.Forms.TextBox();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboPaikka = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboNimike = new System.Windows.Forms.ComboBox();
            this.lblidnimike = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwVapaalista = new System.Windows.Forms.ListView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tabVapaalista.SuspendLayout();
            this.tabTehtävät.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTehtavat)).BeginInit();
            this.tabTyöntekijät.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabTyövuorolista.SuspendLayout();
            this.tabTyöntekijänVuorot.SuspendLayout();
            this.tabKiinnitys.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabVuorot.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarpeet)).BeginInit();
            this.tabEtusivu.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tyontekijatdgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVapaalista
            // 
            this.tabVapaalista.BackColor = System.Drawing.Color.DimGray;
            this.tabVapaalista.Controls.Add(this.groupBox10);
            this.tabVapaalista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabVapaalista.Location = new System.Drawing.Point(4, 29);
            this.tabVapaalista.Margin = new System.Windows.Forms.Padding(2);
            this.tabVapaalista.Name = "tabVapaalista";
            this.tabVapaalista.Size = new System.Drawing.Size(1896, 1008);
            this.tabVapaalista.TabIndex = 7;
            this.tabVapaalista.Text = "Vapaalista";
            // 
            // btnVapaalista
            // 
            this.btnVapaalista.BackColor = System.Drawing.Color.Gray;
            this.btnVapaalista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVapaalista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVapaalista.Location = new System.Drawing.Point(22, 134);
            this.btnVapaalista.Margin = new System.Windows.Forms.Padding(2);
            this.btnVapaalista.Name = "btnVapaalista";
            this.btnVapaalista.Size = new System.Drawing.Size(120, 37);
            this.btnVapaalista.TabIndex = 8;
            this.btnVapaalista.Text = "Hae";
            this.btnVapaalista.UseVisualStyleBackColor = false;
            // 
            // dtpVapaaLoppuu
            // 
            this.dtpVapaaLoppuu.Location = new System.Drawing.Point(288, 71);
            this.dtpVapaaLoppuu.Margin = new System.Windows.Forms.Padding(2);
            this.dtpVapaaLoppuu.Name = "dtpVapaaLoppuu";
            this.dtpVapaaLoppuu.Size = new System.Drawing.Size(240, 26);
            this.dtpVapaaLoppuu.TabIndex = 7;
            // 
            // dtpVapaaAlkaa
            // 
            this.dtpVapaaAlkaa.Location = new System.Drawing.Point(20, 71);
            this.dtpVapaaAlkaa.Margin = new System.Windows.Forms.Padding(2);
            this.dtpVapaaAlkaa.Name = "dtpVapaaAlkaa";
            this.dtpVapaaAlkaa.Size = new System.Drawing.Size(242, 26);
            this.dtpVapaaAlkaa.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label26.Location = new System.Drawing.Point(17, 31);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(124, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "Valitse päivämäärät";
            // 
            // tabTehtävät
            // 
            this.tabTehtävät.BackColor = System.Drawing.Color.DimGray;
            this.tabTehtävät.Controls.Add(this.groupBox3);
            this.tabTehtävät.Location = new System.Drawing.Point(4, 29);
            this.tabTehtävät.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabTehtävät.Name = "tabTehtävät";
            this.tabTehtävät.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabTehtävät.Size = new System.Drawing.Size(1896, 1008);
            this.tabTehtävät.TabIndex = 5;
            this.tabTehtävät.Text = "Työtehtävien hallinta";
            // 
            // dgvTehtavat
            // 
            this.dgvTehtavat.AllowUserToAddRows = false;
            this.dgvTehtavat.AllowUserToDeleteRows = false;
            this.dgvTehtavat.AllowUserToOrderColumns = true;
            this.dgvTehtavat.AllowUserToResizeRows = false;
            this.dgvTehtavat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTehtavat.BackgroundColor = System.Drawing.Color.White;
            this.dgvTehtavat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTehtavat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTehtavat.Location = new System.Drawing.Point(21, 311);
            this.dgvTehtavat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvTehtavat.Name = "dgvTehtavat";
            this.dgvTehtavat.ReadOnly = true;
            this.dgvTehtavat.RowHeadersWidth = 30;
            this.dgvTehtavat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTehtavat.RowTemplate.Height = 24;
            this.dgvTehtavat.Size = new System.Drawing.Size(735, 666);
            this.dgvTehtavat.TabIndex = 35;
            this.dgvTehtavat.SelectionChanged += new System.EventHandler(this.dgvTehtavat_SelectionChanged);
            // 
            // tabTyöntekijät
            // 
            this.tabTyöntekijät.BackColor = System.Drawing.Color.DimGray;
            this.tabTyöntekijät.Controls.Add(this.groupBox6);
            this.tabTyöntekijät.Controls.Add(this.groupBox5);
            this.tabTyöntekijät.Location = new System.Drawing.Point(4, 29);
            this.tabTyöntekijät.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTyöntekijät.Name = "tabTyöntekijät";
            this.tabTyöntekijät.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTyöntekijät.Size = new System.Drawing.Size(1896, 1008);
            this.tabTyöntekijät.TabIndex = 0;
            this.tabTyöntekijät.Text = "Työntekijähallinta";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.lvNimikkeet);
            this.groupBox6.Controls.Add(this.btnPoistaNimike);
            this.groupBox6.Controls.Add(this.btnLisaaNimike);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.tbTyonimike);
            this.groupBox6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(1021, 8);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(317, 996);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lisää työnimike";
            // 
            // btnPoistaNimike
            // 
            this.btnPoistaNimike.BackColor = System.Drawing.Color.Gray;
            this.btnPoistaNimike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoistaNimike.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaNimike.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoistaNimike.Location = new System.Drawing.Point(124, 78);
            this.btnPoistaNimike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPoistaNimike.Name = "btnPoistaNimike";
            this.btnPoistaNimike.Size = new System.Drawing.Size(91, 28);
            this.btnPoistaNimike.TabIndex = 10;
            this.btnPoistaNimike.Text = "Poista";
            this.btnPoistaNimike.UseVisualStyleBackColor = false;
            this.btnPoistaNimike.Click += new System.EventHandler(this.btnPoistaNimike_Click);
            // 
            // btnLisaaNimike
            // 
            this.btnLisaaNimike.BackColor = System.Drawing.Color.Gray;
            this.btnLisaaNimike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisaaNimike.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaNimike.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLisaaNimike.Location = new System.Drawing.Point(10, 78);
            this.btnLisaaNimike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLisaaNimike.Name = "btnLisaaNimike";
            this.btnLisaaNimike.Size = new System.Drawing.Size(91, 28);
            this.btnLisaaNimike.TabIndex = 10;
            this.btnLisaaNimike.Text = "Lisää";
            this.btnLisaaNimike.UseVisualStyleBackColor = false;
            this.btnLisaaNimike.Click += new System.EventHandler(this.btnLisaaNimike_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label25.Location = new System.Drawing.Point(6, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 20);
            this.label25.TabIndex = 9;
            this.label25.Text = "Työnimike";
            // 
            // tbTyonimike
            // 
            this.tbTyonimike.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTyonimike.Location = new System.Drawing.Point(79, 38);
            this.tbTyonimike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTyonimike.Name = "tbTyonimike";
            this.tbTyonimike.Size = new System.Drawing.Size(136, 26);
            this.tbTyonimike.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.tyontekijatdgv);
            this.groupBox5.Controls.Add(this.tyhjennabtn);
            this.groupBox5.Controls.Add(this.tallennabtn);
            this.groupBox5.Controls.Add(this.idnimiketb);
            this.groupBox5.Controls.Add(this.idtyontekijatb);
            this.groupBox5.Controls.Add(this.poistabtn);
            this.groupBox5.Controls.Add(this.lisaabtn);
            this.groupBox5.Controls.Add(this.muokkaabtn);
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
            this.groupBox5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(7, 8);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox5.Size = new System.Drawing.Size(1009, 996);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Työntekijöiden hallinta";
            // 
            // tyhjennabtn
            // 
            this.tyhjennabtn.BackColor = System.Drawing.Color.Gray;
            this.tyhjennabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tyhjennabtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennabtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tyhjennabtn.Location = new System.Drawing.Point(720, 153);
            this.tyhjennabtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tyhjennabtn.Name = "tyhjennabtn";
            this.tyhjennabtn.Size = new System.Drawing.Size(268, 36);
            this.tyhjennabtn.TabIndex = 3;
            this.tyhjennabtn.Text = "Tyhjennä";
            this.tyhjennabtn.UseVisualStyleBackColor = false;
            this.tyhjennabtn.Click += new System.EventHandler(this.tyhjennabtn_Click);
            // 
            // tallennabtn
            // 
            this.tallennabtn.BackColor = System.Drawing.Color.Gray;
            this.tallennabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tallennabtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallennabtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tallennabtn.Location = new System.Drawing.Point(862, 74);
            this.tallennabtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tallennabtn.Name = "tallennabtn";
            this.tallennabtn.Size = new System.Drawing.Size(126, 36);
            this.tallennabtn.TabIndex = 4;
            this.tallennabtn.Text = "Tallenna";
            this.tallennabtn.UseVisualStyleBackColor = false;
            this.tallennabtn.Click += new System.EventHandler(this.tallennabtn_Click);
            // 
            // idnimiketb
            // 
            this.idnimiketb.Enabled = false;
            this.idnimiketb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idnimiketb.Location = new System.Drawing.Point(416, 102);
            this.idnimiketb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.idnimiketb.Name = "idnimiketb";
            this.idnimiketb.Size = new System.Drawing.Size(225, 26);
            this.idnimiketb.TabIndex = 20;
            // 
            // idtyontekijatb
            // 
            this.idtyontekijatb.Enabled = false;
            this.idtyontekijatb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtyontekijatb.Location = new System.Drawing.Point(85, 30);
            this.idtyontekijatb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.idtyontekijatb.Name = "idtyontekijatb";
            this.idtyontekijatb.Size = new System.Drawing.Size(233, 26);
            this.idtyontekijatb.TabIndex = 24;
            // 
            // poistabtn
            // 
            this.poistabtn.BackColor = System.Drawing.Color.Gray;
            this.poistabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poistabtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistabtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.poistabtn.Location = new System.Drawing.Point(720, 74);
            this.poistabtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.poistabtn.Name = "poistabtn";
            this.poistabtn.Size = new System.Drawing.Size(126, 36);
            this.poistabtn.TabIndex = 1;
            this.poistabtn.Text = "Poista";
            this.poistabtn.UseVisualStyleBackColor = false;
            this.poistabtn.Click += new System.EventHandler(this.poistabtn_Click);
            // 
            // lisaabtn
            // 
            this.lisaabtn.BackColor = System.Drawing.Color.Gray;
            this.lisaabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lisaabtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaabtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lisaabtn.Location = new System.Drawing.Point(720, 21);
            this.lisaabtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lisaabtn.Name = "lisaabtn";
            this.lisaabtn.Size = new System.Drawing.Size(126, 36);
            this.lisaabtn.TabIndex = 2;
            this.lisaabtn.Text = "Lisää";
            this.lisaabtn.UseVisualStyleBackColor = false;
            this.lisaabtn.Click += new System.EventHandler(this.lisaabtn_Click);
            // 
            // muokkaabtn
            // 
            this.muokkaabtn.BackColor = System.Drawing.Color.Gray;
            this.muokkaabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muokkaabtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaabtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.muokkaabtn.Location = new System.Drawing.Point(862, 21);
            this.muokkaabtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.muokkaabtn.Name = "muokkaabtn";
            this.muokkaabtn.Size = new System.Drawing.Size(126, 36);
            this.muokkaabtn.TabIndex = 0;
            this.muokkaabtn.Text = "Muokkaa";
            this.muokkaabtn.UseVisualStyleBackColor = false;
            this.muokkaabtn.Click += new System.EventHandler(this.muokkaabtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(349, 104);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Idnimike";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID";
            // 
            // nimikecmb
            // 
            this.nimikecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nimikecmb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimikecmb.FormattingEnabled = true;
            this.nimikecmb.Location = new System.Drawing.Point(416, 64);
            this.nimikecmb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nimikecmb.Name = "nimikecmb";
            this.nimikecmb.Size = new System.Drawing.Size(225, 28);
            this.nimikecmb.TabIndex = 18;
            this.nimikecmb.SelectedValueChanged += new System.EventHandler(this.nimikecmb_SelectedValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(18, 104);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Sukunimi";
            // 
            // emailtb
            // 
            this.emailtb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtb.Location = new System.Drawing.Point(416, 30);
            this.emailtb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(225, 26);
            this.emailtb.TabIndex = 17;
            // 
            // puhelintb
            // 
            this.puhelintb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelintb.Location = new System.Drawing.Point(85, 138);
            this.puhelintb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.puhelintb.Name = "puhelintb";
            this.puhelintb.Size = new System.Drawing.Size(233, 26);
            this.puhelintb.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(349, 68);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 20);
            this.label18.TabIndex = 16;
            this.label18.Text = "Nimike";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(18, 68);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Etunimi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Location = new System.Drawing.Point(349, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 20);
            this.label19.TabIndex = 15;
            this.label19.Text = "Email";
            // 
            // sukunimitb
            // 
            this.sukunimitb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukunimitb.Location = new System.Drawing.Point(85, 102);
            this.sukunimitb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.sukunimitb.Name = "sukunimitb";
            this.sukunimitb.Size = new System.Drawing.Size(233, 26);
            this.sukunimitb.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(18, 140);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Puhelin";
            // 
            // etunimitb
            // 
            this.etunimitb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etunimitb.Location = new System.Drawing.Point(85, 66);
            this.etunimitb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.etunimitb.Name = "etunimitb";
            this.etunimitb.Size = new System.Drawing.Size(233, 26);
            this.etunimitb.TabIndex = 20;
            // 
            // tabTyövuorolista
            // 
            this.tabTyövuorolista.BackColor = System.Drawing.Color.DimGray;
            this.tabTyövuorolista.Controls.Add(this.groupBox11);
            this.tabTyövuorolista.Location = new System.Drawing.Point(4, 29);
            this.tabTyövuorolista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTyövuorolista.Name = "tabTyövuorolista";
            this.tabTyövuorolista.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTyövuorolista.Size = new System.Drawing.Size(1896, 1008);
            this.tabTyövuorolista.TabIndex = 3;
            this.tabTyövuorolista.Text = "Työvuorolista";
            // 
            // lvVuorolista
            // 
            this.lvVuorolista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvVuorolista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TyövuoroAlku,
            this.TyövuoroLoppu,
            this.Paikka,
            this.Tehtävä,
            this.Enimi,
            this.sNimi,
            this.Puhnumero,
            this.Tehtavanimike});
            this.lvVuorolista.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVuorolista.HideSelection = false;
            this.lvVuorolista.Location = new System.Drawing.Point(20, 190);
            this.lvVuorolista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvVuorolista.Name = "lvVuorolista";
            this.lvVuorolista.Size = new System.Drawing.Size(964, 801);
            this.lvVuorolista.TabIndex = 6;
            this.lvVuorolista.UseCompatibleStateImageBehavior = false;
            this.lvVuorolista.View = System.Windows.Forms.View.Details;
            // 
            // TyövuoroAlku
            // 
            this.TyövuoroAlku.Text = "Vuoro alkaa";
            this.TyövuoroAlku.Width = 120;
            // 
            // TyövuoroLoppu
            // 
            this.TyövuoroLoppu.Text = "Vuoro loppuu";
            this.TyövuoroLoppu.Width = 120;
            // 
            // Paikka
            // 
            this.Paikka.Text = "Paikka";
            this.Paikka.Width = 120;
            // 
            // Tehtävä
            // 
            this.Tehtävä.Text = "Tehtävä";
            this.Tehtävä.Width = 120;
            // 
            // Enimi
            // 
            this.Enimi.Text = "Etunimi";
            this.Enimi.Width = 120;
            // 
            // sNimi
            // 
            this.sNimi.Text = "Sukunimi";
            this.sNimi.Width = 120;
            // 
            // Puhnumero
            // 
            this.Puhnumero.Text = "Puhelinnumero";
            this.Puhnumero.Width = 120;
            // 
            // Tehtavanimike
            // 
            this.Tehtavanimike.Text = "Nimike";
            this.Tehtavanimike.Width = 120;
            // 
            // btnHaeTyovuorolista
            // 
            this.btnHaeTyovuorolista.BackColor = System.Drawing.Color.Gray;
            this.btnHaeTyovuorolista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaeTyovuorolista.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaeTyovuorolista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHaeTyovuorolista.Location = new System.Drawing.Point(21, 134);
            this.btnHaeTyovuorolista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHaeTyovuorolista.Name = "btnHaeTyovuorolista";
            this.btnHaeTyovuorolista.Size = new System.Drawing.Size(120, 37);
            this.btnHaeTyovuorolista.TabIndex = 5;
            this.btnHaeTyovuorolista.Text = "Hae";
            this.btnHaeTyovuorolista.UseVisualStyleBackColor = false;
            this.btnHaeTyovuorolista.Click += new System.EventHandler(this.btnHaeTyovuorolista_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(269, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "-";
            // 
            // dtpVuorolistaLoppuu
            // 
            this.dtpVuorolistaLoppuu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVuorolistaLoppuu.Location = new System.Drawing.Point(291, 71);
            this.dtpVuorolistaLoppuu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpVuorolistaLoppuu.Name = "dtpVuorolistaLoppuu";
            this.dtpVuorolistaLoppuu.Size = new System.Drawing.Size(245, 26);
            this.dtpVuorolistaLoppuu.TabIndex = 2;
            this.dtpVuorolistaLoppuu.ValueChanged += new System.EventHandler(this.dtpVuorolistaLoppuu_ValueChanged);
            // 
            // dtpVuorolistaAlkaa
            // 
            this.dtpVuorolistaAlkaa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVuorolistaAlkaa.Location = new System.Drawing.Point(20, 71);
            this.dtpVuorolistaAlkaa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpVuorolistaAlkaa.Name = "dtpVuorolistaAlkaa";
            this.dtpVuorolistaAlkaa.Size = new System.Drawing.Size(245, 26);
            this.dtpVuorolistaAlkaa.TabIndex = 1;
            this.dtpVuorolistaAlkaa.ValueChanged += new System.EventHandler(this.dtpVuorolistaAlkaa_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Valitse päivämäärät";
            // 
            // tabTyöntekijänVuorot
            // 
            this.tabTyöntekijänVuorot.BackColor = System.Drawing.Color.DimGray;
            this.tabTyöntekijänVuorot.Controls.Add(this.groupBox7);
            this.tabTyöntekijänVuorot.Location = new System.Drawing.Point(4, 29);
            this.tabTyöntekijänVuorot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTyöntekijänVuorot.Name = "tabTyöntekijänVuorot";
            this.tabTyöntekijänVuorot.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTyöntekijänVuorot.Size = new System.Drawing.Size(1896, 1008);
            this.tabTyöntekijänVuorot.TabIndex = 2;
            this.tabTyöntekijänVuorot.Text = "Työntekijän vuorolista";
            // 
            // lwTyontekijanVuorot
            // 
            this.lwTyontekijanVuorot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwTyontekijanVuorot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vAlkaa,
            this.vLoppuu,
            this.vTehtava,
            this.vPaikka});
            this.lwTyontekijanVuorot.HideSelection = false;
            this.lwTyontekijanVuorot.Location = new System.Drawing.Point(14, 262);
            this.lwTyontekijanVuorot.Margin = new System.Windows.Forms.Padding(2);
            this.lwTyontekijanVuorot.Name = "lwTyontekijanVuorot";
            this.lwTyontekijanVuorot.Size = new System.Drawing.Size(605, 724);
            this.lwTyontekijanVuorot.TabIndex = 9;
            this.lwTyontekijanVuorot.UseCompatibleStateImageBehavior = false;
            this.lwTyontekijanVuorot.View = System.Windows.Forms.View.Details;
            // 
            // vAlkaa
            // 
            this.vAlkaa.Text = "Vuoro alkaa";
            this.vAlkaa.Width = 150;
            // 
            // vLoppuu
            // 
            this.vLoppuu.Text = "Vuoro loppuu";
            this.vLoppuu.Width = 150;
            // 
            // vTehtava
            // 
            this.vTehtava.Text = "Tehtävä";
            this.vTehtava.Width = 150;
            // 
            // vPaikka
            // 
            this.vPaikka.Text = "Paikka";
            this.vPaikka.Width = 150;
            // 
            // btnTyontekijanLista
            // 
            this.btnTyontekijanLista.BackColor = System.Drawing.Color.Gray;
            this.btnTyontekijanLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyontekijanLista.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyontekijanLista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTyontekijanLista.Location = new System.Drawing.Point(14, 173);
            this.btnTyontekijanLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnTyontekijanLista.Name = "btnTyontekijanLista";
            this.btnTyontekijanLista.Size = new System.Drawing.Size(120, 37);
            this.btnTyontekijanLista.TabIndex = 8;
            this.btnTyontekijanLista.Text = "Hae";
            this.btnTyontekijanLista.UseVisualStyleBackColor = false;
            this.btnTyontekijanLista.Click += new System.EventHandler(this.btnTyontekijanLista_Click);
            // 
            // comboTyontekijat
            // 
            this.comboTyontekijat.BackColor = System.Drawing.Color.White;
            this.comboTyontekijat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTyontekijat.ForeColor = System.Drawing.Color.Black;
            this.comboTyontekijat.FormattingEnabled = true;
            this.comboTyontekijat.Location = new System.Drawing.Point(105, 42);
            this.comboTyontekijat.Margin = new System.Windows.Forms.Padding(2);
            this.comboTyontekijat.Name = "comboTyontekijat";
            this.comboTyontekijat.Size = new System.Drawing.Size(350, 28);
            this.comboTyontekijat.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(255, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "-";
            // 
            // dtpLoppupvm
            // 
            this.dtpLoppupvm.Location = new System.Drawing.Point(277, 111);
            this.dtpLoppupvm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpLoppupvm.Name = "dtpLoppupvm";
            this.dtpLoppupvm.Size = new System.Drawing.Size(237, 26);
            this.dtpLoppupvm.TabIndex = 4;
            // 
            // dtpAlkupvm
            // 
            this.dtpAlkupvm.Location = new System.Drawing.Point(14, 112);
            this.dtpAlkupvm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpAlkupvm.Name = "dtpAlkupvm";
            this.dtpAlkupvm.Size = new System.Drawing.Size(237, 26);
            this.dtpAlkupvm.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Valitse päivämäärät";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Työntekijä";
            // 
            // tabKiinnitys
            // 
            this.tabKiinnitys.BackColor = System.Drawing.Color.DimGray;
            this.tabKiinnitys.Controls.Add(this.groupBox4);
            this.tabKiinnitys.Controls.Add(this.groupBox2);
            this.tabKiinnitys.Controls.Add(this.groupBox1);
            this.tabKiinnitys.Location = new System.Drawing.Point(4, 29);
            this.tabKiinnitys.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabKiinnitys.Name = "tabKiinnitys";
            this.tabKiinnitys.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabKiinnitys.Size = new System.Drawing.Size(1896, 1008);
            this.tabKiinnitys.TabIndex = 4;
            this.tabKiinnitys.Text = "Työntekijöiden kiinnitys";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.lwKiinnitykset);
            this.groupBox4.Controls.Add(this.btnPoistaKiinnitys);
            this.groupBox4.Controls.Add(this.btn_Kiinnita);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(831, 545);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Size = new System.Drawing.Size(708, 457);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kiinnitykset";
            // 
            // lwKiinnitykset
            // 
            this.lwKiinnitykset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwKiinnitykset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vuoroID,
            this.TehtavaID,
            this.tyontekijaID,
            this.Etunimi,
            this.Sukunimi,
            this.Nimike});
            this.lwKiinnitykset.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwKiinnitykset.FullRowSelect = true;
            this.lwKiinnitykset.HideSelection = false;
            this.lwKiinnitykset.Location = new System.Drawing.Point(4, 33);
            this.lwKiinnitykset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lwKiinnitykset.Name = "lwKiinnitykset";
            this.lwKiinnitykset.Size = new System.Drawing.Size(687, 337);
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
            this.Etunimi.Width = 120;
            // 
            // Sukunimi
            // 
            this.Sukunimi.Text = "Sukunimi";
            this.Sukunimi.Width = 120;
            // 
            // Nimike
            // 
            this.Nimike.Text = "Nimike";
            this.Nimike.Width = 150;
            // 
            // btnPoistaKiinnitys
            // 
            this.btnPoistaKiinnitys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaKiinnitys.BackColor = System.Drawing.Color.Gray;
            this.btnPoistaKiinnitys.Enabled = false;
            this.btnPoistaKiinnitys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoistaKiinnitys.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaKiinnitys.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoistaKiinnitys.Location = new System.Drawing.Point(139, 386);
            this.btnPoistaKiinnitys.Margin = new System.Windows.Forms.Padding(0);
            this.btnPoistaKiinnitys.Name = "btnPoistaKiinnitys";
            this.btnPoistaKiinnitys.Size = new System.Drawing.Size(124, 44);
            this.btnPoistaKiinnitys.TabIndex = 4;
            this.btnPoistaKiinnitys.Text = "Poista";
            this.btnPoistaKiinnitys.UseVisualStyleBackColor = false;
            this.btnPoistaKiinnitys.Click += new System.EventHandler(this.btnPoistaKiinnitys_Click);
            // 
            // btn_Kiinnita
            // 
            this.btn_Kiinnita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Kiinnita.BackColor = System.Drawing.Color.Gray;
            this.btn_Kiinnita.Enabled = false;
            this.btn_Kiinnita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kiinnita.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kiinnita.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Kiinnita.Location = new System.Drawing.Point(4, 386);
            this.btn_Kiinnita.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Kiinnita.Name = "btn_Kiinnita";
            this.btn_Kiinnita.Size = new System.Drawing.Size(124, 44);
            this.btn_Kiinnita.TabIndex = 3;
            this.btn_Kiinnita.Text = "Kiinnitä";
            this.btn_Kiinnita.UseVisualStyleBackColor = false;
            this.btn_Kiinnita.Click += new System.EventHandler(this.btn_Kiinnita_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.tb_tyontekijavalittu);
            this.groupBox2.Controls.Add(this.btn_PeruutaTyontekija);
            this.groupBox2.Controls.Add(this.lwVapaatHenkilot);
            this.groupBox2.Controls.Add(this.btn_ValitseTyontekija);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(831, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(708, 538);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vapaat henkilöt";
            // 
            // tb_tyontekijavalittu
            // 
            this.tb_tyontekijavalittu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_tyontekijavalittu.BackColor = System.Drawing.Color.DimGray;
            this.tb_tyontekijavalittu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_tyontekijavalittu.ForeColor = System.Drawing.Color.White;
            this.tb_tyontekijavalittu.Location = new System.Drawing.Point(4, 512);
            this.tb_tyontekijavalittu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tb_tyontekijavalittu.Name = "tb_tyontekijavalittu";
            this.tb_tyontekijavalittu.Size = new System.Drawing.Size(132, 19);
            this.tb_tyontekijavalittu.TabIndex = 10;
            // 
            // btn_PeruutaTyontekija
            // 
            this.btn_PeruutaTyontekija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_PeruutaTyontekija.BackColor = System.Drawing.Color.Gray;
            this.btn_PeruutaTyontekija.Enabled = false;
            this.btn_PeruutaTyontekija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PeruutaTyontekija.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PeruutaTyontekija.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_PeruutaTyontekija.Location = new System.Drawing.Point(139, 465);
            this.btn_PeruutaTyontekija.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PeruutaTyontekija.Name = "btn_PeruutaTyontekija";
            this.btn_PeruutaTyontekija.Size = new System.Drawing.Size(124, 44);
            this.btn_PeruutaTyontekija.TabIndex = 8;
            this.btn_PeruutaTyontekija.Text = "Peruuta";
            this.btn_PeruutaTyontekija.UseVisualStyleBackColor = false;
            this.btn_PeruutaTyontekija.Click += new System.EventHandler(this.btn_PeruutaTyontekija_Click);
            // 
            // lwVapaatHenkilot
            // 
            this.lwVapaatHenkilot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwVapaatHenkilot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lw_henkiloID,
            this.lw_HenkiloEtunimi,
            this.lv_HenkiloSukunimi,
            this.lw_HenkiloNimike});
            this.lwVapaatHenkilot.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwVapaatHenkilot.FullRowSelect = true;
            this.lwVapaatHenkilot.HideSelection = false;
            this.lwVapaatHenkilot.Location = new System.Drawing.Point(4, 30);
            this.lwVapaatHenkilot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lwVapaatHenkilot.Name = "lwVapaatHenkilot";
            this.lwVapaatHenkilot.Size = new System.Drawing.Size(687, 423);
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
            // btn_ValitseTyontekija
            // 
            this.btn_ValitseTyontekija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ValitseTyontekija.BackColor = System.Drawing.Color.Gray;
            this.btn_ValitseTyontekija.Enabled = false;
            this.btn_ValitseTyontekija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ValitseTyontekija.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValitseTyontekija.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ValitseTyontekija.Location = new System.Drawing.Point(4, 465);
            this.btn_ValitseTyontekija.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ValitseTyontekija.Name = "btn_ValitseTyontekija";
            this.btn_ValitseTyontekija.Size = new System.Drawing.Size(124, 44);
            this.btn_ValitseTyontekija.TabIndex = 5;
            this.btn_ValitseTyontekija.Text = "Valitse Työntekijä";
            this.btn_ValitseTyontekija.UseVisualStyleBackColor = false;
            this.btn_ValitseTyontekija.Click += new System.EventHandler(this.btn_ValitseTyontekija_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tb_vuorovalittu);
            this.groupBox1.Controls.Add(this.lwVuorot);
            this.groupBox1.Controls.Add(this.btn_PeruutaVuoro);
            this.groupBox1.Controls.Add(this.btn_ValitseVuoro);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(822, 997);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vuorot";
            // 
            // tb_vuorovalittu
            // 
            this.tb_vuorovalittu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_vuorovalittu.BackColor = System.Drawing.Color.DimGray;
            this.tb_vuorovalittu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_vuorovalittu.ForeColor = System.Drawing.Color.White;
            this.tb_vuorovalittu.Location = new System.Drawing.Point(4, 973);
            this.tb_vuorovalittu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tb_vuorovalittu.Name = "tb_vuorovalittu";
            this.tb_vuorovalittu.Size = new System.Drawing.Size(132, 19);
            this.tb_vuorovalittu.TabIndex = 9;
            // 
            // lwVuorot
            // 
            this.lwVuorot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lwVuorot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lw_tyovuoroID,
            this.lw_Aloitus,
            this.lw_Lopetus,
            this.lw_Tehtava,
            this.lw_Paikka,
            this.lw_Nimike,
            this.lw_Maara,
            this.lw_Valittu});
            this.lwVuorot.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwVuorot.FullRowSelect = true;
            this.lwVuorot.HideSelection = false;
            this.lwVuorot.Location = new System.Drawing.Point(4, 30);
            this.lwVuorot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lwVuorot.Name = "lwVuorot";
            this.lwVuorot.Size = new System.Drawing.Size(801, 881);
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
            // btn_PeruutaVuoro
            // 
            this.btn_PeruutaVuoro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_PeruutaVuoro.BackColor = System.Drawing.Color.Gray;
            this.btn_PeruutaVuoro.Enabled = false;
            this.btn_PeruutaVuoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PeruutaVuoro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PeruutaVuoro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_PeruutaVuoro.Location = new System.Drawing.Point(140, 926);
            this.btn_PeruutaVuoro.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PeruutaVuoro.Name = "btn_PeruutaVuoro";
            this.btn_PeruutaVuoro.Size = new System.Drawing.Size(124, 44);
            this.btn_PeruutaVuoro.TabIndex = 7;
            this.btn_PeruutaVuoro.Text = "Peruuta";
            this.btn_PeruutaVuoro.UseVisualStyleBackColor = false;
            this.btn_PeruutaVuoro.Click += new System.EventHandler(this.btn_PeruutaVuoro_Click);
            // 
            // btn_ValitseVuoro
            // 
            this.btn_ValitseVuoro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ValitseVuoro.BackColor = System.Drawing.Color.Gray;
            this.btn_ValitseVuoro.Enabled = false;
            this.btn_ValitseVuoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ValitseVuoro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValitseVuoro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ValitseVuoro.Location = new System.Drawing.Point(4, 926);
            this.btn_ValitseVuoro.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ValitseVuoro.Name = "btn_ValitseVuoro";
            this.btn_ValitseVuoro.Size = new System.Drawing.Size(124, 44);
            this.btn_ValitseVuoro.TabIndex = 6;
            this.btn_ValitseVuoro.Text = "Valitse vuoro";
            this.btn_ValitseVuoro.UseVisualStyleBackColor = false;
            this.btn_ValitseVuoro.Click += new System.EventHandler(this.btn_ValitseVuoro_Click);
            // 
            // tabVuorot
            // 
            this.tabVuorot.Controls.Add(this.panel2);
            this.tabVuorot.Location = new System.Drawing.Point(4, 29);
            this.tabVuorot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabVuorot.Name = "tabVuorot";
            this.tabVuorot.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabVuorot.Size = new System.Drawing.Size(1896, 1008);
            this.tabVuorot.TabIndex = 1;
            this.tabVuorot.Text = "Työvuorojen hallinta";
            this.tabVuorot.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Controls.Add(this.groupBox9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1890, 1000);
            this.panel2.TabIndex = 0;
            // 
            // lblVuoroId
            // 
            this.lblVuoroId.AutoSize = true;
            this.lblVuoroId.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuoroId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVuoroId.Location = new System.Drawing.Point(28, 57);
            this.lblVuoroId.Name = "lblVuoroId";
            this.lblVuoroId.Size = new System.Drawing.Size(43, 16);
            this.lblVuoroId.TabIndex = 42;
            this.lblVuoroId.Text = "VuoroID";
            // 
            // lblTehtavaID
            // 
            this.lblTehtavaID.AutoSize = true;
            this.lblTehtavaID.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTehtavaID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTehtavaID.Location = new System.Drawing.Point(28, 112);
            this.lblTehtavaID.Name = "lblTehtavaID";
            this.lblTehtavaID.Size = new System.Drawing.Size(51, 16);
            this.lblTehtavaID.TabIndex = 41;
            this.lblTehtavaID.Text = "TehtavaID";
            // 
            // listviewTyoVuorot
            // 
            this.listviewTyoVuorot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listviewTyoVuorot.BackColor = System.Drawing.Color.White;
            this.listviewTyoVuorot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Alkaa,
            this.Loppuu});
            this.listviewTyoVuorot.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewTyoVuorot.FullRowSelect = true;
            this.listviewTyoVuorot.HideSelection = false;
            this.listviewTyoVuorot.Location = new System.Drawing.Point(19, 217);
            this.listviewTyoVuorot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listviewTyoVuorot.Name = "listviewTyoVuorot";
            this.listviewTyoVuorot.Size = new System.Drawing.Size(427, 769);
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
            this.tbTyovuoroValinta.Location = new System.Drawing.Point(150, 30);
            this.tbTyovuoroValinta.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbTyovuoroValinta.Name = "tbTyovuoroValinta";
            this.tbTyovuoroValinta.Size = new System.Drawing.Size(250, 26);
            this.tbTyovuoroValinta.TabIndex = 38;
            this.tbTyovuoroValinta.Text = "Valitse vuoro työvuorolistalta";
            // 
            // comboTehtavat
            // 
            this.comboTehtavat.DisplayMember = "1";
            this.comboTehtavat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTehtavat.FormattingEnabled = true;
            this.comboTehtavat.Location = new System.Drawing.Point(150, 83);
            this.comboTehtavat.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboTehtavat.Name = "comboTehtavat";
            this.comboTehtavat.Size = new System.Drawing.Size(250, 28);
            this.comboTehtavat.TabIndex = 37;
            this.comboTehtavat.SelectedIndexChanged += new System.EventHandler(this.comboTehtavat_SelectedIndexChanged);
            // 
            // numMaara
            // 
            this.numMaara.Location = new System.Drawing.Point(150, 138);
            this.numMaara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMaara.Name = "numMaara";
            this.numMaara.Size = new System.Drawing.Size(63, 26);
            this.numMaara.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(27, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Määrä";
            // 
            // comboLoppuu
            // 
            this.comboLoppuu.FormattingEnabled = true;
            this.comboLoppuu.Items.AddRange(new object[] {
            "06:00",
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
            this.comboLoppuu.Location = new System.Drawing.Point(128, 155);
            this.comboLoppuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboLoppuu.Name = "comboLoppuu";
            this.comboLoppuu.Size = new System.Drawing.Size(66, 28);
            this.comboLoppuu.TabIndex = 21;
            // 
            // comboAlkaa
            // 
            this.comboAlkaa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlkaa.FormattingEnabled = true;
            this.comboAlkaa.Items.AddRange(new object[] {
            "06:00",
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
            this.comboAlkaa.Location = new System.Drawing.Point(128, 70);
            this.comboAlkaa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboAlkaa.Name = "comboAlkaa";
            this.comboAlkaa.Size = new System.Drawing.Size(66, 28);
            this.comboAlkaa.TabIndex = 21;
            // 
            // btnPoistaTarve
            // 
            this.btnPoistaTarve.BackColor = System.Drawing.Color.Gray;
            this.btnPoistaTarve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoistaTarve.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaTarve.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoistaTarve.Location = new System.Drawing.Point(420, 77);
            this.btnPoistaTarve.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPoistaTarve.Name = "btnPoistaTarve";
            this.btnPoistaTarve.Size = new System.Drawing.Size(73, 34);
            this.btnPoistaTarve.TabIndex = 18;
            this.btnPoistaTarve.Text = "Poista";
            this.btnPoistaTarve.UseVisualStyleBackColor = false;
            this.btnPoistaTarve.Click += new System.EventHandler(this.btnPoistaTarve_Click);
            // 
            // btnPoistaVuoro
            // 
            this.btnPoistaVuoro.BackColor = System.Drawing.Color.Gray;
            this.btnPoistaVuoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoistaVuoro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaVuoro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoistaVuoro.Location = new System.Drawing.Point(373, 77);
            this.btnPoistaVuoro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPoistaVuoro.Name = "btnPoistaVuoro";
            this.btnPoistaVuoro.Size = new System.Drawing.Size(73, 34);
            this.btnPoistaVuoro.TabIndex = 18;
            this.btnPoistaVuoro.Text = "Poista";
            this.btnPoistaVuoro.UseVisualStyleBackColor = false;
            this.btnPoistaVuoro.Click += new System.EventHandler(this.btnPoistaVuoro_Click);
            // 
            // btnTallennaTarve
            // 
            this.btnTallennaTarve.BackColor = System.Drawing.Color.Gray;
            this.btnTallennaTarve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTallennaTarve.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallennaTarve.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTallennaTarve.Location = new System.Drawing.Point(420, 22);
            this.btnTallennaTarve.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTallennaTarve.Name = "btnTallennaTarve";
            this.btnTallennaTarve.Size = new System.Drawing.Size(73, 34);
            this.btnTallennaTarve.TabIndex = 17;
            this.btnTallennaTarve.Text = "Tallenna";
            this.btnTallennaTarve.UseVisualStyleBackColor = false;
            this.btnTallennaTarve.Click += new System.EventHandler(this.btnTallennaTarve_Click);
            // 
            // btnTallennaVuoro
            // 
            this.btnTallennaVuoro.BackColor = System.Drawing.Color.Gray;
            this.btnTallennaVuoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTallennaVuoro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallennaVuoro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTallennaVuoro.Location = new System.Drawing.Point(373, 33);
            this.btnTallennaVuoro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTallennaVuoro.Name = "btnTallennaVuoro";
            this.btnTallennaVuoro.Size = new System.Drawing.Size(73, 34);
            this.btnTallennaVuoro.TabIndex = 17;
            this.btnTallennaVuoro.Text = "Tallenna";
            this.btnTallennaVuoro.UseVisualStyleBackColor = false;
            this.btnTallennaVuoro.Click += new System.EventHandler(this.btnTallennaVuoro_Click);
            // 
            // dgvTarpeet
            // 
            this.dgvTarpeet.AllowUserToAddRows = false;
            this.dgvTarpeet.AllowUserToDeleteRows = false;
            this.dgvTarpeet.AllowUserToOrderColumns = true;
            this.dgvTarpeet.AllowUserToResizeRows = false;
            this.dgvTarpeet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTarpeet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarpeet.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarpeet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTarpeet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarpeet.Location = new System.Drawing.Point(31, 217);
            this.dgvTarpeet.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvTarpeet.Name = "dgvTarpeet";
            this.dgvTarpeet.ReadOnly = true;
            this.dgvTarpeet.RowHeadersWidth = 60;
            this.dgvTarpeet.RowTemplate.Height = 24;
            this.dgvTarpeet.Size = new System.Drawing.Size(998, 770);
            this.dgvTarpeet.TabIndex = 13;
            // 
            // dtpPvmLoppuu
            // 
            this.dtpPvmLoppuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPvmLoppuu.Location = new System.Drawing.Point(128, 117);
            this.dtpPvmLoppuu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpPvmLoppuu.Name = "dtpPvmLoppuu";
            this.dtpPvmLoppuu.Size = new System.Drawing.Size(202, 23);
            this.dtpPvmLoppuu.TabIndex = 4;
            // 
            // dtpPvmAlkaa
            // 
            this.dtpPvmAlkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPvmAlkaa.Location = new System.Drawing.Point(128, 33);
            this.dtpPvmAlkaa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpPvmAlkaa.Name = "dtpPvmAlkaa";
            this.dtpPvmAlkaa.Size = new System.Drawing.Size(202, 23);
            this.dtpPvmAlkaa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loppuu";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label23.Location = new System.Drawing.Point(26, 91);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 20);
            this.label23.TabIndex = 2;
            this.label23.Text = "Tehtävä";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label22.Location = new System.Drawing.Point(26, 36);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 20);
            this.label22.TabIndex = 2;
            this.label22.Text = "Työvuoro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alkaa";
            // 
            // tabEtusivu
            // 
            this.tabEtusivu.Controls.Add(this.panel7);
            this.tabEtusivu.Controls.Add(this.panel6);
            this.tabEtusivu.Location = new System.Drawing.Point(4, 29);
            this.tabEtusivu.Margin = new System.Windows.Forms.Padding(2);
            this.tabEtusivu.Name = "tabEtusivu";
            this.tabEtusivu.Size = new System.Drawing.Size(1896, 1008);
            this.tabEtusivu.TabIndex = 6;
            this.tabEtusivu.Text = "Etusivu";
            this.tabEtusivu.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Controls.Add(this.btnTyotehtavat);
            this.panel7.Controls.Add(this.btnVapaatLista);
            this.panel7.Controls.Add(this.btnTyovuorolistat);
            this.panel7.Controls.Add(this.btnTtVuorolista);
            this.panel7.Controls.Add(this.btnTyovuorot);
            this.panel7.Controls.Add(this.btnKiinnitykset);
            this.panel7.Controls.Add(this.btnTyontekijat);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 156);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1896, 852);
            this.panel7.TabIndex = 3;
            // 
            // btnTyotehtavat
            // 
            this.btnTyotehtavat.BackColor = System.Drawing.Color.Gray;
            this.btnTyotehtavat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyotehtavat.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyotehtavat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTyotehtavat.Location = new System.Drawing.Point(961, 12);
            this.btnTyotehtavat.Margin = new System.Windows.Forms.Padding(2);
            this.btnTyotehtavat.Name = "btnTyotehtavat";
            this.btnTyotehtavat.Size = new System.Drawing.Size(267, 80);
            this.btnTyotehtavat.TabIndex = 5;
            this.btnTyotehtavat.Text = "Työtehtävien hallinta";
            this.btnTyotehtavat.UseVisualStyleBackColor = false;
            this.btnTyotehtavat.Click += new System.EventHandler(this.btnTyotehtavat_Click);
            // 
            // btnVapaatLista
            // 
            this.btnVapaatLista.BackColor = System.Drawing.Color.Gray;
            this.btnVapaatLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVapaatLista.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVapaatLista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVapaatLista.Location = new System.Drawing.Point(652, 116);
            this.btnVapaatLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnVapaatLista.Name = "btnVapaatLista";
            this.btnVapaatLista.Size = new System.Drawing.Size(267, 80);
            this.btnVapaatLista.TabIndex = 4;
            this.btnVapaatLista.Text = "Vapaalista";
            this.btnVapaatLista.UseVisualStyleBackColor = false;
            this.btnVapaatLista.Click += new System.EventHandler(this.btnVapaatLista_Click);
            // 
            // btnTyovuorolistat
            // 
            this.btnTyovuorolistat.BackColor = System.Drawing.Color.Gray;
            this.btnTyovuorolistat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyovuorolistat.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyovuorolistat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTyovuorolistat.Location = new System.Drawing.Point(343, 116);
            this.btnTyovuorolistat.Margin = new System.Windows.Forms.Padding(2);
            this.btnTyovuorolistat.Name = "btnTyovuorolistat";
            this.btnTyovuorolistat.Size = new System.Drawing.Size(267, 80);
            this.btnTyovuorolistat.TabIndex = 4;
            this.btnTyovuorolistat.Text = "Työvuorolista";
            this.btnTyovuorolistat.UseVisualStyleBackColor = false;
            this.btnTyovuorolistat.Click += new System.EventHandler(this.btnTyovuorolistat_Click);
            // 
            // btnTtVuorolista
            // 
            this.btnTtVuorolista.BackColor = System.Drawing.Color.Gray;
            this.btnTtVuorolista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTtVuorolista.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTtVuorolista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTtVuorolista.Location = new System.Drawing.Point(37, 116);
            this.btnTtVuorolista.Margin = new System.Windows.Forms.Padding(2);
            this.btnTtVuorolista.Name = "btnTtVuorolista";
            this.btnTtVuorolista.Size = new System.Drawing.Size(267, 80);
            this.btnTtVuorolista.TabIndex = 3;
            this.btnTtVuorolista.Text = "Työntekijän vuorolista";
            this.btnTtVuorolista.UseVisualStyleBackColor = false;
            this.btnTtVuorolista.Click += new System.EventHandler(this.btnTtVuorolista_Click);
            // 
            // btnTyovuorot
            // 
            this.btnTyovuorot.BackColor = System.Drawing.Color.Gray;
            this.btnTyovuorot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyovuorot.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyovuorot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTyovuorot.Location = new System.Drawing.Point(37, 12);
            this.btnTyovuorot.Margin = new System.Windows.Forms.Padding(2);
            this.btnTyovuorot.Name = "btnTyovuorot";
            this.btnTyovuorot.Size = new System.Drawing.Size(267, 80);
            this.btnTyovuorot.TabIndex = 2;
            this.btnTyovuorot.Text = "Työvuorojen hallinta";
            this.btnTyovuorot.UseVisualStyleBackColor = false;
            this.btnTyovuorot.Click += new System.EventHandler(this.btnTyovuorot_Click);
            // 
            // btnKiinnitykset
            // 
            this.btnKiinnitykset.BackColor = System.Drawing.Color.Gray;
            this.btnKiinnitykset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiinnitykset.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiinnitykset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKiinnitykset.Location = new System.Drawing.Point(343, 12);
            this.btnKiinnitykset.Margin = new System.Windows.Forms.Padding(2);
            this.btnKiinnitykset.Name = "btnKiinnitykset";
            this.btnKiinnitykset.Size = new System.Drawing.Size(267, 80);
            this.btnKiinnitykset.TabIndex = 1;
            this.btnKiinnitykset.Text = "Työntekijöiden kiinnitys";
            this.btnKiinnitykset.UseVisualStyleBackColor = false;
            this.btnKiinnitykset.Click += new System.EventHandler(this.btnKiinnitykset_Click);
            // 
            // btnTyontekijat
            // 
            this.btnTyontekijat.BackColor = System.Drawing.Color.Gray;
            this.btnTyontekijat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyontekijat.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyontekijat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTyontekijat.Location = new System.Drawing.Point(652, 12);
            this.btnTyontekijat.Margin = new System.Windows.Forms.Padding(2);
            this.btnTyontekijat.Name = "btnTyontekijat";
            this.btnTyontekijat.Size = new System.Drawing.Size(267, 80);
            this.btnTyontekijat.TabIndex = 0;
            this.btnTyontekijat.Text = "Työntekijöiden hallinta";
            this.btnTyontekijat.UseVisualStyleBackColor = false;
            this.btnTyontekijat.Click += new System.EventHandler(this.btnTyontekijat_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label24);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1896, 156);
            this.panel6.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Britannic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label24.Location = new System.Drawing.Point(29, 49);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(256, 44);
            this.label24.TabIndex = 1;
            this.label24.Text = "SairaalaSofta";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEtusivu);
            this.tabControl.Controls.Add(this.tabVuorot);
            this.tabControl.Controls.Add(this.tabKiinnitys);
            this.tabControl.Controls.Add(this.tabTyöntekijänVuorot);
            this.tabControl.Controls.Add(this.tabTyövuorolista);
            this.tabControl.Controls.Add(this.tabVapaalista);
            this.tabControl.Controls.Add(this.tabTyöntekijät);
            this.tabControl.Controls.Add(this.tabTehtävät);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(55, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1904, 1041);
            this.tabControl.TabIndex = 0;
            // 
            // tyontekijatdgv
            // 
            this.tyontekijatdgv.AllowUserToAddRows = false;
            this.tyontekijatdgv.AllowUserToDeleteRows = false;
            this.tyontekijatdgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tyontekijatdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tyontekijatdgv.BackgroundColor = System.Drawing.Color.White;
            this.tyontekijatdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tyontekijatdgv.Location = new System.Drawing.Point(4, 222);
            this.tyontekijatdgv.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tyontekijatdgv.MultiSelect = false;
            this.tyontekijatdgv.Name = "tyontekijatdgv";
            this.tyontekijatdgv.ReadOnly = true;
            this.tyontekijatdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tyontekijatdgv.RowTemplate.Height = 24;
            this.tyontekijatdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tyontekijatdgv.Size = new System.Drawing.Size(984, 766);
            this.tyontekijatdgv.TabIndex = 7;
            // 
            // lvNimikkeet
            // 
            this.lvNimikkeet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvNimikkeet.BackColor = System.Drawing.Color.White;
            this.lvNimikkeet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdNimike,
            this.Työnimike});
            this.lvNimikkeet.FullRowSelect = true;
            this.lvNimikkeet.HideSelection = false;
            this.lvNimikkeet.Location = new System.Drawing.Point(6, 222);
            this.lvNimikkeet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvNimikkeet.Name = "lvNimikkeet";
            this.lvNimikkeet.Size = new System.Drawing.Size(305, 766);
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.lblidnimike);
            this.groupBox3.Controls.Add(this.dgvTehtavat);
            this.groupBox3.Controls.Add(this.comboNimike);
            this.groupBox3.Controls.Add(this.btnTallenna);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbTehtava);
            this.groupBox3.Controls.Add(this.comboPaikka);
            this.groupBox3.Controls.Add(this.btnMuokkaa);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnPoista);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 994);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lisää työtehtävä";
            // 
            // btnTallenna
            // 
            this.btnTallenna.BackColor = System.Drawing.Color.Gray;
            this.btnTallenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTallenna.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTallenna.Location = new System.Drawing.Point(23, 180);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(135, 39);
            this.btnTallenna.TabIndex = 29;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = false;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // tbTehtava
            // 
            this.tbTehtava.BackColor = System.Drawing.Color.White;
            this.tbTehtava.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTehtava.ForeColor = System.Drawing.Color.Black;
            this.tbTehtava.Location = new System.Drawing.Point(119, 39);
            this.tbTehtava.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbTehtava.Name = "tbTehtava";
            this.tbTehtava.Size = new System.Drawing.Size(202, 26);
            this.tbTehtava.TabIndex = 28;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.BackColor = System.Drawing.Color.Gray;
            this.btnMuokkaa.Enabled = false;
            this.btnMuokkaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuokkaa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMuokkaa.Location = new System.Drawing.Point(23, 238);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(300, 39);
            this.btnMuokkaa.TabIndex = 31;
            this.btnMuokkaa.Text = "Tallenna muutokset";
            this.btnMuokkaa.UseVisualStyleBackColor = false;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(17, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tehtävä";
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.Color.Gray;
            this.btnPoista.Enabled = false;
            this.btnPoista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoista.Location = new System.Drawing.Point(187, 180);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(135, 39);
            this.btnPoista.TabIndex = 30;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = false;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(19, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nimike";
            // 
            // comboPaikka
            // 
            this.comboPaikka.BackColor = System.Drawing.Color.White;
            this.comboPaikka.DisplayMember = "1";
            this.comboPaikka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaikka.ForeColor = System.Drawing.Color.Black;
            this.comboPaikka.FormattingEnabled = true;
            this.comboPaikka.Items.AddRange(new object[] {
            "Osasto A",
            "Osasto B"});
            this.comboPaikka.Location = new System.Drawing.Point(119, 74);
            this.comboPaikka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboPaikka.Name = "comboPaikka";
            this.comboPaikka.Size = new System.Drawing.Size(201, 28);
            this.comboPaikka.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(19, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Paikka";
            // 
            // comboNimike
            // 
            this.comboNimike.BackColor = System.Drawing.Color.White;
            this.comboNimike.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNimike.FormattingEnabled = true;
            this.comboNimike.Location = new System.Drawing.Point(119, 111);
            this.comboNimike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboNimike.Name = "comboNimike";
            this.comboNimike.Size = new System.Drawing.Size(202, 28);
            this.comboNimike.TabIndex = 32;
            this.comboNimike.SelectedIndexChanged += new System.EventHandler(this.comboNimike_SelectedIndexChanged);
            // 
            // lblidnimike
            // 
            this.lblidnimike.AutoSize = true;
            this.lblidnimike.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidnimike.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblidnimike.Location = new System.Drawing.Point(19, 139);
            this.lblidnimike.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidnimike.Name = "lblidnimike";
            this.lblidnimike.Size = new System.Drawing.Size(50, 16);
            this.lblidnimike.TabIndex = 36;
            this.lblidnimike.Text = "NimikeID";
            this.lblidnimike.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.btnTyontekijanLista);
            this.groupBox7.Controls.Add(this.lwTyontekijanVuorot);
            this.groupBox7.Controls.Add(this.comboTyontekijat);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.dtpLoppupvm);
            this.groupBox7.Controls.Add(this.dtpAlkupvm);
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(8, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(637, 993);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Työntekijän vuorolista";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.dtpPvmAlkaa);
            this.groupBox8.Controls.Add(this.listviewTyoVuorot);
            this.groupBox8.Controls.Add(this.comboAlkaa);
            this.groupBox8.Controls.Add(this.btnTallennaVuoro);
            this.groupBox8.Controls.Add(this.btnPoistaVuoro);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.dtpPvmLoppuu);
            this.groupBox8.Controls.Add(this.comboLoppuu);
            this.groupBox8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(5, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(468, 993);
            this.groupBox8.TabIndex = 43;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Lisää työvuoro";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.dgvTarpeet);
            this.groupBox9.Controls.Add(this.btnPoistaTarve);
            this.groupBox9.Controls.Add(this.tbTyovuoroValinta);
            this.groupBox9.Controls.Add(this.btnTallennaTarve);
            this.groupBox9.Controls.Add(this.comboTehtavat);
            this.groupBox9.Controls.Add(this.lblVuoroId);
            this.groupBox9.Controls.Add(this.numMaara);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.lblTehtavaID);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Black;
            this.groupBox9.Location = new System.Drawing.Point(479, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1048, 994);
            this.groupBox9.TabIndex = 44;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Lisää tarve";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Päivämäärä";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Etunimi";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sukunimi";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Puhelinnumero";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nimike";
            this.columnHeader5.Width = 150;
            // 
            // lwVapaalista
            // 
            this.lwVapaalista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lwVapaalista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lwVapaalista.ForeColor = System.Drawing.Color.Black;
            this.lwVapaalista.HideSelection = false;
            this.lwVapaalista.Location = new System.Drawing.Point(22, 191);
            this.lwVapaalista.Margin = new System.Windows.Forms.Padding(2);
            this.lwVapaalista.Name = "lwVapaalista";
            this.lwVapaalista.Size = new System.Drawing.Size(1025, 791);
            this.lwVapaalista.TabIndex = 1;
            this.lwVapaalista.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.lwVapaalista);
            this.groupBox10.Controls.Add(this.dtpVapaaAlkaa);
            this.groupBox10.Controls.Add(this.btnVapaalista);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.dtpVapaaLoppuu);
            this.groupBox10.ForeColor = System.Drawing.Color.Black;
            this.groupBox10.Location = new System.Drawing.Point(8, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1065, 997);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Vapaalista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox11.Controls.Add(this.lvVuorolista);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.btnHaeTyovuorolista);
            this.groupBox11.Controls.Add(this.dtpVuorolistaAlkaa);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.dtpVuorolistaLoppuu);
            this.groupBox11.ForeColor = System.Drawing.Color.Black;
            this.groupBox11.Location = new System.Drawing.Point(8, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(995, 998);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Työvuorolista";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1278, 678);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Työvuorosuunnittelu";
            this.tabVapaalista.ResumeLayout(false);
            this.tabTehtävät.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTehtavat)).EndInit();
            this.tabTyöntekijät.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabTyövuorolista.ResumeLayout(false);
            this.tabTyöntekijänVuorot.ResumeLayout(false);
            this.tabKiinnitys.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabVuorot.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMaara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarpeet)).EndInit();
            this.tabEtusivu.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tyontekijatdgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabVapaalista;
        private System.Windows.Forms.Button btnVapaalista;
        private System.Windows.Forms.DateTimePicker dtpVapaaLoppuu;
        private System.Windows.Forms.DateTimePicker dtpVapaaAlkaa;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tabTehtävät;
        private System.Windows.Forms.DataGridView dgvTehtavat;
        private System.Windows.Forms.TabPage tabTyöntekijät;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnPoistaNimike;
        private System.Windows.Forms.Button btnLisaaNimike;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbTyonimike;
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
        private System.Windows.Forms.Button tyhjennabtn;
        private System.Windows.Forms.Button lisaabtn;
        private System.Windows.Forms.Button poistabtn;
        private System.Windows.Forms.Button muokkaabtn;
        private System.Windows.Forms.TabPage tabTyövuorolista;
        private System.Windows.Forms.Button btnHaeTyovuorolista;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpVuorolistaLoppuu;
        private System.Windows.Forms.DateTimePicker dtpVuorolistaAlkaa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabTyöntekijänVuorot;
        private System.Windows.Forms.ListView lwTyontekijanVuorot;
        private System.Windows.Forms.ColumnHeader vAlkaa;
        private System.Windows.Forms.ColumnHeader vLoppuu;
        private System.Windows.Forms.ColumnHeader vTehtava;
        private System.Windows.Forms.ColumnHeader vPaikka;
        private System.Windows.Forms.Button btnTyontekijanLista;
        private System.Windows.Forms.ComboBox comboTyontekijat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpLoppupvm;
        private System.Windows.Forms.DateTimePicker dtpAlkupvm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabKiinnitys;
        private System.Windows.Forms.TextBox tb_tyontekijavalittu;
        private System.Windows.Forms.TextBox tb_vuorovalittu;
        private System.Windows.Forms.Button btn_PeruutaTyontekija;
        private System.Windows.Forms.Button btn_PeruutaVuoro;
        private System.Windows.Forms.Button btn_ValitseVuoro;
        private System.Windows.Forms.Button btn_ValitseTyontekija;
        private System.Windows.Forms.Button btnPoistaKiinnitys;
        private System.Windows.Forms.Button btn_Kiinnita;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lwKiinnitykset;
        private System.Windows.Forms.ColumnHeader vuoroID;
        private System.Windows.Forms.ColumnHeader TehtavaID;
        private System.Windows.Forms.ColumnHeader tyontekijaID;
        private System.Windows.Forms.ColumnHeader Etunimi;
        private System.Windows.Forms.ColumnHeader Sukunimi;
        private System.Windows.Forms.ColumnHeader Nimike;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lwVapaatHenkilot;
        private System.Windows.Forms.ColumnHeader lw_henkiloID;
        private System.Windows.Forms.ColumnHeader lw_HenkiloEtunimi;
        private System.Windows.Forms.ColumnHeader lv_HenkiloSukunimi;
        private System.Windows.Forms.ColumnHeader lw_HenkiloNimike;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lwVuorot;
        private System.Windows.Forms.ColumnHeader lw_tyovuoroID;
        private System.Windows.Forms.ColumnHeader lw_Aloitus;
        private System.Windows.Forms.ColumnHeader lw_Lopetus;
        private System.Windows.Forms.ColumnHeader lw_Tehtava;
        private System.Windows.Forms.ColumnHeader lw_Paikka;
        private System.Windows.Forms.ColumnHeader lw_Nimike;
        private System.Windows.Forms.ColumnHeader lw_Maara;
        private System.Windows.Forms.ColumnHeader lw_Valittu;
        private System.Windows.Forms.TabPage tabVuorot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTehtavaID;
        private System.Windows.Forms.ListView listviewTyoVuorot;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Alkaa;
        private System.Windows.Forms.ColumnHeader Loppuu;
        private System.Windows.Forms.TextBox tbTyovuoroValinta;
        private System.Windows.Forms.ComboBox comboTehtavat;
        private System.Windows.Forms.NumericUpDown numMaara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboLoppuu;
        private System.Windows.Forms.ComboBox comboAlkaa;
        private System.Windows.Forms.Button btnPoistaTarve;
        private System.Windows.Forms.Button btnPoistaVuoro;
        private System.Windows.Forms.Button btnTallennaTarve;
        private System.Windows.Forms.Button btnTallennaVuoro;
        private System.Windows.Forms.DataGridView dgvTarpeet;
        private System.Windows.Forms.DateTimePicker dtpPvmLoppuu;
        private System.Windows.Forms.DateTimePicker dtpPvmAlkaa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabEtusivu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnTyotehtavat;
        private System.Windows.Forms.Button btnTyovuorolistat;
        private System.Windows.Forms.Button btnTtVuorolista;
        private System.Windows.Forms.Button btnTyovuorot;
        private System.Windows.Forms.Button btnKiinnitykset;
        private System.Windows.Forms.Button btnTyontekijat;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnVapaatLista;
        private System.Windows.Forms.ListView lvVuorolista;
        private System.Windows.Forms.ColumnHeader Enimi;
        private System.Windows.Forms.ColumnHeader sNimi;
        private System.Windows.Forms.ColumnHeader TyövuoroAlku;
        private System.Windows.Forms.ColumnHeader TyövuoroLoppu;
        private System.Windows.Forms.ColumnHeader Tehtävä;
        private System.Windows.Forms.Label lblVuoroId;
        private System.Windows.Forms.ColumnHeader Paikka;
        private System.Windows.Forms.ColumnHeader Puhnumero;
        private System.Windows.Forms.ColumnHeader Tehtavanimike;
        private System.Windows.Forms.ListView lvNimikkeet;
        private System.Windows.Forms.ColumnHeader IdNimike;
        private System.Windows.Forms.ColumnHeader Työnimike;
        private System.Windows.Forms.DataGridView tyontekijatdgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblidnimike;
        private System.Windows.Forms.ComboBox comboNimike;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTehtava;
        private System.Windows.Forms.ComboBox comboPaikka;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lwVapaalista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox11;
    }
}

