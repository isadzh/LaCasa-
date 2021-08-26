using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCasa.Models
{
    public class KategorijaPrikazVM
    {
        public class Row
        {
            public int KategorijaID { get; set; }
            public string Naziv { get; set; }
            public string Opis { get; set; }
        }
        public List<Row> kategorije;        
    }
}
