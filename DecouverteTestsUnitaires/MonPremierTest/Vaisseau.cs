using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierTest
{
    public class Vaisseau
    {
        #region Fields
        private int _altitude = 0;
        #endregion

        #region Public methods
        public void Decoller()
        {
            // TODO: Coder le moteur qui fait decoller un avion progressivement
            this._altitude = 10000;
        }

        public void Atterrir()
        {
            if (this._altitude == 0)
                throw new AltitudeException("On ne pas atterir si on n'a pas déjà décollé ;=)");

            this._altitude = 0;
        }

        public void Voler()
        {
            Console.WriteLine(this._altitude);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Permet de tester l'atterissage, en fixant une altitude initiale
        /// </summary>
        public int AltitudeInitiale { set => this._altitude = value; }

        public int Altitude { get => this._altitude; }
        #endregion
    }
}
