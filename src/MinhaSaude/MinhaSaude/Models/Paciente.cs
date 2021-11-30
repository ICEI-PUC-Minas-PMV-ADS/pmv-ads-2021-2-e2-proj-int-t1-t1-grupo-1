using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaSaude.Models
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o cpf!")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}
