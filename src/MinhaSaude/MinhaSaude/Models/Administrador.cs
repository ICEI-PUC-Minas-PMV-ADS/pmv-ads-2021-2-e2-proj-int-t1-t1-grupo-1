using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaSaude.Models
{
    [Table("Administrador")]
    public class Administrador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o E-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome da Farmácia!")]
        [Display(Name = "Nome da Farmácia")]
        public string NomeFarmacia { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Cliente,
        [Display(Name = "Funcionário Farmácia")]
        Funcionario,
        Admin
    }
}
