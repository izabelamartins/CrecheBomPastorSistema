using System;
using System.ComponentModel.DataAnnotations;

namespace CrecheBomPastor.MVC.ViewModels
{
    public class EventPhotoViewModel
    {
        [Key]
        public int PhotoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Url da Foto.")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string PhotoUrl { get; set; }

        public int EventId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }

        public virtual EventViewModel Event { get; set; }
    }
}