using SistemaWebEmpleado.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace SistemaWebEmpleado.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        //(Id- Nombre-Apellido-DNI-Legajo-FechaNacimiento y Título)
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]

        public string Apellido { get; set; }

        public string DNI { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [RegularExpression("^AA[0-9]{5}$")]
        public string Legajo { get; set; }

        [FechaNacimientoAttribute]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]

        public string Título { get; set; }

    }
}