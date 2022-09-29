using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Form.API.Data.Entities
{
    public class UnicForm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} sólo puede contener {1} caracteres de longitud.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Apellidos")]
        [MaxLength(100, ErrorMessage = "El campo {0} sólo puede contener {1} caracteres de longitud.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Nro. Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} sólo puede contener {1} caracteres de longitud.")]
        public string DocumentNumber { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "El Email ingresado no es válido.")]
        [StringLength(100, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres.", MinimumLength = 6)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Nro. Celular")]
        [MaxLength(20, ErrorMessage = "El campo {0} sólo puede contener {1} caracteres de longitud.")]
        public string CellPhone { get; set; }

        public DateTime? CreationDate { get; set; }
    }
}
