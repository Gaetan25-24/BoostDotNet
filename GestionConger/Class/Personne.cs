using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionConger.Class
{
    internal class Personne
    {
        private string IMSalarier;
        private string nomSalarier;
        private string prenomSalarier;

        public Personne()
        {

        }

        public Personne(string im, string nom, string prenom)
        {
            this.IMSalarier = im;
            this.nomSalarier = nom;
            this.prenomSalarier = prenom;
        }

        public string IMSalarier1
        {
            get { return IMSalarier; }
            set { IMSalarier = value; }
        }
        public string NomSalarier
        {
            get { return nomSalarier; }
            set { nomSalarier = value; }
        }
        public string PrenomSalarier
        {
            get { return prenomSalarier; }
            set { prenomSalarier = value; }
        }

    }
}
