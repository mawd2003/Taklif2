// barnameh chap adad aval bein do adad



using System;
namespace tamrin4
{

    class test1
    {
        public static void Main()
        {
            Console.WriteLine("adad aval ra vared konid : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("adad dovom ra vared konid : ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("adad aval bein an ha : ") ;

            for (int i = x; i <= y; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                    Console.WriteLine(i);
                else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i != 1)
                    Console.WriteLine(i);
            }

        }//end main
    }//end class
}//end namespace