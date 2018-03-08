using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CrecheBomPastor.Domain.Entities;

namespace CrecheBomPastor.MVC.ViewModels
{
    public class FeedbackViewModel
    {
        [Key]
        public int FeedbackId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome.")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Assunto.")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo do Assunto.")]
        public SubjectType SubjectType { get; set; }

        [Required(ErrorMessage = "Preencha o campo Assunto.")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Message { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }
    }
}