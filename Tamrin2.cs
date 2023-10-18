// barnameh chap majmooh argham adad 4 raghami


using System;
namespace tamrin2
{

    class test1
    {
        public static void Main()
        {
            Console.WriteLine("enter 4 digit number :");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0, a, b, c, d;
            a = x / 1000;
            b = (x / 100) % 10;
            c = (x / 10) % 10;
            d = x % 10;
            sum = a + b + c + d;
            Console.WriteLine("sum is:");
            Console.WriteLine(sum);
        }//end main
    }//end class
}//end namespace