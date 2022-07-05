using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustriasTecGaem.BL
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del Cliente")]
        [MinLength(3, ErrorMessage = "Ingrese minimo 3 Caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del Cliente")]
        [MinLength(8, ErrorMessage = "El numero de telefono debe de ser de 8 caracteres")]
        [MaxLength(8, ErrorMessage = "El numero de telefono debe de ser de 8 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese la Direccion")]
        [MinLength(3, ErrorMessage = "Ingrese minimo 3 Caracteres")]
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
