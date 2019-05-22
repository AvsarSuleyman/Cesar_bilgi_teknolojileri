using otomativ_tamirhane.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otomativ_tamirhane.Controllers
{
    public class MusteriKayitController : Controller
    {
      

        // GET: musteri_kayit
        public ActionResult Index()
        {
            FormDB vt = new FormDB();
            var listele = vt.yeni_kayit.ToList();
            return View(listele);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(yeni_kayit yeniKayit)
        {
             FormDB vt = new FormDB();

            vt.yeni_kayit.Add(yeniKayit);

            vt.SaveChanges();



            return View();
        }
    }
}