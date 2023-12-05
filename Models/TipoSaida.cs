using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo de Saida")]
        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Descricao da Saida do Produto")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
