using System;


namespace Sudoku
{
    /// <summary>
    /// Class for solving the sudoku.
    /// </summary>
    class Solver
    {
        public Solver()
        {

        }

        private int Row;
        private int Column;
        private bool Solvable;
        private int Recursion_deep;
        public int[,] matrix = new int[9,9];

        /// <summary>
        /// Find out if Sudoku is solvable.
        /// </summary>
        /// <param name="matrix"> task </param>
        /// <param name="cells"> Array of the cells </param>
        /// <returns></returns>
        public bool IsSolvable(int[,] matrix, Cell[,] cells)
        {
            this.Row = 0;
            this.Column = 0;
            this.matrix = matrix;
            this.Solvable = true;
            this.Recursion_deep = 0;
            Solve(cells);
            return this.Solvable;
        }

        /// <summary>
        /// Get solved matrix
        /// </summary>
        /// <param name="matrix"> task</param>
        /// <param name="cells"> Array of the cells </param>
        /// <returns></returns>
        public int[,] GetSolution (int[,] matrix, Cell[,] cells)
        {
            this.Row = 0;
            this.Column = 0;
            this.matrix = matrix;
            this.Solvable = true;
            Solve(cells);
            return this.matrix;
        }        

        /// <summary>
        /// Method for solving sudoku. It set attributes of class.
        /// </summary>
        /// <param name="matrix"> task </param>
        /// <param name="cells"> Array of the cells </param>
        public void Solve(Cell[,] cells)
        {
            // Stackoverflow protection
            this.Recursion_deep++;
            if (this.Recursion_deep > 6000)
                this.Solvable = false;

            bool break_loops = false;
            for (int i = this.Row; i < 9; i++)
            {
                for (int j = this.Column; j < 9; j++)
                {
                    // if filled cell from assignment
                    if (!cells[i, j].IsEmpty)
                        continue;

                    // sets the smallest value that meets sudoku rules
                    for (int value = this.matrix[i, j] + 1; value <= 9; value++)
                    {   
                        this.matrix[i, j] = value;
                        if (CheckTheRules(this.matrix, i, j))
                            break;

                        // no value met the rules
                        if (value == 9)
                            this.matrix[i, j] = 0;
                    }
                    // if value is 0 -> no value in the cell follow the rules
                    if (this.matrix[i, j] == 0)
                    {
                        this.Row = i;
                        this.Column = j;
                        break_loops = true;
                        break;
                    }
                }
                if (break_loops)
                    break; 
                // set column = 0 if it skip to new row
                this.Column = 0;
            }

            // if algorithm entered the wrong path -> will go back one or several cells and try another solution
            if (break_loops)
            {
                BacktrackIndexes(cells, this.Row, this.Column);
                if (this.Solvable) // if is exist chance for solve the problem
                    Solve(cells);
            }
        }

        /// <summary>
        /// Backtrack position of solving to the last changeable value of a cell
        /// </summary>
        /// <param name="matrix"> matrix with intermediate result </param>
        /// <param name="cells"> array of the cells </param>
        /// <param name="i"> row position </param>
        /// <param name="j"> column position </param>
        private void BacktrackIndexes(Cell[,] cells, int i, int j)
        {
            bool backtrack_again = true; // if it is true index go back one cell
            while (backtrack_again)
            {
                j -= 1;
                if (j < 0)
                {
                    j = 8;
                    i -= 1;
                }

                // negative index -> task is not solvable
                if (i < 0)
                {
                    this.Solvable = false;
                    backtrack_again = false;
                }
                else if (cells[i, j].IsEmpty && (this.matrix[i, j] != 9)) // new changeable cell was found
                {
                    // end of backtrack
                    backtrack_again = false;
                }  
                else if (cells[i, j].IsEmpty && (this.matrix[i, j] == 9)) // last cell is not changeable
                {
                    this.matrix[i, j] = 0; // set value of last cell to 0
                    backtrack_again = true; // backtracking continue
                }
            }
            this.Row = i;
            this.Column = j;
        }

        /// <summary>
        /// Check all (column, row and block) sudoku rules.
        /// </summary>
        /// <param name="matrix"> task matrix </param>
        /// <param name="i"> column </param>
        /// <param name="j"> row </param>
        /// <returns></returns>
        public static bool CheckTheRules(int[,] matrix, int i, int j)
        {
            bool column = CheckColumnRule(matrix, i, j);
            bool row = CheckRowRule(matrix, i, j);
            bool block = CheckBlockRule(matrix, i, j);
            return column && row && block;
        }

        /// <summary>
        /// Check column rule
        /// </summary>
        /// <param name="matrix"> task matrix </param>
        /// <param name="i"> row </param>
        /// <param name="j"> column </param>
        /// <returns></returns>
        public static bool CheckColumnRule(int[,] matrix, int i, int j)
        {
            for (int k = 0; k < 9; k++)
            {
                if (k == i)
                    continue;
                if (matrix[i, j] == matrix[k, j])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Check row rule.
        /// </summary>
        /// <param name="matrix"> task matrix</param>
        /// <param name="i"> row </param>
        /// <param name="j"> column </param>
        /// <returns></returns>
        public static bool CheckRowRule(int[,] matrix, int i, int j)
        {
            for (int k = 0; k < 9; k++)
            {
                if (k == j)
                    continue;
                if (matrix[i, j] == matrix[i, k])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Check block rule.
        /// </summary>
        /// <param name="matrix"> task matrix</param>
        /// <param name="i"> row </param>
        /// <param name="j"> column </param>
        /// <returns></returns>
        public static bool CheckBlockRule(int[,] matrix, int i, int j)
        {
            int x_block_coord = i / 3;
            int y_block_coord = j / 3;
            for (int k = x_block_coord * 3; k < x_block_coord * 3 + 3; k++)
            {
                for (int l = y_block_coord * 3; l < y_block_coord * 3 + 3; l++)
                {
                    if ((i == k) && (j == l))
                        { continue; }
                    if (matrix[i, j] == matrix[k, l])
                        { return false; }
                }
            }
            return true;
        }

    }
}
