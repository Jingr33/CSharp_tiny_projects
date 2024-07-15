using System;
using System.Drawing;


namespace Sudoku
{
    /// <summary>
    /// Class to generate assignment of the sudoku.
    /// </summary>
    class SudokuCreator
    {
        private Solver SudokuSolver = new Solver();

        public SudokuCreator(Cell[,] cells)
        {
            ClearAllCells(cells);
            int[,] task_matrix = CreateTask(cells);
            SetValuesInCells(task_matrix, cells);
        }

        /// <summary>
        /// Method for generation of the task.
        /// </summary>
        /// <param name="cells"> Array of all cells</param>
        /// <returns></returns>
        private int[,] CreateTask(Cell[,] cells)
        {
            int[,] suggestion = new int[9, 9];
            bool solvable = false;
            while (!solvable)
            {
                suggestion = CreateSuggestion(cells);
                solvable = SudokuSolver.IsSolvable(suggestion, cells);
                SetExtraLockedCells(cells, SudokuSolver.matrix);
            }
            return suggestion;
        }

        /// <summary>
        /// Generate suggestion of Sudoku task, which meets the rules (may not be solvable).
        /// </summary>
        /// <param name="cells"> Array of all cells </param>
        /// <returns></returns>
        private int[,] CreateSuggestion(Cell[,] cells)
        {
            // creation of sudoku grid with 0
            int[,] matrix = new int[9, 9];
            ClearAllCells(cells);

            // generation of random sudoku field
            for (int n = 0; n < 17; n++) // 17 cells is filled from the start
            {
                bool rules_followed = false; // check, if the rules are met
                while (!rules_followed)
                {
                    rules_followed = AssignRndValueToMatrix(matrix, cells);
                }
            }
            return matrix;

        }

        /// <summary>
        /// Add one random value in random place in sudoku field where it meets the rules
        /// </summary>
        /// <param name="matrix"> Sudoku task suggestion </param>
        /// <param name="cells"> Array of all cells </param>
        /// <returns></returns>
        private bool AssignRndValueToMatrix(int[,] matrix, Cell[,] cells)
        {
            var random = new Random();
            // generation of random value in grid
            int xcoord = random.Next(0, 9);
            int ycoord = random.Next(0, 9);
            int value = random.Next(1, 10);
            // if this place is already taken
            int old_value = matrix[xcoord, ycoord];
            if (old_value != 0)
                return false;
            // rules check
            matrix[xcoord, ycoord] = value;
            bool rules_followed = Solver.CheckTheRules(matrix, xcoord, ycoord);
            if (!rules_followed)
            {
                matrix[xcoord, ycoord] = 0;
                return false;
            }
            // set IsEmpty and Value into the cell
            cells[xcoord, ycoord].IsEmpty = false;
            cells[xcoord, ycoord].Value = value;
            return true;
        }

        /// <summary>
        /// Set pre-generated values in the cells
        /// </summary>
        /// <param name="matrix"> task matrix </param>
        /// <param name="cells"> Array of the cells </param>
        private void SetValuesInCells(int[,] matrix, Cell[,] cells)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!cells[i, j].IsEmpty)
                    {
                        cells[i, j].Text = matrix[i, j].ToString();
                        cells[i, j].ForeColor = Color.Black;
                    }
                }
            }
        }

        /// <summary>
        /// Set 10 random extra locked cells (due to difficulty).
        /// </summary>
        /// <param name="cells"> array of the cells </param>
        private void SetExtraLockedCells(Cell[,] cells, int[,] solved_matrix)
        {
            var random = new Random();
            for (int n = 0; n < 10; n++)
            {
                int i = random.Next(0, 9);
                int j = random.Next(0, 9);
                cells[i, j].Value = solved_matrix[i, j];
                cells[i, j].IsEmpty = false;
            }
        }

        /// <summary>
        /// Clear all content and values in all cells.
        /// </summary>
        /// <param name="cells"> Array of the cells </param>
        private void ClearAllCells(Cell[,] cells)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cells[i, j].ClearCell();
                }
            }
        }
    }
}