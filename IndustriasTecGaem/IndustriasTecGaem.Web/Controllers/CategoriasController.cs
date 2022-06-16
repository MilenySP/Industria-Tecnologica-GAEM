using IndustriasTecGaem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndustriasTecGaem.Web.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }
        // GET: Categoria
        public ActionResult Index()
        {
            var ListadeCategorias = _categoriasBL.ObtenerCategorias();
            return View(ListadeCategorias);
        }

       public ActionResult Crear()
        {
            var nuevaCategoria = new Categorias();
            return View(nuevaCategoria);
        }
        [HttpPost]//para que habra las paginas
        public ActionResult Crear(Categorias categorias)
        {
           _categoriasBL.GuardarCategorias(categorias);
            return RedirectToAction("Index");
        }
        [HttpPost]//para que habra las paginas
        public ActionResult Editar(Categorias categoria)
        {
            _categoriasBL.ObtenerCategorias();
            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _categoriasBL.ObtenerCategorias();
            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _categoriasBL.ObtenerCategorias();
            return View(producto);
        }

        [HttpPost]//para que habra las paginas
        public ActionResult Eliminar(Categorias producto)
        {
            _categoriasBL.EliminarCategoria(producto.Id);
            return RedirectToAction("Index");
        }

    }
}