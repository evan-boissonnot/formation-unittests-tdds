using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierTest
{
    class Program
    {
        static Dictionary<string, string> __monDicoDInfos = new Dictionary<string, string>();


        static void Main(string[] args)
        {
            __monDicoDInfos.Add("AltitudeException", "Un vaisseau ne peut atterrir sans avoir décollé");
            __monDicoDInfos.Add("Exception", "Il y a eu une erreur non prévue");


            try
            {
                Vaisseau vaisseau = new Vaisseau();

                vaisseau.Atterrir();
                vaisseau.Voler();
                vaisseau.Decoller();
            }
            catch (Exception ex)
            {
                if(ex is AltitudeException)
                    Console.WriteLine("Hey ya une erreur sur l'altitude");

                // version sans if : 
                //var message = __monDicoDInfos[ex.GetType().Name];
                //Console.WriteLine(message);
            }
            
        }
    }
}
