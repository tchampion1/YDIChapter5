using System;
using static System.Console;

namespace TippingTable2
{
    internal class TippingTable2
    {
        static void Main(string[] args)
        {
            double dinnerPrice = 10.00;
            double tipRate;
            double tip;
            const double LOWRATE = 0.10;
            const double MAXRATE = 0.25;
            const double TIPSTEP = 0.05;
            const double MAXDINNER = 100.00;
            const double DINNERSTEP = 10.00;
            const int NUM_DASHES = 40;

            Write(" Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                Write($"{tipRate.ToString("F"),8}");
            WriteLine();
            //WriteLine("--------------------------------------------------");
            for (int x = 0; x < NUM_DASHES; ++x)

                Write("-");

            WriteLine();

            tipRate = LOWRATE;
            do
            {
                Write($"{dinnerPrice.ToString("C")}");
                while (tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Write($"{tip.ToString("F"),8}");
                    tipRate += TIPSTEP;

                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                WriteLine();

            } while (dinnerPrice <= MAXDINNER);
            ReadLine();

        }

    }
}
