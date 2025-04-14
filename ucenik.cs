using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ucenik
    {
        
        public string Ime { get; set; }
        public int Razred { get; set; }
        public string Prezime { get; set; }

        public string OIB { get; set; }

        public ucenik(string ime, string prezime, int razred, string OIB)
        {
            this.OIB = OIB;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Razred = razred;
        }   
        public override string ToString()
        {
            return $"{this.Prezime}, {this.Ime}, {this.Razred}";
        }
    }
}
