using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("Id")]
        [Display(Name = "Código da Entrada do Produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "Data de Entrada")]
        public DateTime DataEntrada { get; set; }

        [Column("QuantidadeEntrada")]
        [Display(Name = "Quantidade da Entrada de Produto")]
        public int QuantidadeEntrada { get; set; }

    }
}
