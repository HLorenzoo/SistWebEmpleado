using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class FechaNacimientoAttribute : ValidationAttribute
    {
        public FechaNacimientoAttribute()
        {
            ErrorMessage = "El año debe ser mayor o igual a 2000";
        }
        public override bool IsValid(object value)
        {
            

            int year = ((DateTime)value).Year;
            if (year > 2000)
            {
                return true;
            }
            return false;
        }
    }
}