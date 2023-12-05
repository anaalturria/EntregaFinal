using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("Id")]
        [Display(Name = "Código de Saida")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataSaida")]
        [Display(Name = "Código da Data Saida")]
        public DateTime DataSaida { get; set; }

        [Column("QuantidadeSaida")]
        [Display(Name = "Código da Quantidade de Saida")]
        public int QuantidadeSaida { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("TipoSaidaId")]
        [Display(Name = "Tipo Saida")]
        public int TipoSaidaId { get; set; }
        public TipoSaida? TipoSaida { get; set; }


    }
}
