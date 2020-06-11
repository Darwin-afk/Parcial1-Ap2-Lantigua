using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Lantigua.Validaciones
{
    public class ExistenciaValidacion : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int id = Convert.ToInt32(value);

                if (id >= 1)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("La Existencia debe ser mayor o igual a uno");
            }
            return new ValidationResult("Debes poner una Existencia");
        }
    }
}
