using System;
namespace CodingProblems
{
    public class ImageRotation
    {
        private int[,] array = { { 1, 2, 3, 4 },
                                { 5, 6, 7, 8 },
                                { 9, 10, 11, 12 },
                                { 13, 14, 15, 16 },
                                };

        private void Rotatearray(int[,] array)
        {
            int N = array.GetLength(0);

            // to get the matrix transposed 
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    int temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
            }
            

            //flip the first and last columns using two pointer approach
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < (N / 2); j++)
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, N - 1 - j];
                    array[i, N - 1 - j] = temp;
                }
            }
        }

        public void ShowArray()
        {
            Rotatearray(array);
            int N = array.GetLength(0);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}