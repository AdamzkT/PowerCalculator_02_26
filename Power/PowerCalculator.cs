using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public class PowerCalculator
    {
        public double CalculatePower(int basee, int exponent)
        {
            double eredmeny = 1;
            if(exponent >= 0)
            {
                for (int i = 0; i < exponent; i++)
                {
                    eredmeny = eredmeny * basee;
                }
            }
            else
            {
                if (basee == 0) { return 0; }
                for (int i = 0; i < -exponent; i++)
                {
                    eredmeny = eredmeny / basee;
                }
            }
            
            return eredmeny;
        }

        static void Main(string[] args)
        {
            var power = new PowerCalculator();
            int szam = intBemenet("szám: ");
            int hatvany = intBemenet("hatvány: ");
            Console.WriteLine("Eredmény: " + power.CalculatePower(szam, hatvany));

            Console.ReadKey();
        }

        private static int intBemenet(string szoveg)
        {
            while (true) {
                try
                {
                    Console.Write(szoveg);
                    int be = Convert.ToInt32(Console.ReadLine());
                    return be;
                }
                catch { Console.WriteLine("  Rossz bemenet"); }
            }
        }
    }
}
