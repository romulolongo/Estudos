using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.WebApi.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int ClientId { get; set; }
        
        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(150,ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(5,ErrorMessage ="Minimo {0} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress( ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {0} caracteres")]
        public string Email { get; set; }
        public DateTime DateRegister { get; set; }
        public bool IsActive { get; set; }
        
        public ICollection<ProductViewModel> Products { get; set; }
    }
}
