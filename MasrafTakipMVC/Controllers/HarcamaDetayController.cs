using MasrafTakipMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace MasrafTakipMVC.Controllers
{
    public class HarcamaDetayController : Controller
    {
        private readonly MasrafTakipContext context;
        public HarcamaDetayController(MasrafTakipContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var harcamaDetaylari = context.HarcamaDetaylari.Include(s => s.Harcama).Include(s => s.HarcamaTipleri).ToList();
            return View(harcamaDetaylari);
        }

        public IActionResult Create()
        {

            ViewBag.HarcamaId = new SelectList(context.Harcamalar, "Id", "Id");

            ViewBag.HarcamaTipId = context.HarcamaTipleri
             .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Baslik }).ToList();

            return View(new HarcamaDetay());
        }

        [HttpPost]
        public IActionResult Create(HarcamaDetay harcamaDetaylari)
        {
            if (ModelState.IsValid)
            {
                var harcamaDetay = new HarcamaDetay
                {
                    Tutar = harcamaDetaylari.Tutar,
                    HarcamaId = harcamaDetaylari.HarcamaId,
                    HarcamaTipiId = harcamaDetaylari.HarcamaTipiId,
                    Aciklama = harcamaDetaylari.Aciklama
                };

                context.Add(harcamaDetay);
                context.SaveChanges();



                //context.Add(harcamaDetaylari);
                //context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(harcamaDetaylari);
        }

        public IActionResult Details(int id)
        {
            HarcamaDetay harcamaDetay = context.HarcamaDetaylari.FirstOrDefault(x => x.Id == id);


            //ViewBag.HarcamaId = new SelectList(context.Harcamalar, "Id", "Id");

           


            return View(harcamaDetay);
        }

        public IActionResult Delete(int id)
        {
            HarcamaDetay harcamaDetay = context.HarcamaDetaylari.FirstOrDefault(x => x.Id == id);

            return View(harcamaDetay);
        }

        [HttpPost]
        public IActionResult Delete(HarcamaDetay harcamaDetay)
        {
            context.Remove(harcamaDetay);
            context.SaveChanges();

            return RedirectToAction("Index");
        }



    }
}
