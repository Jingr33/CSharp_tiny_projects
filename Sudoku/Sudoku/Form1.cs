using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Sudoku : Form
    {
        public Sudoku()
        {
            InitializeComponent();
            createCells();
            StartNewGame();
            Game_timer();
            ResetTime();
        }

        // 81 cells
        Cell[,] cells = new Cell[9, 9];
        // for timer
        System.Windows.Forms.Timer Game_time = new System.Windows.Forms.Timer();
        private DateTime start_time = DateTime.Now;

        /// <summary>
        /// initialization of cells for writing numbers
        /// </summary>
        private void createCells()
        {
            int height = 41;
            int width = 41;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cells[i, j] = new Cell();
                    cells[i, j].Xcoord = i;
                    cells[i, j].Ycoord = j;
                    cells[i, j].Size = new Size(height, width);
                    cells[i, j].Location = new Point(i * height, j * width);
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.LightSlateGray;
                    SetCellBackground(cells[i, j], i, j);
                    panel1.Controls.Add(cells[i, j]);
                    // event assigment
                    cells[i, j].KeyPress += cell_keyEntered;
                }
            }
        }

        /// <summary>
        /// Set background color of a cell.
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="i"> Row number </param>
        /// <param name="j"> Column number </param>
        private void SetCellBackground (Cell cell, int i, int j)
        {
            int column = j / 3;
            int row = i / 3;
            if (((column % 3 == 1) ||(row % 3 == 1)) && (column != row))
            {
                cell.BackColor = (i + j) % 2 == 0 ? Color.WhiteSmoke : Color.AliceBlue;
            }
            else
            {
                cell.BackColor = (i + j) % 2 == 0 ? Color.Cornsilk : Color.LightYellow;
            }
            cells[i, j].Background = cells[i, j].BackColor;
        }

        /// <summary>
        /// Event for entering a number in a cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cell_keyEntered (object sender, KeyPressEventArgs e)
        {
            var cell = sender as Cell;
            // if locked cell
            if (!cell.IsEmpty)
                return;
            // enter the value
            if (int.TryParse(e.KeyChar.ToString(), out int value))
            {
                cell.Text = value.ToString();
                cell.Value = value;
                cell.ForeColor = SystemColors.ControlDarkDark;
                if (value == 0)
                    cell.Text = "";
            }
            // add flag
            if (e.KeyChar.ToString() == "f")
            {
                if (cell.Flag)
                {
                    cell.BackColor = cell.Background;
                    cell.Flag = false;
                } else
                {
                    cell.BackColor = Color.Orange;
                    cell.Flag = true;
                }
            }
        }

        /// <summary>
        /// It will generate a new game (and reset a timer).
        /// </summary>
        private void StartNewGame ()
        {
            SudokuCreator Creator = new SudokuCreator(cells);
            ResetTime();
        }

        /// <summary>
        /// Event for press "Nová hra" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_new_game_Click(object sender, EventArgs e)
        {
            StartNewGame();
            ResetTime();
            Game_time.Start();
        }

        /// <summary>
        /// "Uložit" button press event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_save_Click(object sender, EventArgs e)
        {
            Saver Game_saver = new Saver(cells, l_time.Text);
            ResetTime(l_time.Text);
        }

        /// <summary>
        /// "Načíst" button press event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_load_Click(object sender, EventArgs e)
        {
            Loader Game_loader = new Loader(cells);
            ResetTime(Game_loader.game_time);
        }

        /// <summary>
        /// Inicialization of timer
        /// </summary>
        private void Game_timer ()
        {
            Game_time.Interval = 300; 
            Game_time.Tick += new EventHandler(TimerTick);
            Game_time.Start();
        }

        /// <summary>
        /// View a timer in the application (in right format)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void TimerTick(object source, EventArgs e)
        {
            string long_time = DateTime.Now.Subtract(this.start_time).ToString();
            l_time.Text = long_time.Split('.')[0];
        }

        /// <summary>
        /// Reset time method.
        /// </summary>
        private void ResetTime ()
        {
            this.start_time = DateTime.Now;
        }
        private void ResetTime (string extra_time)
        {
            string[] array_time =  extra_time.Split(':');
            int hours = Convert.ToInt32(array_time[0]);
            int minutes = Convert.ToInt32(array_time[1]);
            int seconds = Convert.ToInt32(array_time[2]);
            this.start_time = DateTime.Now;
            this.start_time = this.start_time.AddHours(-hours);
            this.start_time = this.start_time.AddMinutes(-minutes);
            this.start_time = this.start_time.AddSeconds(-seconds);
        }

        /// <summary>
        /// "Vyhodnotit" button press event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_check_game_Click(object sender, EventArgs e)
        {
            Game_time.Stop();
            Checker game_checker = new Checker(cells);
        }

        private void l_time_Click(object sender, EventArgs e)
        {

        }
        private void Sudoku_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
