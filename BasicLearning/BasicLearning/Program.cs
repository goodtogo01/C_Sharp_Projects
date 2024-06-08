using System;

namespace BasicLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] i = new int[] {1,3,2,1,5,4,6,5,7, 11
            };
            for (int j = 0; j < i.Length; j++)
            {
                if (j)
                {
                    Console.WriteLine(j);
                    Console.ReadLine();
                }
                Console.WriteLine();
            }
        }

    }
}
