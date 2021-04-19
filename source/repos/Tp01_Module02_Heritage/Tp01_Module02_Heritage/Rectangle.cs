using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp01_Module02_Heritage
{
    class Rectangle : Forme
    {
        public  int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double Aire => Largeur * Longueur;
        public override double Perimetre => 2 * Largeur + 2 * Longueur;

        public override string ToString()
        {
            return $"Rectangle de longueur={Longueur} et largeur={Largeur}" + Environment.NewLine + base.ToString();
        }

    }
}
