using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCasa.EntityModels
{
    public class Restoran
    {
        public int RestoranID { get; set; }
        public string RegistarskiBroj { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string RadnoVrijeme { get; set; }
        public string Brojtelefona { get; set; }
        public int TipKuhinjeID { get; set; }
        public TipKuhinje TipKuhinje { get; set; }

    }
}
