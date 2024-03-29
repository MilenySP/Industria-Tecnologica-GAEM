﻿using IndustriasTecGaem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndustriasTecGaem.WebAdmin.Controllers
{
    [Authorize]
    public class CategoriaController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriaController()
        {
            _categoriasBL = new CategoriasBL();
        }
        // GET: Categoria
        public ActionResult Index()
        {

            var ListadeCategorias = _categoriasBL.ObtenerCategorias();

            return View(ListadeCategorias);
        }//crar categorias------------------------------------------------
        public ActionResult Crear()
        {
            var nuevaCategoria = new Categorias();
            return View(nuevaCategoria);
        }
        [HttpPost]//para que habra las paginas
        public ActionResult Crear(Categorias categoria)
        {
            if (ModelState.IsValid)
            {
                if (categoria.Descripcion != categoria.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La descripcion no debe de contener espacio al inicio o al final");
                    return View(categoria);
                }
                _categoriasBL.GuardarCategorias(categoria);
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Editar(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }
        [HttpPost]//para que habra las paginas
        public ActionResult Editar(Categorias categoria)
        {
            if (ModelState.IsValid)
            {
                if (categoria.Descripcion != categoria.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La descripcion no debe de contener espacio al inicio o al final");
                    return View(categoria);
                }
                _categoriasBL.GuardarCategorias(categoria);
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Detalle(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }

        public ActionResult Eliminar(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }

        [HttpPost]//para que habra las paginas
        public ActionResult Eliminar(Categorias producto)
        {
            _categoriasBL.EliminarCategoria(producto.Id);
            return RedirectToAction("Index");
        }

    }
}