using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yazokulum.com.Models.Entity;







namespace yazokulum.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkında()
        {


            return View();
        }


        yazokuluEntities db = new yazokuluEntities();

        public ActionResult yazokullari()
        {
            var deger = db.Sayfa1.ToList();
            
            return View(deger);
        }

        public ActionResult iletisim()
        {

            return View();
        }

        public ActionResult bagisciol()
        {


            return View();
        }

    }
}