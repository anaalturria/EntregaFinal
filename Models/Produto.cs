using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código do Produto")]
        public int Id { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; } = string.Empty;

        [Column("QuantidadeEstoque")]
        [Display(Name = "Estoque do Produto")]
        public int QuantidadeEstoque { get; set; }


        [ForeignKey("TipoProdutoId")]
        [Display(Name = "Tipo de Produto")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
