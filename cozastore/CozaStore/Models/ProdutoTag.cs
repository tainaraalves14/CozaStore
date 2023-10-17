using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("ProdutoTag")]
public class ProdutoTag
{
    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey ("ProdutoId")]
    public Produto Produto { get; set; }

     [Key, Column(Order = 2)]
    public int CategoriaId { get; set; }
    [ForeignKey ("TagId")]
    public Tag Tag { get; set; }
}
