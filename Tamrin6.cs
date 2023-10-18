// barnameh chap bozorg tarin va kochek tarin adad dar yek araye 100 taie


using System;
namespace Tamrin6
{
    class test1
    {
        static void Main()
        {
            int[] array = new int[100];
            Console.WriteLine("plz fill arrey");
            for (int i = 0; i < 100; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = array[0];
            for (int i = 0; i < 100; i++)

            {
                if (array[i] < min)
                {
                    min = array[i];

                }
            }
            int max = array[99];
            for (int i = 0; i < 100; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];

                }
            }
            Console.WriteLine("kouchek tarin : ", min);
            Console.WriteLine("bozorg tarin :", max);
            Console.Read();

        }
    }
}
