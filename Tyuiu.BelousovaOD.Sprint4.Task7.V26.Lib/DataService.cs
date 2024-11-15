﻿using tyuiu.cources.programming.interfaces.Sprint4;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BelousovaOD.Sprint4.Task7.V26.Lib
{
    public class DataService : ISprint4Task7V26
    {
        public int Calculate(int n, int m, string value)
  
        {
            int[,] matrix = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count = count * matrix[i, j];
                    }
                }
            }

            return count;
        }
    }
}
