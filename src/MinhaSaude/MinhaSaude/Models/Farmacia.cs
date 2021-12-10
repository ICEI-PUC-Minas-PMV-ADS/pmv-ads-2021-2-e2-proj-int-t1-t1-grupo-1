using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaSaude.Models
{
    [Table("Farmacias")]
    public class Farmacia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Display(Name = "Nome da Farmácia")]
        [Required(ErrorMessage = "Obrigatório informar o nome da farmácia!")]
        public string NomeFarmacia { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil!")]
        public Perfil Perfil { get; set; }

    }
    //public enum Perfil
    //{
    //    Atendente,
    //    [Display(Name = "Farmacêutico")]
    //    Farmaceutico
    //}
}
