using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCasa.Models
{
    public class RestoranDodajVM
    {
        public int ID { get; set; }
        public string RegistarskiBroj { get; set; }
        public string Naziv{ get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string RadnoVrijeme { get; set; }
        public int TipKuhinjeID { get; set; }
       // public int RecenzijaID { get; set; }

        public List<SelectListItem> kuhinje { get; set; }
    }
}
