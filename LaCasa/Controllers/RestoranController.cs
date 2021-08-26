using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaCasa.EF;
using LaCasa.EntityModels;
using LaCasa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LaCasa.Controllers
{
    public class RestoranController : Controller
    {
        private ApplicationDbContext _database;

        public RestoranController(ApplicationDbContext database)
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
        public IActionResult Obrisi(int RestoranID)
        {
            Restoran r = _database.Restorani.Find(RestoranID);

            var recenzijeZaBrisanje = _database.Recenzije.Where(s => s.RestoranID == RestoranID).ToList();

            _database.RemoveRange(recenzijeZaBrisanje);
            _database.SaveChanges();

            _database.Remove(r);
            _database.SaveChanges();

            TempData["PorukaInfo"] = "Uspješno ste obrisali restoran " + r.Naziv;

            return Redirect("/Restoran/Poruka");
        }
        public IActionResult Prikaz(string q)
        {
            var restorani = _database.Restorani
                .Where(s=>q==null || s.Naziv.StartsWith(q))
                .Select(x => new RestoranPrikazVM.Row
            {
                RestoranID = x.RestoranID,
                RegistarskiBroj = x.RegistarskiBroj,
                Adresa = x.Adresa,
                Naziv = x.Naziv,
                RadnoVrijeme = x.RadnoVrijeme,
                Brojtelefona = x.Brojtelefona,
                TipKuhinje = x.TipKuhinje.Naziv
            }).ToList();

            RestoranPrikazVM r = new RestoranPrikazVM();
            r.restorani = restorani;

            return View(r);
        }
        public IActionResult Dodaj(int RestoranID)
        {
            List<SelectListItem> kuhinje = _database.TipKuhinje
                .OrderBy(a => a.Naziv)
                .Select(a => new SelectListItem
                {

                    Value = a.TipKuhinjeID.ToString(),
                    Text = a.Naziv

                }).ToList();

            RestoranDodajVM r;
            if (RestoranID == 0)
            {
                r = new RestoranDodajVM() { };
            }
            else
            {
                r = _database.Restorani
                .Where(w => w.RestoranID == RestoranID)
                .Select(s => new RestoranDodajVM
                {
                    ID = s.RestoranID,
                    RegistarskiBroj = s.RegistarskiBroj,
                    Naziv = s.Naziv,
                    Adresa = s.Adresa,
                    RadnoVrijeme = s.RadnoVrijeme,
                    BrojTelefona = s.Brojtelefona,
                    TipKuhinjeID = s.TipKuhinjeID
                }).Single();
            }

            r.kuhinje = kuhinje;

            return View("Dodaj", r);
        }
        public IActionResult Snimi(RestoranDodajVM r)
        {
            Restoran restoran;

            if (r.ID == 0)
            {
                restoran = new Restoran();
                _database.Add(restoran);
                TempData["PorukaInfo"] = "Uspjesno ste dodali restoran " + restoran.Naziv;
            }
            else
            {
                restoran = _database.Restorani.Find(r.ID);
                TempData["PorukaInfo"] = "Uspjesno ste editovali restoran " + restoran.Naziv;

            }
            restoran.RegistarskiBroj = r.RegistarskiBroj;
            restoran.Naziv = r.Naziv;
            restoran.Adresa = r.Adresa;
            restoran.Brojtelefona = r.BrojTelefona;
            restoran.RadnoVrijeme = r.RadnoVrijeme;
            restoran.TipKuhinjeID = r.TipKuhinjeID;

            _database.SaveChanges();

            return Redirect("/Restoran/Poruka");

        }
    }
}
