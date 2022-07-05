using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home


        public ActionResult Index()
        {
            return View(); //retorna uma view
        }

        public ActionResult Contatos()
        {
            return View(); //retorna uma view
        }

        /*
         //comandos teste
        public string Index()
        {
            return "primeiro index";
        }

        public string Teste()
        {
            return "primeiro teste";
        }
        */


        /*
          //comandos originais
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}