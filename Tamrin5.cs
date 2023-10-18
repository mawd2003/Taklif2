//be dast avardan y ba tabei bar hasb x shamel radikal va ghadr motlagh


using System;
namespace Tamrin5
{

    class test1
    {
        public static void Main()
        {
            Console.WriteLine("x ra vared konid :");

            int x = Convert.ToInt32(Console.ReadLine());

            double abs_x = Math.Abs(x);

            double sqrt_abs_x = Math.Sqrt(abs_x);

            double z = Math.Sqrt(abs_x + sqrt_abs_x);

            double y = Math.Sqrt(abs_x + z);

            Console.WriteLine("y barabar ast ba :");

            Console.WriteLine(y);

        }//end main
    }//end class test1
}//end namespace


