using System;

namespace CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // ImageRotation im = new ImageRotation();
            // im.ShowArray();
            int[] arr = { 10,5,6,7,8};
            bool ifPal = almostIncreasingSequence(arr);
        }

        static bool almostIncreasingSequence(int[] sequence)
        {
            if (sequence.Length == 2) { return true; }
            int countOne = 0;
            int countTwo = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    countOne++;
                }
                if (i != 0)
                {
                    if (sequence[i - 1] >= sequence[i + 1])
                    {
                        countTwo++;
                    }
                }
            }

            if (countOne == 1 && countTwo <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
