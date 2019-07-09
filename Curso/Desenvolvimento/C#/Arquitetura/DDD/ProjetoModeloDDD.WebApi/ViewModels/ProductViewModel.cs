using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.WebApi.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {0} caracteres")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Value { get; set; }

        public bool IsAvailable { get; set; }
        public int ClientId { get; set; }

        public virtual ClientViewModel Client { get; set; }
    }
}
