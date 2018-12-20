using StarWarsLibrairie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WookieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Wookie wookie = new Wookie()
            {
                Name = "Chewie"
            };

            wookie.Crier((message) =>
            {
                Console.WriteLine(message);
            }) ;
        }
    }
}
