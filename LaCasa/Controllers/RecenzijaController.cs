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
    public class RecenzijaController : Controller
    {
        private ApplicationDbContext _database;

        public RecenzijaController(ApplicationDbContext database)
        {
            _database = database;
        }
        public IActionResult Prikaz(int RestoranID)
        {

            var r = _database.Recenzije.Where(x => x.RestoranID == RestoranID)
                .Select(x => new RecenzijaPrikazVM
                {
                    RecenzijaID = x.RecenzijaID,
                    Opis = x.Opis,
                    Ocjena = x.Ocjena
                })
                .ToList();

            TempData["RestoranID"] = RestoranID;

            return View(r);
        }

        public IActionResult Obrisi(int RecenzijaID)
        {
            Recenzija r = _database.Recenzije.Find(RecenzijaID);

            _database.Remove(r);
            _database.SaveChanges();


            return Redirect("/Recenzija/Prikaz?RestoranID=" + r.RestoranID);
        }

        public IActionResult Dodaj(int RestoranID)
        {
            RecenzijaDodajVM r = new RecenzijaDodajVM();
            r.RestoranID = RestoranID;

            return View("Dodaj", r);
        }

        public IActionResult Snimi(RecenzijaDodajVM rec)
        {
            Recenzija r = new Recenzija();
            r.RestoranID = rec.RestoranID;
            r.Opis = rec.Opis;
            r.Ocjena = rec.Ocjena;

            _database.Add(r);
            _database.SaveChanges();

            return Redirect("/Recenzija/Prikaz?RestoranID=" + rec.RestoranID);
        }
    }   
}
