using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustriasTecGaem.BL
{
    public class Categorias
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la categoria")]
        public string Descripcion { get; set; }
    }
}
