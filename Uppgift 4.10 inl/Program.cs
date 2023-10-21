using System;

namespace Uppgift_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per X grupp?");
            int mängdX = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per O grupp?");
            int mängdO = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O mönster per rad?");
            int mängdOgrupp = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int mängdRADER = int.Parse(Console.ReadLine());

            string Xgrupp = "";
            string Ogrupp = "";
            string RAD = "";

            for (int i = 0; i < mängdX; i++)
            {
                Xgrupp = Xgrupp + "X";
            }
            for (int i = 0; i < mängdO; i++)
            {
                Ogrupp = Ogrupp + "O";
            }
            for (int i = 0; i < mängdOgrupp; i++)
            {
                RAD = RAD + Xgrupp + "-" + Ogrupp + "-";
            }
            RAD = RAD + Xgrupp;
            for(int i = 0; i < mängdRADER; i++)
            {
                Console.WriteLine(RAD);
            }
        }

    }

}