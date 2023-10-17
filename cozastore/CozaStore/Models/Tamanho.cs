using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;


[Table("Tamanho")]
public class Tamanho
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id {get; set;}

    [ Required (ErrorMessage = "Informe a Sigla ")]
    [StringLength(5, ErrorMessage =  "O Código de cor deve possuir no máximo 5 caractéries")]
    public string CodigoHexa {get; set;}

    [ Required (ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage =  "O Nome deve possuir no máximo 30 caractéries")]
    public string Nome {get; set;}

    
}
