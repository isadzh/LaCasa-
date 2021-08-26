using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCasa.Models
{
    public class KategorijaDodajVM
    {
        public int KategorijaID { get; set; }

        public string Naziv { get; set; }

        public string Opis { get; set; }

        //public virtual ICollection<Jelo> Jela { get; set; }
    }
}
