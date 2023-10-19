using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Carrinho")]
public class Carrinho
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Required]
    [Display(Name = "Cliente")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public string Usuario { get; set; }

    [Display(Name = "Data de Cadastro")]
    public DateTime DataCadastro { get; set; } = DateTime.Now;

    [Display(Name = "Data de Modificação")]
    public DateTime DataModificacao{ get; set; } = DateTime.Now;

}
