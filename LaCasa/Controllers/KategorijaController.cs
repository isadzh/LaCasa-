using Data.EntityModels;
using LaCasa.EF;
using LaCasa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCasa.Controllers
{
    public class KategorijaController : Controller
    {
        private ApplicationDbContext _database;

        public KategorijaController(ApplicationDbContext database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Poruka()
        {
            return View("Poruka");
        }
        public IActionResult Obrisi(int KategorijaID)
        {
            Kategorija k = _database.Kategorije.Find(KategorijaID);

            _database.Remove(k);
            _database.SaveChanges();

            TempData["PorukaInfo"] = "Uspješno ste obrisali kategoriju " + k.Naziv;

            return Redirect("/Kategorija/Poruka");
        }
        public IActionResult Prikaz()
        {
            var kategorije = _database.Kategorije.Select(x => new KategorijaPrikazVM.Row
            {
                KategorijaID = x.KategorijaID,
                Naziv = x.Naziv,
                Opis = x.Opis,
            }).ToList();

            KategorijaPrikazVM k = new KategorijaPrikazVM();
            k.kategorije = kategorije;

            return View(k);
        }
        public IActionResult Dodaj(int KategorijaID)
        {
            KategorijaDodajVM k;
            if (KategorijaID == 0)
            {
                k = new KategorijaDodajVM() { };
            }
            else
            {
                k = _database.Kategorije
                .Where(w => w.KategorijaID == KategorijaID)
                .Select(s => new KategorijaDodajVM
                {
                    KategorijaID = s.KategorijaID,
                    Naziv = s.Naziv,
                    Opis = s.Opis,
                }).Single();
            }

            return View("Dodaj", k);
        }
        public IActionResult Snimi(KategorijaDodajVM k)
        {
            Kategorija kategorija;

            if (k.KategorijaID == 0)
            {
                kategorija = new Kategorija();
                _database.Add(kategorija);
                TempData["PorukaInfo"] = "Uspjesno ste dodali kategoriju " + kategorija.Naziv;
            }
            else
            {
                kategorija = _database.Kategorije.Find(k.KategorijaID);
                TempData["PorukaInfo"] = "Uspjesno ste editovali kategoriju " + kategorija.Naziv;
            }
            kategorija.Naziv = k.Naziv;
            kategorija.Opis = k.Opis;

            _database.SaveChanges();

            return Redirect("/Kategorija/Poruka");

        }
    }
}
