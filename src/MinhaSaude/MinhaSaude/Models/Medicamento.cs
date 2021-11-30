using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaSaude.Models
{
    public class Medicamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="É necessário informar o nome do medicamento!")]
        public string Nome { get; set; }

        [Display(Name ="Laboratório")]
        [Required(ErrorMessage ="É necessário informar o Laboratório!")]
        public string Laboratorio { get; set; }

        [Display(Name ="Tipo")]
        [Required(ErrorMessage ="É necessário informar o tipo do medicamento!")]
        public string Tipo { get; set; }

        [Display(Name ="Princípio Ativo")]
        [Required(ErrorMessage ="É necessário informar o Princípio Ativo!")]
        public string PrincAtivo { get; set; }

        [Required(ErrorMessage ="É necessário informar a dosagem do princípio ativo!")]
        public string Dosagem { get; set; }
    }
 }
