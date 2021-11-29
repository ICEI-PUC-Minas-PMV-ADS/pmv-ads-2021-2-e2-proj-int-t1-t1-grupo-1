using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MInhaSaude.Models
{
    [Table("CaixinhaRem")]
    public class CaixinhaRemedio
    {
        [Key]
        public int Id { get; set; }



        [Required(ErrorMessage = "Campo Obrigatório")]
        public nomeRemedio nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public TipoRemedio Tipo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Quantidade { get; set; }

    }
    public enum TipoRemedio
    {
        Caixa,
        Cartela,
        Unidade,
    }
    public enum nomeRemedio
    {
        Paracetamol,
        Ibuprofeno,
        Novalgina,
    }
}
