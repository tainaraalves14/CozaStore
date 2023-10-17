using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;


[Table("Cor")]
public class Cor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id {get; set;}

    [ Required (ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage =  "O Nome deve possuir no máximo 30 caractéries")]
    public string Nome {get; set;}

    [ Required (ErrorMessage = "Informe o Nome")]
     [Display(Name = "Código da cor")]
    [StringLength(7, ErrorMessage =  "O Código de cor deve possuir no máximo 7 caractéries")]
    public string CodigoHexa {get; set;}
}
