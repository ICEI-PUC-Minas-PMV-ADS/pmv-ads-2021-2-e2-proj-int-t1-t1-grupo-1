using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaSaude.Models
{
    //Cria tabela sem precisar de Creat table
    [Table("CaixinhaDeRemedios")]
    public class CaixinhaDeRemedios
    {
        //o meu ID é uma chave primária
       [Key]
        public int Id { get; set; }

        [Display(Name = "Medicamento")]
        [Required(ErrorMessage = "É necessário informar o medicamento!")]
        public int MedicamentoId { get; set; }

        [ForeignKey("MedicamentoId")]
        public Medicamento Medicamento { get; set; }

        public int Quantidade { get; set; }
    }
}
