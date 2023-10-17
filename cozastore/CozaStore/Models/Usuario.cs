using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CozaStore.Models;

[Table("Usuario")]
public class Usuario
{
    [Key]
    public string UsuarioId { get; set; }
    [ForeignKey ("UsuarioId")]
    public IdentityUser ContaUsuario { get; set; }

    [ Required (ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage =  "O Nome deve possuir no máximo 60 caractéries")]
    public string Nome {get; set;}

    [DataType(DataType.Date)]
    [Display (Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Informe a Data de Nascimento")]
    public DateTime DataNascimento { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

}
