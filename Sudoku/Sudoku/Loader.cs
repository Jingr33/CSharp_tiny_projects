using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace Sudoku
{
    /// <summary>
    /// Class for loading saved games.
    /// </summary>
    class Loader
    {
        public Loader(Cell[,] cells)
        {
            string file_data = LoadData();
            if (file_data != "")
                FillCellsByData(cells, file_data);
        }

        public string game_time = "00:00:00";

        /// <summary>
        /// Open OpenFileDialog a download data from a file.
        /// </summary>
        /// <returns> string of file data </returns>
        private string LoadData()
        {
            OpenFileDialog SaveDialog = new OpenFileDialog();
            DialogResult result = SaveDialog.ShowDialog();
            string file_data = "";
            if (result == DialogResult.OK)
            {
                string file_name = SaveDialog.FileName;
                file_data = File.ReadAllText(file_name);
            }
            return file_data;
        }

        /// <summary>
        /// Pass data to the cells and set appropriate cell settings.
        /// </summary>
        /// <param name="cells"> array of the cells </param>
        /// <param name="data"> string of dates from file </param>
        private void FillCellsByData (Cell[,] cells, string data)
        {
            string[] one_cell_data = data.Split('\n');
            
            for (int i = 0; i < 9*9; i++)
            {
                char[] char_values = one_cell_data[i].ToCharArray();
                // coords and value
                int xcoord = Convert.ToInt32(char_values[0] - '0');
                int ycoord = Convert.ToInt32(char_values[1] - '0');
                cells[xcoord, ycoord].Value = Convert.ToInt32(char_values[2] - '0');
                cells[xcoord, ycoord].Xcoord = xcoord;
                cells[xcoord, xcoord].Ycoord = ycoord;
                // IsEmpty
                if (char_values[3] == 'T')
                {
                    cells[xcoord, ycoord].IsEmpty = true;
                    cells[xcoord, ycoord].ForeColor = SystemColors.ControlDarkDark;
                } 
                else if (char_values[3] == 'F') 
                {
                    cells[xcoord, ycoord].IsEmpty = false;
                    cells[xcoord, ycoord].ForeColor = Color.Black;
                }
                // Text value
                cells[xcoord, ycoord].Text = (char_values[2] - '0').ToString();
                if (cells[xcoord, ycoord].Value == 0)
                {
                    cells[xcoord, ycoord].Text = string.Empty;
                }
            }
            // set game time
            this.game_time = one_cell_data[one_cell_data.Length - 1];
        }
    }
}
