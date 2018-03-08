using CrecheBomPastor.Domain.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrecheBomPastor.MVC.ViewModels
{
    public class CollaboratorViewModel
    {
        [Key]
        public int CollaboratorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome.")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Endereço.")]
        [MaxLength(300, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição.")]
        [MaxLength(300, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Preencha o campo Url da Foto.")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo de Colaborador.")]
        public CollaboratorType CollaboratorType { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }
    }
}