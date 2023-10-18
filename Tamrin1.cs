// barnameh chap bozorg tarin adad dar yek araye do bodi


using System;
namespace Tamrin1
{

    class test1
    {
        public static void Main()
        {
            int[,] x = new int[3, 3];

            Console.WriteLine("plz fill the arrey :");

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int max = x[0, 0];
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (x[i, j] > max)
                    {
                        max = x[i, j];
                    }
                }
            }
            Console.WriteLine("max is :");

            Console.WriteLine(max);

            Console.ReadLine();
        }//end main
    }//end class
}//end namespace