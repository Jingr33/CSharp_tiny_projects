using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    /// <summary>
    /// Class for inicialization one cell of Sudoku panel.
    /// </summary>
    class Cell : Button
    {
        public int Xcoord { get; set; }
        public int Ycoord { get; set; }
        public int Value { get; set; }
        public bool IsEmpty = true;
        public bool Flag = false;
        public Color Background;

        /// <summary>
        /// Clears the contents and data of the cell.
        /// </summary>
        public void ClearCell()
        {
            this.IsEmpty= true;
            this.Text = string.Empty;
            this.Value = 0;
        }
    }
}
