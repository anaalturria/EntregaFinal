using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("FornecedorId")]
        [Display(Name = "Código do Fornecedor")]
        public int FornecedorId { get; set; }

        [Column("FornecedorNome")]
        [Display(Name = "Nome do Fornecedor")]
        public string FornecedorNome { get; set; } = string.Empty;

        [Column("FornecedorEmail")]
        [Display(Name = "Email do Fornecedor")]
        public string FornecedorEmail { get; set; } = string.Empty;

        [Column("FornecedorCnpj")]
        [Display(Name = "Cnpj do Fornecedor")]
        public string FornecedorCnpj { get; set; } = string.Empty;
    }
}
