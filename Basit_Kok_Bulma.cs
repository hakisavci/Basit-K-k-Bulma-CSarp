using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            double a, b, c, x1, x2, d;

            Console.WriteLine("");
            Console.Write("ax^2+bx+c şeklinde 2. dereceden denklemin köklerini bulma" + "\n");

            Console.WriteLine("---------------------------------------------------------" + "\n");

            Console.Write(" a değerini giriniz :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            Console.Write(" b değerini giriniz: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            Console.Write(" c değerini giriniz: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            Console.Write("a =" + a + " " + "b = " + b + " " + "c = " + c + "\n");
            Console.WriteLine("-----------------------------");

            d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.Write("Sanal kok var!" + "\n");
            }

            else if (d == 0)
            {
                x1 = -b / 2 * a;
                Console.Write("Tek kök var!" + "\n");
                Console.Write("");
                Console.WriteLine("-----------------------------");
                Console.Write("X1 =" + x1 + "\n");
            }
            else
            {
                x1 = -b - Math.Sqrt(d) / 2 * a;
                x2 = -b + Math.Sqrt(d) / 2 * a;
                Console.Write("Çift kök var !" + "\n");

                Console.Write("" + "\n");
                Console.Write("X1=" + x1 + "\n");

                Console.Write("" + "\n");
                Console.Write("X2=" + x2 + "\n");
            }



            Console.ReadLine();



        }
    }
}
