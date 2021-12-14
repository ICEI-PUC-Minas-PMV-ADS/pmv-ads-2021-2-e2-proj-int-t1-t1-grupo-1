using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaSaude.Models
{
    [Table("Tratamentos")]
    public class Tratamento
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Medicamento")]
        [Required(ErrorMessage ="É necessário informar o medicamento!")]
        public int MedicamentoId { get; set; }

        [ForeignKey("MedicamentoId")]
        public Medicamento Medicamento { get; set; }

        [Display(Name = "Anotações")]
        public string Anotacoes { get; set; }

        [Display(Name = "Início")]
        [Required(ErrorMessage ="É necessário informar a data de início!")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Duração (em dias)")]
        [Required(ErrorMessage = "É necessário informar a duracao do tratamento!")]
        public int Duracao { get; set; }

        [Display(Name = "Frequência de uso (vezes por dia)")]
        [Required(ErrorMessage = "É necessário informar a frequência de uso!")]
        public int FrequenciaUso { get; set; }
    }
}
