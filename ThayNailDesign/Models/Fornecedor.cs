using System;
using System.ComponentModel.DataAnnotations;


namespace ThayNailDesign.Models
{
    public class Fornecedor
    {
        [Display(Name = "#")]        
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Digite o nome do fornecedor!")]
        public string Nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Digite o telefone de contato do fornecedor")]
        public string Telefone { get; set; }

        [Display(Name = "Prazo de entrega (dias)")]
        [Required(ErrorMessage = "Informe o prazo de entrega deste fornecedor")]
        public int Prazo { get; set; }
    }
}
