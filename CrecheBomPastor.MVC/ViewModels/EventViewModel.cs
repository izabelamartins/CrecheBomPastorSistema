using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrecheBomPastor.MVC.ViewModels
{
    public class EventViewModel
    {
        [Key]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Título.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(500, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição.")]
        [MaxLength(1000, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data do Evento.")]
        [DataType(DataType.DateTime, ErrorMessage = "Preencha uma data válida.")]
        public DateTime EventDate { get; set; }

        public virtual IEnumerable<EventPhotoViewModel> EventPhotos { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }
    }
}