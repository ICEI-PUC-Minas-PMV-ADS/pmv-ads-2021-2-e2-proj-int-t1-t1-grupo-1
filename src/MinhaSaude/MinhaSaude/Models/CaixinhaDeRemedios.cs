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

        //Especifica que o campo e obrigatorio e possui uma validação no back-end e no front-end, caso alguém desative o javascript no front-end. Isso envia para o back-end
        [Required(ErrorMessage ="Campo requerido")]
        public String NomeMedicamento{ get; set; }

        public int Quantidade { get; set; }

    }
}
