using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calculateur
    {
        public int Diviser(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public int Additionner(int valeur1, int valeur2)
        {
            if (valeur1 == 10)
                return 230;

            return valeur1 + valeur2;
        }

        public int Multiplier(int valeur1, int valeur2)
        {
            return valeur1 * valeur2;
        }
    }
}
