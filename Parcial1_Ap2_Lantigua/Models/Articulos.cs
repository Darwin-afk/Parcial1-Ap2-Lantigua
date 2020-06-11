using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Parcial1_Ap2_Lantigua.Validaciones;

namespace Parcial1_Ap2_Lantigua.Models
{
    public class Articulos
    {
        [Key]
        [IdValidacion]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir una descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una Existencia")]
        [ExistenciaValidacion]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un costo")]
        [CostoValidacion]
        public decimal Costo { get; set; }

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
