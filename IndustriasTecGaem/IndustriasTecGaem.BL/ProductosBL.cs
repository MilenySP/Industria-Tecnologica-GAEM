using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustriasTecGaem.BL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public List<Producto> ListaDeProductos { get; set; }
        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaDeProductos = new List<Producto>();

        }

        public List<Producto> ObtenerProductos()
        {
            ListaDeProductos = _contexto.Productos.ToList();
            return ListaDeProductos;
        }

        public void GuardarProducto(Producto producto)
        {
            if (producto.Id == 0)
            {
                _contexto.Productos.Add(producto);
            }else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;
            }

            _contexto.SaveChanges();
        }
         public Producto ObtenerProductos (int id)
        {
            var producto = _contexto.Productos.Find(id);
            return producto;
        }

        public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }
    }
}
