using MasrafTakipMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace MasrafTakipMVC.Controllers
{
    public class HarcamaController : Controller
    {
        private readonly MasrafTakipContext context;
        public HarcamaController(MasrafTakipContext context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            var harcama = context.Harcamalar.Include(p => p.Personeller).ToList();
            return View(harcama);
        }

        public IActionResult Create()
        {
            ViewBag.PersonelId = context.Personeller
        .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Adi + " " + s.Soyadi }).ToList();


            return View(new Harcama());
        }

        [HttpPost]
        public IActionResult Create(Harcama harcama)
        {
            if (ModelState.IsValid)
            {
                context.Add(harcama);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.PersonelId = context.Personeller
       .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Adi + " " + s.Soyadi }).ToList();
            return View(harcama);
        }


        public IActionResult Edit(int id)
        {
            Harcama harcama = context.Harcamalar.FirstOrDefault(x => x.Id == id);

            ViewBag.PersonelId = context.Personeller
        .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Adi + " " + s.Soyadi }).ToList();
            return View(harcama);

            return View(harcama);
        }

        [HttpPost]
        public IActionResult Edit(Harcama harcama)
        {
            if (ModelState.IsValid)
            {
                context.Update(harcama);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.PersonelId = context.Personeller
        .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Adi + " " + s.Soyadi }).ToList();
            return View(harcama);
        }

        public IActionResult Delete(int id)
        {
            Harcama harcama = context.Harcamalar.FirstOrDefault(x => x.Id == id);

            ViewBag.PersonelId = context.Personeller
        .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Adi + " " + s.Soyadi }).ToList();

            return View(harcama);
        }

        [HttpPost]
        public IActionResult Delete(Harcama harcama)
        {
            context.Remove(harcama);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
