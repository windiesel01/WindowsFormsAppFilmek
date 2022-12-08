using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFilmek
{
    internal class Filmek
    {
        int id;
        string cim;
        int megjelenes; 
        string hossz;
        double ertekeles;
        string kategoria;

        public int Id { get => id; set => id = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Megjelenes { get => megjelenes; set => megjelenes = value; }
        public string Hossz { get => hossz; set => hossz = value; }
        public double Ertekeles { get => ertekeles; set => ertekeles = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }

        public Filmek(int id, string cim, int megjelenes, string hossz, double ertekeles, string kategoria)
        {
            Id = id;
            Cim = cim;
            Megjelenes = megjelenes;
            Hossz = hossz;
            Ertekeles = ertekeles;
            Kategoria = kategoria;
        }

        public override string ToString()
        {
            return $"{cim}  [{megjelenes}] - ({hossz}) - {ertekeles}/10 - {kategoria}";
        }
    }
}
