using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrairie
{
    public class Wookie
    {
        public string Name { get; set; }

        public delegate void CrieerDelegate(string cd);

        public string Crier(CrieerDelegate crier)
        {
            string message = "Le wookie " + this.Name + " crie : ROAAAAAAR !";

            crier(message);

            return message;
        }
    }
}

