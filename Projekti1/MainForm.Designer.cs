
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpoista = new System.Windows.Forms.Button();
            this.btntyhjenna = new System.Windows.Forms.Button();
            this.btnlisaa = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblnimike = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpuh = new System.Windows.Forms.Label();
            this.lblsnimi = new System.Windows.Forms.Label();
            this.lblenimi = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1605, 1364);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1597, 1331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Työntekijähallinta";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(15, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 660);
            this.panel1.TabIndex = 1;
            // 
            // btnpoista
            // 
            this.btnpoista.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoista.Location = new System.Drawing.Point(30, 483);
            this.btnpoista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnpoista.Name = "btnpoista";
            this.btnpoista.Size = new System.Drawing.Size(117, 45);
            this.btnpoista.TabIndex = 2;
            this.btnpoista.Text = "Poista";
            this.btnpoista.UseVisualStyleBackColor = true;
            // 
            // btntyhjenna
            // 
            this.btntyhjenna.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntyhjenna.Location = new System.Drawing.Point(30, 429);
            this.btntyhjenna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntyhjenna.Name = "btntyhjenna";
            this.btntyhjenna.Size = new System.Drawing.Size(117, 45);
            this.btntyhjenna.TabIndex = 2;
            this.btntyhjenna.Text = "Tyhjennä";
            this.btntyhjenna.UseVisualStyleBackColor = true;
            // 
            // btnlisaa
            // 
            this.btnlisaa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlisaa.Location = new System.Drawing.Point(30, 375);
            this.btnlisaa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlisaa.Name = "btnlisaa";
            this.btnlisaa.Size = new System.Drawing.Size(117, 45);
            this.btnlisaa.TabIndex = 2;
            this.btnlisaa.Text = "Lisää";
            this.btnlisaa.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(240, 269);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(304, 36);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(240, 195);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(304, 36);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(240, 137);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(304, 36);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 74);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(304, 36);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 36);
            this.textBox1.TabIndex = 1;
            // 
            // lblnimike
            // 
            this.lblnimike.AutoSize = true;
            this.lblnimike.Location = new System.Drawing.Point(24, 274);
            this.lblnimike.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnimike.Name = "lblnimike";
            this.lblnimike.Size = new System.Drawing.Size(84, 29);
            this.lblnimike.TabIndex = 0;
            this.lblnimike.Text = "Nimike";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(24, 208);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(69, 29);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email";
            // 
            // lblpuh
            // 
            this.lblpuh.AutoSize = true;
            this.lblpuh.Location = new System.Drawing.Point(24, 149);
            this.lblpuh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpuh.Name = "lblpuh";
            this.lblpuh.Size = new System.Drawing.Size(169, 29);
            this.lblpuh.TabIndex = 0;
            this.lblpuh.Text = "Puhelinnumero";
            // 
            // lblsnimi
            // 
            this.lblsnimi.AutoSize = true;
            this.lblsnimi.Location = new System.Drawing.Point(24, 86);
            this.lblsnimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsnimi.Name = "lblsnimi";
            this.lblsnimi.Size = new System.Drawing.Size(107, 29);
            this.lblsnimi.TabIndex = 0;
            this.lblsnimi.Text = "Sukunimi";
            // 
            // lblenimi
            // 
            this.lblenimi.AutoSize = true;
            this.lblenimi.Location = new System.Drawing.Point(24, 25);
            this.lblenimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblenimi.Name = "lblenimi";
            this.lblenimi.Size = new System.Drawing.Size(90, 29);
            this.lblenimi.TabIndex = 0;
            this.lblenimi.Text = "Etunimi";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1597, 1331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vuorojen syöttö";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1597, 1331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Työntekijän vuorolista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1597, 1331);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vuorojen syöttö";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 908);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainForm";
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

