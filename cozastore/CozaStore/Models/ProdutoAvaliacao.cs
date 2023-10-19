using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("ProdutoAvaliação")]
public class ProdutoAvaliacao
{
    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey ("ProdutoId")]
    public Produto Produto { get; set; }

    [Key, Column(Order = 2)]
    [Display(Name ="Cliente")]
    public int UsuarioId { get; set; }
    [ForeignKey ("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required(ErrorMessage = "Informe o Texto da Avaliação")]
    [StringLength(300, ErrorMessage = "O Texto deve possuir no máximo 300 Caractéries")]
    [Display(Name = "Data da Avaliaçõa")]
    public DateTime AvaliacaoTexto { get; set; } = DateTime.Now;
    public string AvaliacaoData { get; set; }
    [Display(Name = "Nota do Produto")]
    public byte? ProdutoNota { get; set; }
}
