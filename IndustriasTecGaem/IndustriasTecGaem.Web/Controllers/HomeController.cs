using IndustriasTecGaem.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndustriasTecGaem.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listaDeProductos = productosBL.ObtenerProductosActivos();

            ViewBag.admiWebsiteUrl = ConfigurationManager.AppSettings["admiWebsiteUrl"];
            return View(listaDeProductos);
        }
    }
}