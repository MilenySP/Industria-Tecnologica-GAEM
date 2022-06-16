using System;
using System.Collections.Generic;
using System.Linq;
/*using System.Text;
using System.Threading.Tasks;*/

namespace IndustriasTecGaem.BL
{
    public class CategoriasBL
    {
        Contexto _contexto;

        public List<Categorias> ListadeCategorias { get; set; }

        public CategoriasBL()
        {
            _contexto = new Contexto();
            ListadeCategorias = new List<Categorias>();
        }

        public List<Categorias> ObtenerCategorias()
        {
            ListadeCategorias = _contexto.Categorias.ToList();
            return ListadeCategorias;
        }

        public void GuardarCategorias(Categorias categorias)
        {
            if (categorias.Id == 0)
            {
                _contexto.Categorias.Add(categorias);
            }
            else
            {
                var categoriaExistente = _contexto.Categorias.Find(categorias.Id);
                categoriaExistente.Descripcion = categorias.Descripcion;
            }

            _contexto.SaveChanges();
        }

        public Categorias ObtenerCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            return categoria;
        }
        public void EliminarCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();
        }
    }
}
