using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThayNailDesign.Models
{
    public class Servico
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Serviço")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [Display(Name = "Tempo de Execução")]
        public int Duracao { get; set; }

    }
}
