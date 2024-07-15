using System;
using System.Windows.Forms;
using System.IO;

namespace Sudoku
{
    /// <summary>
    /// Class for saving a game.
    /// </summary>
    class Saver
    {
        public Saver(Cell[,] cells, string game_time)
        {
            string data_string = PrepareValues(cells, game_time);
            SaveData(data_string);
        }

        /// <summary>
        /// It prepares the text to be written to the file.
        /// </summary>
        /// <param name="cells"> array of the cells </param>
        /// <param name="game_time"> game time </param>
        /// <returns></returns>
        private string PrepareValues(Cell[,] cells, string game_time)
        {
            string cells_data = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // If IsEmpty value
                    string isempty;
                    if (cells[i, j].IsEmpty)
                    {
                        isempty = "T";

                    }
                    else
                    {
                        isempty = "F";
                    }
                    // string for file
                    cells_data += String.Format("{0}{1}{2}{3}\n", i, j, cells[i, j].Value.ToString(), isempty);
                }
            }
            cells_data += game_time; // Add game_time
            return cells_data;
        }

        /// <summary>
        /// Inicialization of SaveFileDialog and it save the data to the file.
        /// </summary>
        /// <param name="data"> string to file</param>
        private void SaveData(string data)
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.DefaultExt = "txt";
            DialogResult result = SaveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file_name = SaveDialog.FileName;
                File.WriteAllText(file_name, data);
            }
        }

    }
}
