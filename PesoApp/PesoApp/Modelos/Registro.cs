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
        public float Peso { get; set; }
        [Required(ErrorMessage = "La cintura es obligatorio")]
        public float Cintura { get; set; }
        [Required(ErrorMessage = "La cadera es obligatorio")]
        public float Cadera { get; set; }

    }
}
