using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLO
{
    static void main(string[]args)
    {
        public class HLO
    {
        public static bool Prime(int nb)
        {

            if (nb < 3)
            {
                return true;
            }
            else
            {

                for (int i = 2; i <= nb; i++)
                {
                    if (nb % i == 0)
                    {

                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {

            int nb = 0;
            do
            {
                Console.WriteLine("entrer un nombre :");

            } while (int.TryParse(Console.ReadLine(), out nb));

            if (Prime(1))
            {
                Console.WriteLine("premier");
            }
            else
            {
                Console.WriteLine("Pas premier");
            }

        }
    }
}
       
        }
    }


}
