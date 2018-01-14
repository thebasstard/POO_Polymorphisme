using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Polymorphisme
{
    class Personne
    {

        private string nom;
        private string prenom;
        private DateTime datenaissance;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public DateTime Datenaissance
        {
            get { return datenaissance; }
            set { datenaissance = value; }
        }

        public Personne(string n, string p, DateTime dn)
        {
            nom = n;
            prenom = p;
            datenaissance = dn;
        }

        public virtual void Afficher()
        {
            Console.Out.Write("Nom: " + nom + " Prénom: " + prenom + " Date de naissance: " + datenaissance);
        }
       
    }
}
