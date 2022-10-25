using BackEnd_ejemplo1.Models;
using BackEnd_ejemplo1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_ejemplo1.Controllers
{
    public class CalculosBasController : Controller
    {
        // GET: CalculosBas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma(string Num1, string Num2) 
        {
            int res = Convert.ToInt16(Num1) + Convert.ToInt16(Num2);
            ViewBag.Res = Convert.ToString(res);
            return View();
        }

        public ActionResult Operas()
        {
            OperasBas op=new OperasBas();
            return View(op);
        }
        [HttpPost]//Llama a las dos vistas OperasBas

        public ActionResult Operas(OperasBas op)
        {
            op.Suma();
            ViewBag.Res = op.Res;
            return View(op);
        }

        public ActionResult MuestraPelicula() 
        {
            var peliculaservice = new PeliculasService();
            var model = peliculaservice.ObtenerPelicula();
            return View(model);
        }

        public ActionResult MuestraPelicula2()
        {
            var peliculaservice = new PeliculasService();
            var model = peliculaservice.ObtenerPelicula();
            return View(model);
        }

        public ActionResult temporal() 
        {
            //var alumno1 = new Alumno() { Nombre = "Juan", Edad = 23 };
            //return Json(alumno1, JsonRequestBehavior.AllowGet);     //Content("<h1> hola Mundo </h1>");
            return Redirect("https://google.com.mx");
        }

        public RedirectToRouteResult temporal2() 
        {
            return RedirectToAction("index","Home");
        }
    }
}