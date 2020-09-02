using System;

namespace First100PrimeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int value = 0;
            int rowDisplayCount = 0;

            Console.WriteLine("|The First 100 Prime Numbers are:|");
            Console.WriteLine("|********************************|\n");

            do
            {
                int num = value % 2;

                if(num != 0)
                {
                    Console.Write("{0} ", value);
                    rowDisplayCount++;

                    //Display Only 10 values per row
                    if (rowDisplayCount == 10)
                    {
                        Console.WriteLine("\n");
                        rowDisplayCount = 0;
                    }

                    count++;
                }
                value++;

            } while (count <= 100);

            Console.ReadKey();
        }
    }
}
