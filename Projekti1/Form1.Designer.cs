
namespace Projekti1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblenimi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsnimi = new System.Windows.Forms.Label();
            this.lblpuh = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnlisaa = new System.Windows.Forms.Button();
            this.btntyhjenna = new System.Windows.Forms.Button();
            this.btnpoista = new System.Windows.Forms.Button();
            this.lblnimike = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Työntekijähallinta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vuorojen syöttö";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1065, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Työntekijän vuorolista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1065, 565);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vuorojen syöttö";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblenimi
            // 
            this.lblenimi.AutoSize = true;
            this.lblenimi.Location = new System.Drawing.Point(16, 16);
            this.lblenimi.Name = "lblenimi";
            this.lblenimi.Size = new System.Drawing.Size(63, 19);
            this.lblenimi.TabIndex = 0;
            this.lblenimi.Text = "Etunimi";
            this.lblenimi.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnpoista);
            this.panel1.Controls.Add(this.btntyhjenna);
            this.panel1.Controls.Add(this.btnlisaa);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblnimike);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblpuh);
            this.panel1.Controls.Add(this.lblsnimi);
            this.panel1.Controls.Add(this.lblenimi);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 429);
            this.panel1.TabIndex = 1;
            // 
            // lblsnimi
            // 
            this.lblsnimi.AutoSize = true;
            this.lblsnimi.Location = new System.Drawing.Point(16, 56);
            this.lblsnimi.Name = "lblsnimi";
            this.lblsnimi.Size = new System.Drawing.Size(75, 19);
            this.lblsnimi.TabIndex = 0;
            this.lblsnimi.Text = "Sukunimi";
            // 
            // lblpuh
            // 
            this.lblpuh.AutoSize = true;
            this.lblpuh.Location = new System.Drawing.Point(16, 97);
            this.lblpuh.Name = "lblpuh";
            this.lblpuh.Size = new System.Drawing.Size(116, 19);
            this.lblpuh.TabIndex = 0;
            this.lblpuh.Text = "Puhelinnumero";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(16, 135);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 19);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 27);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 27);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnlisaa
            // 
            this.btnlisaa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlisaa.Location = new System.Drawing.Point(20, 244);
            this.btnlisaa.Name = "btnlisaa";
            this.btnlisaa.Size = new System.Drawing.Size(78, 29);
            this.btnlisaa.TabIndex = 2;
            this.btnlisaa.Text = "Lisää";
            this.btnlisaa.UseVisualStyleBackColor = true;
            // 
            // btntyhjenna
            // 
            this.btntyhjenna.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntyhjenna.Location = new System.Drawing.Point(20, 279);
            this.btntyhjenna.Name = "btntyhjenna";
            this.btntyhjenna.Size = new System.Drawing.Size(78, 29);
            this.btntyhjenna.TabIndex = 2;
            this.btntyhjenna.Text = "Tyhjennä";
            this.btntyhjenna.UseVisualStyleBackColor = true;
            // 
            // btnpoista
            // 
            this.btnpoista.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoista.Location = new System.Drawing.Point(20, 314);
            this.btnpoista.Name = "btnpoista";
            this.btnpoista.Size = new System.Drawing.Size(78, 29);
            this.btnpoista.TabIndex = 2;
            this.btnpoista.Text = "Poista";
            this.btnpoista.UseVisualStyleBackColor = true;
            // 
            // lblnimike
            // 
            this.lblnimike.AutoSize = true;
            this.lblnimike.Location = new System.Drawing.Point(16, 178);
            this.lblnimike.Name = "lblnimike";
            this.lblnimike.Size = new System.Drawing.Size(58, 19);
            this.lblnimike.TabIndex = 0;
            this.lblnimike.Text = "Nimike";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 175);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 27);
            this.textBox5.TabIndex = 1;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 590);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Työvuorosuunnittelu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblenimi;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpuh;
        private System.Windows.Forms.Label lblsnimi;
        private System.Windows.Forms.Button btnpoista;
        private System.Windows.Forms.Button btntyhjenna;
        private System.Windows.Forms.Button btnlisaa;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblnimike;
        private System.Windows.Forms.TextBox textBox5;
    }
}

