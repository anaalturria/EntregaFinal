using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código do Usuario")]
        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do Usuario")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email do Usuario")]
        public string EmailUsuario { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha do Usuario")]
        public string Senha { get; set; } = string.Empty;
    }
}
