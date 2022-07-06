using System;
using System.ComponentModel.DataAnnotations;
namespace FIapSmartCity.Models
{
    public class TipoProduto
    {
        public int IdTipo { get; set; }

        //usando Notation para validar dados
        [Required(ErrorMessage = "Descrição Obrigatória")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="A descrição deve ter, no mínimo, 3 e, no máximo, 50 caracteres")]
        [Display(Name ="Descrição:")]
        public String DescricaoTipo { get; set; }
        public bool Comercializado { get; set; }
    }
}
