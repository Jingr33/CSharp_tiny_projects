
namespace Sudoku
{
    partial class Sudoku
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_save = new System.Windows.Forms.Button();
            this.b_load = new System.Windows.Forms.Button();
            this.b_new_game = new System.Windows.Forms.Button();
            this.b_check_game = new System.Windows.Forms.Button();
            this.l_info = new System.Windows.Forms.Label();
            this.l_time = new System.Windows.Forms.Label();
            this.l_info2 = new System.Windows.Forms.Label();
            this.l_info3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 463);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_save.FlatAppearance.BorderSize = 0;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_save.Location = new System.Drawing.Point(524, 492);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(193, 38);
            this.b_save.TabIndex = 1;
            this.b_save.Text = "Uložit";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_load
            // 
            this.b_load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_load.FlatAppearance.BorderSize = 0;
            this.b_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_load.Location = new System.Drawing.Point(524, 448);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(193, 38);
            this.b_load.TabIndex = 2;
            this.b_load.Text = "Načíst hru";
            this.b_load.UseVisualStyleBackColor = false;
            this.b_load.Click += new System.EventHandler(this.b_load_Click);
            // 
            // b_new_game
            // 
            this.b_new_game.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_new_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_new_game.FlatAppearance.BorderSize = 0;
            this.b_new_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_new_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_new_game.Location = new System.Drawing.Point(524, 67);
            this.b_new_game.Name = "b_new_game";
            this.b_new_game.Size = new System.Drawing.Size(193, 53);
            this.b_new_game.TabIndex = 3;
            this.b_new_game.Text = "Nová hra";
            this.b_new_game.UseVisualStyleBackColor = false;
            this.b_new_game.Click += new System.EventHandler(this.b_new_game_Click);
            // 
            // b_check_game
            // 
            this.b_check_game.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_check_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_check_game.FlatAppearance.BorderSize = 0;
            this.b_check_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_check_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_check_game.Location = new System.Drawing.Point(524, 231);
            this.b_check_game.Name = "b_check_game";
            this.b_check_game.Size = new System.Drawing.Size(193, 38);
            this.b_check_game.TabIndex = 5;
            this.b_check_game.Text = "Vyhodnotit";
            this.b_check_game.UseVisualStyleBackColor = false;
            this.b_check_game.Click += new System.EventHandler(this.b_check_game_Click);
            // 
            // l_info
            // 
            this.l_info.AutoSize = true;
            this.l_info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_info.Location = new System.Drawing.Point(12, 537);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(80, 17);
            this.l_info.TabIndex = 7;
            this.l_info.Text = "Značka -> f";
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_time.Location = new System.Drawing.Point(210, 22);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(111, 29);
            this.l_time.TabIndex = 8;
            this.l_time.Text = "00:00:00";
            this.l_time.Click += new System.EventHandler(this.l_time_Click);
            // 
            // l_info2
            // 
            this.l_info2.AutoSize = true;
            this.l_info2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_info2.Location = new System.Drawing.Point(109, 537);
            this.l_info2.Name = "l_info2";
            this.l_info2.Size = new System.Drawing.Size(91, 17);
            this.l_info2.TabIndex = 9;
            this.l_info2.Text = "Vymazat -> 0";
            // 
            // l_info3
            // 
            this.l_info3.AutoSize = true;
            this.l_info3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_info3.Location = new System.Drawing.Point(587, 537);
            this.l_info3.Name = "l_info3";
            this.l_info3.Size = new System.Drawing.Size(130, 17);
            this.l_info3.TabIndex = 10;
            this.l_info3.Text = "ulozene_sudoku.txt";
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 583);
            this.Controls.Add(this.l_info3);
            this.Controls.Add(this.l_info2);
            this.Controls.Add(this.l_time);
            this.Controls.Add(this.l_info);
            this.Controls.Add(this.b_check_game);
            this.Controls.Add(this.b_new_game);
            this.Controls.Add(this.b_load);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.panel1);
            this.Name = "Sudoku";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Sudoku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_load;
        private System.Windows.Forms.Button b_new_game;
        private System.Windows.Forms.Button b_check_game;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Label l_info2;
        private System.Windows.Forms.Label l_info3;
    }
}

