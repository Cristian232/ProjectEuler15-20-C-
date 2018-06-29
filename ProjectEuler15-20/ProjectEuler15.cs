using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,
//there are exactly 6 routes to the bottom right corner.

//How many such routes are there through a 20×20 grid?


namespace ProjectEuler15_20
{
    class ProjectEuler15
    {
       
        
        public long fillGrid(int n)
        {
            long[,] grid = new long[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0)
                    {
                        grid[i, j] = 1L;
                    }
                    else if (j == 0)
                    {
                        grid[i, j] = 1L;
                    }
                    else
                    {
                        grid[i, j] = grid[i, j - 1] + grid[i - 1, j];
                    }
                }
            }

            return grid[n-1,n-1];
        }
        
    }
}
