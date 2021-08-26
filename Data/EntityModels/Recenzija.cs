using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCasa.EntityModels
{
    public class Recenzija
    {
        public int RecenzijaID { get; set; }
        public string Opis { get; set; }
        public int Ocjena { get; set; }
        public int RestoranID { get; set; }
        public Restoran Restoran { get; set; }

    }
}
