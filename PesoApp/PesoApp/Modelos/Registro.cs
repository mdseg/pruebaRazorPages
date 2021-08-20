using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PesoApp.Modelos
{
    public class Registro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creación")]
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "El peso es obligatorio")]
        public double Peso { get; set; }
        [Required(ErrorMessage = "La cintura es obligatorio")]
        public double Cintura { get; set; }
        [Required(ErrorMessage = "La cadera es obligatorio")]
        public double Cadera { get; set; }

        [Required(ErrorMessage = "La medida de la pierna es obligatorio")]
        public double Pierna { get; set; }
    }
}
