using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("TipoSaidaId")]
        [Display(Name = "Código do Tipo de Saida")]
        public int TipoSaidaId { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Descricao da Saida do Produto")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
