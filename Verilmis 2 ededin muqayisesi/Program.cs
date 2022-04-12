using System;

namespace Verilmis_2_ededin_muqayisesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine(num1 + " " + "boyukdur");
            }
            else if (num1<num2)
            {
                Console.WriteLine(num2 + " " + " boyukdur" );
            }
            else
            {
                Console.WriteLine("Verilmis ededler beraberdir");
            }
        }
    }
}
