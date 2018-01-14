using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Polymorphisme
{
    class Employe : Personne
    {

        private double salaire;

        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public Employe(string n, string p, DateTime dn, double s)
            : base(n, p, dn)
        {
            salaire = s;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Out.WriteLine(" Salaire: " + salaire);
        }
        
    }
}
