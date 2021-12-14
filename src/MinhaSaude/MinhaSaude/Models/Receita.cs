using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaSaude.Models
{
    public class Receita
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [NotMapped]
        [Display(Name = "Selecione o arquivo")]
        public IFormFile ReceitaArquivo { get; set; }

        public string NomeArquivo { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Administrador Usuario { get; set; }



    }
}
