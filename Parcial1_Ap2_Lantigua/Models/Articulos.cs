using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial1_Ap2_Lantigua.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir una descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una Existencia")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un costo")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una valor inventario")]
        public decimal ValorInventario { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0.0m;
            ValorInventario = 0.0m;
        }
    }
}
