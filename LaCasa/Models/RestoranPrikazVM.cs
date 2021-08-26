using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCasa.Models
{
    public class RestoranPrikazVM
    {
        public class Row
        {
            public int RestoranID { get; set; }
            public string RegistarskiBroj { get; set; }
            public string Adresa { get; set; }
            public string Naziv { get; set; }
            public string RadnoVrijeme { get; set; }
            public string Brojtelefona { get; set; }
            public string Recenzije { get; set; }
            public string TipKuhinje { get; set; }
        }
        public List<Row> restorani;
        public string q;
    }
}
