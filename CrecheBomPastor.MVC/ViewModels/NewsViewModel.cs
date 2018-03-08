using System;
using System.ComponentModel.DataAnnotations;

namespace CrecheBomPastor.MVC.ViewModels
{
    public class NewsViewModel
    {
        [Key]
        public int NewsId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Título.")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição.")]
        [MaxLength(5000, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Preencha o campo Url da Foto.")]
        [MaxLength(5000, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres.")]
        public string PhotoUrl { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }
    }
}