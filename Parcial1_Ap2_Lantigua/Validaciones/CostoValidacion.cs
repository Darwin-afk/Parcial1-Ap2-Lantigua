using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Lantigua.Validaciones
{
    public class CostoValidacion : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                decimal cantidad = Convert.ToDecimal(value);

                if (cantidad >= 1m)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("El costo debe mayor o igual a 1");

            }
            return new ValidationResult("Debes poner un costo");
        }
    }
}

