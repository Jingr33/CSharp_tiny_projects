using System;
using System.Drawing;

namespace Sudoku
{
    /// <summary>
    /// Class for checking the correctness of the solution.
    /// </summary>
    class Checker
    {
        public Checker (Cell[,] cells)
        {
            int[,] task_matrix = prepareMatrix(cells);
            int[,] solved_matrix = solveTask(task_matrix, cells);
            CompareSolutions(cells, solved_matrix);
        }

        /// <summary>
        /// It prepare the task matrix int int array.
        /// </summary>
        /// <param name="cells"> array of the cells </param>
        /// <returns> 2D int array of task values </returns>
        private int[,] prepareMatrix (Cell[,] cells)
        {
            int[,] matrix = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!cells[i, j].IsEmpty)
                    {
                        matrix[i, j] = cells[i, j].Value;
                    }
                }
            }
            return matrix;
        }

        /// <summary>
        /// It solve the task.
        /// </summary>
        /// <param name="task_matrix"> task </param>
        /// <param name="cells"> array of the cells </param>
        /// <returns> solved sudoku in 2D int array </returns>
        private int[,] solveTask (int[,] task_matrix, Cell[,] cells)
        {
            Solver Task_solver = new Solver();
            int[,] solved_matrix = Task_solver.GetSolution(task_matrix, cells);
            return solved_matrix;
        }

        /// <summary>
        /// It compares the values in sudoku a marks mismatched numbers.
        /// </summary>
        /// <param name="cells"> array of the cells</param>
        /// <param name="right_sol"> right solution of sudoku </param>
        private void CompareSolutions(Cell[,] cells, int[,] right_sol)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (cells[i, j].Value == right_sol[i, j])
                    {
                        continue;
                    }
                    else
                    {
                        cells[i, j].Text = right_sol[i, j].ToString();
                        cells[i, j].ForeColor = Color.Red;
                    }
                }
            }

        }
    }
}
