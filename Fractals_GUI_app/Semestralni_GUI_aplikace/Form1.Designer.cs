
namespace Semestralni_GUI_aplikace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb1_styl = new System.Windows.Forms.GroupBox();
            this.lbl_stetec_chyba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl3_tloustka_stetce = new System.Windows.Forms.Label();
            this.tb1_tlousta_stetce = new System.Windows.Forms.TextBox();
            this.pnl4_stetec = new System.Windows.Forms.Panel();
            this.btn4_stetec = new System.Windows.Forms.Button();
            this.pnl3_pozadi = new System.Windows.Forms.Panel();
            this.btn3_pozadi = new System.Windows.Forms.Button();
            this.gb2_vyber = new System.Windows.Forms.GroupBox();
            this.lbl_chyba_tvar = new System.Windows.Forms.Label();
            this.btn1_nahled_tvaru = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl2_nahled_tvaru = new System.Windows.Forms.Label();
            this.lbl3_iterace = new System.Windows.Forms.Label();
            this.cmb1_tvar = new System.Windows.Forms.ComboBox();
            this.lbl1_vyber_tvaru = new System.Windows.Forms.Label();
            this.pnl2_nahled = new System.Windows.Forms.Panel();
            this.btn2_vykresli = new System.Windows.Forms.Button();
            this.pnl1_vykreslit = new System.Windows.Forms.Panel();
            this.btn2_vykreslit = new System.Windows.Forms.Button();
            this.colorDialog1_pozadi = new System.Windows.Forms.ColorDialog();
            this.colorDialog2_stetec = new System.Windows.Forms.ColorDialog();
            this.btn5_smazat = new System.Windows.Forms.Button();
            this.gb1_styl.SuspendLayout();
            this.gb2_vyber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1_styl
            // 
            this.gb1_styl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb1_styl.Controls.Add(this.lbl_stetec_chyba);
            this.gb1_styl.Controls.Add(this.label1);
            this.gb1_styl.Controls.Add(this.lbl3_tloustka_stetce);
            this.gb1_styl.Controls.Add(this.tb1_tlousta_stetce);
            this.gb1_styl.Controls.Add(this.pnl4_stetec);
            this.gb1_styl.Controls.Add(this.btn4_stetec);
            this.gb1_styl.Controls.Add(this.pnl3_pozadi);
            this.gb1_styl.Controls.Add(this.btn3_pozadi);
            this.gb1_styl.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb1_styl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb1_styl.Location = new System.Drawing.Point(12, 380);
            this.gb1_styl.Name = "gb1_styl";
            this.gb1_styl.Size = new System.Drawing.Size(253, 188);
            this.gb1_styl.TabIndex = 0;
            this.gb1_styl.TabStop = false;
            this.gb1_styl.Text = "Styl";
            // 
            // lbl_stetec_chyba
            // 
            this.lbl_stetec_chyba.AutoSize = true;
            this.lbl_stetec_chyba.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_stetec_chyba.ForeColor = System.Drawing.Color.Red;
            this.lbl_stetec_chyba.Location = new System.Drawing.Point(7, 167);
            this.lbl_stetec_chyba.Name = "lbl_stetec_chyba";
            this.lbl_stetec_chyba.Size = new System.Drawing.Size(0, 18);
            this.lbl_stetec_chyba.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(7, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tloušťka štětce:";
            // 
            // lbl3_tloustka_stetce
            // 
            this.lbl3_tloustka_stetce.AutoSize = true;
            this.lbl3_tloustka_stetce.Location = new System.Drawing.Point(-285, 132);
            this.lbl3_tloustka_stetce.Name = "lbl3_tloustka_stetce";
            this.lbl3_tloustka_stetce.Size = new System.Drawing.Size(171, 22);
            this.lbl3_tloustka_stetce.TabIndex = 5;
            this.lbl3_tloustka_stetce.Text = "Tloušťka štětce:";
            // 
            // tb1_tlousta_stetce
            // 
            this.tb1_tlousta_stetce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb1_tlousta_stetce.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb1_tlousta_stetce.Location = new System.Drawing.Point(174, 137);
            this.tb1_tlousta_stetce.Name = "tb1_tlousta_stetce";
            this.tb1_tlousta_stetce.Size = new System.Drawing.Size(70, 28);
            this.tb1_tlousta_stetce.TabIndex = 4;
            this.tb1_tlousta_stetce.Text = "3";
            // 
            // pnl4_stetec
            // 
            this.pnl4_stetec.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl4_stetec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4_stetec.Location = new System.Drawing.Point(174, 87);
            this.pnl4_stetec.Name = "pnl4_stetec";
            this.pnl4_stetec.Size = new System.Drawing.Size(70, 33);
            this.pnl4_stetec.TabIndex = 3;
            // 
            // btn4_stetec
            // 
            this.btn4_stetec.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4_stetec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4_stetec.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4_stetec.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn4_stetec.Location = new System.Drawing.Point(7, 87);
            this.btn4_stetec.Name = "btn4_stetec";
            this.btn4_stetec.Size = new System.Drawing.Size(161, 33);
            this.btn4_stetec.TabIndex = 1;
            this.btn4_stetec.Text = "Barva štětce";
            this.btn4_stetec.UseVisualStyleBackColor = false;
            this.btn4_stetec.Click += new System.EventHandler(this.btn4_stetec_Click);
            // 
            // pnl3_pozadi
            // 
            this.pnl3_pozadi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl3_pozadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3_pozadi.Location = new System.Drawing.Point(174, 39);
            this.pnl3_pozadi.Name = "pnl3_pozadi";
            this.pnl3_pozadi.Size = new System.Drawing.Size(70, 33);
            this.pnl3_pozadi.TabIndex = 2;
            // 
            // btn3_pozadi
            // 
            this.btn3_pozadi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3_pozadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_pozadi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3_pozadi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn3_pozadi.Location = new System.Drawing.Point(7, 38);
            this.btn3_pozadi.Name = "btn3_pozadi";
            this.btn3_pozadi.Size = new System.Drawing.Size(161, 34);
            this.btn3_pozadi.TabIndex = 0;
            this.btn3_pozadi.Text = "Barva pozadí";
            this.btn3_pozadi.UseVisualStyleBackColor = false;
            this.btn3_pozadi.Click += new System.EventHandler(this.btn3_pozadi_Click);
            // 
            // gb2_vyber
            // 
            this.gb2_vyber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb2_vyber.Controls.Add(this.lbl_chyba_tvar);
            this.gb2_vyber.Controls.Add(this.btn1_nahled_tvaru);
            this.gb2_vyber.Controls.Add(this.numericUpDown1);
            this.gb2_vyber.Controls.Add(this.lbl2_nahled_tvaru);
            this.gb2_vyber.Controls.Add(this.lbl3_iterace);
            this.gb2_vyber.Controls.Add(this.cmb1_tvar);
            this.gb2_vyber.Controls.Add(this.lbl1_vyber_tvaru);
            this.gb2_vyber.Controls.Add(this.pnl2_nahled);
            this.gb2_vyber.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb2_vyber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb2_vyber.Location = new System.Drawing.Point(12, 12);
            this.gb2_vyber.Name = "gb2_vyber";
            this.gb2_vyber.Size = new System.Drawing.Size(253, 362);
            this.gb2_vyber.TabIndex = 1;
            this.gb2_vyber.TabStop = false;
            this.gb2_vyber.Text = "Výběr fraktálu";
            // 
            // lbl_chyba_tvar
            // 
            this.lbl_chyba_tvar.AutoSize = true;
            this.lbl_chyba_tvar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_chyba_tvar.ForeColor = System.Drawing.Color.Red;
            this.lbl_chyba_tvar.Location = new System.Drawing.Point(7, 104);
            this.lbl_chyba_tvar.Name = "lbl_chyba_tvar";
            this.lbl_chyba_tvar.Size = new System.Drawing.Size(0, 18);
            this.lbl_chyba_tvar.TabIndex = 6;
            // 
            // btn1_nahled_tvaru
            // 
            this.btn1_nahled_tvaru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1_nahled_tvaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_nahled_tvaru.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1_nahled_tvaru.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn1_nahled_tvaru.Location = new System.Drawing.Point(136, 38);
            this.btn1_nahled_tvaru.Margin = new System.Windows.Forms.Padding(0);
            this.btn1_nahled_tvaru.Name = "btn1_nahled_tvaru";
            this.btn1_nahled_tvaru.Size = new System.Drawing.Size(108, 34);
            this.btn1_nahled_tvaru.TabIndex = 3;
            this.btn1_nahled_tvaru.Text = "Náhled";
            this.btn1_nahled_tvaru.UseVisualStyleBackColor = false;
            this.btn1_nahled_tvaru.Click += new System.EventHandler(this.btn1_nahled_tvaru_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(103, 319);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(141, 29);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl2_nahled_tvaru
            // 
            this.lbl2_nahled_tvaru.AutoSize = true;
            this.lbl2_nahled_tvaru.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2_nahled_tvaru.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl2_nahled_tvaru.Location = new System.Drawing.Point(6, 122);
            this.lbl2_nahled_tvaru.Name = "lbl2_nahled_tvaru";
            this.lbl2_nahled_tvaru.Size = new System.Drawing.Size(128, 20);
            this.lbl2_nahled_tvaru.TabIndex = 4;
            this.lbl2_nahled_tvaru.Text = "Náhled tvaru:";
            // 
            // lbl3_iterace
            // 
            this.lbl3_iterace.AutoSize = true;
            this.lbl3_iterace.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3_iterace.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl3_iterace.Location = new System.Drawing.Point(7, 322);
            this.lbl3_iterace.Name = "lbl3_iterace";
            this.lbl3_iterace.Size = new System.Drawing.Size(78, 20);
            this.lbl3_iterace.TabIndex = 4;
            this.lbl3_iterace.Text = "Iterace:";
            this.lbl3_iterace.Click += new System.EventHandler(this.lbl3_iterace_Click);
            // 
            // cmb1_tvar
            // 
            this.cmb1_tvar.BackColor = System.Drawing.SystemColors.Window;
            this.cmb1_tvar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb1_tvar.ForeColor = System.Drawing.Color.Goldenrod;
            this.cmb1_tvar.FormattingEnabled = true;
            this.cmb1_tvar.Items.AddRange(new object[] {
            "Kochova vločka",
            "Cantorovo mračno",
            "Sierpinského trojúhelník",
            "Spirála"});
            this.cmb1_tvar.Location = new System.Drawing.Point(7, 75);
            this.cmb1_tvar.Name = "cmb1_tvar";
            this.cmb1_tvar.Size = new System.Drawing.Size(237, 26);
            this.cmb1_tvar.TabIndex = 2;
            this.cmb1_tvar.SelectedIndexChanged += new System.EventHandler(this.cmb1_tvar_SelectedIndexChanged);
            // 
            // lbl1_vyber_tvaru
            // 
            this.lbl1_vyber_tvaru.AutoSize = true;
            this.lbl1_vyber_tvaru.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1_vyber_tvaru.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl1_vyber_tvaru.Location = new System.Drawing.Point(7, 45);
            this.lbl1_vyber_tvaru.Name = "lbl1_vyber_tvaru";
            this.lbl1_vyber_tvaru.Size = new System.Drawing.Size(127, 20);
            this.lbl1_vyber_tvaru.TabIndex = 1;
            this.lbl1_vyber_tvaru.Text = "Vyber fraktál:";
            // 
            // pnl2_nahled
            // 
            this.pnl2_nahled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2_nahled.Location = new System.Drawing.Point(6, 145);
            this.pnl2_nahled.Name = "pnl2_nahled";
            this.pnl2_nahled.Size = new System.Drawing.Size(238, 160);
            this.pnl2_nahled.TabIndex = 0;
            // 
            // btn2_vykresli
            // 
            this.btn2_vykresli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn2_vykresli.Location = new System.Drawing.Point(12, -1040);
            this.btn2_vykresli.Name = "btn2_vykresli";
            this.btn2_vykresli.Size = new System.Drawing.Size(500, 648);
            this.btn2_vykresli.TabIndex = 0;
            this.btn2_vykresli.Text = "Vykresli!";
            this.btn2_vykresli.UseVisualStyleBackColor = true;
            // 
            // pnl1_vykreslit
            // 
            this.pnl1_vykreslit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl1_vykreslit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl1_vykreslit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1_vykreslit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.pnl1_vykreslit.Location = new System.Drawing.Point(272, 24);
            this.pnl1_vykreslit.Name = "pnl1_vykreslit";
            this.pnl1_vykreslit.Size = new System.Drawing.Size(814, 652);
            this.pnl1_vykreslit.TabIndex = 2;
            this.pnl1_vykreslit.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_vykreslit_Paint);
            // 
            // btn2_vykreslit
            // 
            this.btn2_vykreslit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn2_vykreslit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_vykreslit.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2_vykreslit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn2_vykreslit.Location = new System.Drawing.Point(13, 612);
            this.btn2_vykreslit.Name = "btn2_vykreslit";
            this.btn2_vykreslit.Size = new System.Drawing.Size(253, 64);
            this.btn2_vykreslit.TabIndex = 3;
            this.btn2_vykreslit.Text = "Vykreslit";
            this.btn2_vykreslit.UseVisualStyleBackColor = false;
            this.btn2_vykreslit.Click += new System.EventHandler(this.btn2_vykreslit_Click);
            // 
            // btn5_smazat
            // 
            this.btn5_smazat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn5_smazat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5_smazat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5_smazat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5_smazat.Location = new System.Drawing.Point(19, 574);
            this.btn5_smazat.Name = "btn5_smazat";
            this.btn5_smazat.Size = new System.Drawing.Size(238, 32);
            this.btn5_smazat.TabIndex = 4;
            this.btn5_smazat.Text = "Smazat plátno";
            this.btn5_smazat.UseVisualStyleBackColor = false;
            this.btn5_smazat.Click += new System.EventHandler(this.btn5_smazat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1098, 683);
            this.Controls.Add(this.btn5_smazat);
            this.Controls.Add(this.btn2_vykreslit);
            this.Controls.Add(this.pnl1_vykreslit);
            this.Controls.Add(this.btn2_vykresli);
            this.Controls.Add(this.gb2_vyber);
            this.Controls.Add(this.gb1_styl);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Name = "Form1";
            this.Text = "Fraktály";
            this.gb1_styl.ResumeLayout(false);
            this.gb1_styl.PerformLayout();
            this.gb2_vyber.ResumeLayout(false);
            this.gb2_vyber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb1_styl;
        private System.Windows.Forms.GroupBox gb2_vyber;
        private System.Windows.Forms.Button btn1_nahled_tvaru;
        private System.Windows.Forms.ComboBox cmb1_tvar;
        private System.Windows.Forms.Label lbl1_vyber_tvaru;
        private System.Windows.Forms.Panel pnl2_nahled;
        private System.Windows.Forms.Panel pnl4_stetec;
        private System.Windows.Forms.Button btn4_stetec;
        private System.Windows.Forms.Panel pnl3_pozadi;
        private System.Windows.Forms.Button btn3_pozadi;
        private System.Windows.Forms.Button btn2_vykresli;
        private System.Windows.Forms.Label lbl3_tloustka_stetce;
        private System.Windows.Forms.TextBox tb1_tlousta_stetce;
        private System.Windows.Forms.Label lbl2_nahled_tvaru;
        private System.Windows.Forms.Panel pnl1_vykreslit;
        private System.Windows.Forms.Button btn2_vykreslit;
        private System.Windows.Forms.ColorDialog colorDialog1_pozadi;
        private System.Windows.Forms.ColorDialog colorDialog2_stetec;
        private System.Windows.Forms.Label lbl3_iterace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn5_smazat;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_stetec_chyba;
        private System.Windows.Forms.Label lbl_chyba_tvar;
    }
}

