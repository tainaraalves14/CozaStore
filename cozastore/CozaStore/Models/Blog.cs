using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;


[Table("Blog")]
public class Blog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 30 caractéries")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe o Texto")]
    [StringLength(600, ErrorMessage = "O Texto de cor deve possuir no máximo 600 caractéries")]
    public string Texto { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    
    [Required]
    [Display(Name = "Escritor")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public string Usuario { get; set; }

    [Display(Name = "Data de Cadastro")]
    public DateTime DataCadastro { get; set; } = DateTime.Now;

}
