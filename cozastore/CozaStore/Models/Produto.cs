using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;


[Table("Produto")]
public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [ Required (ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage =  "O Nome deve possuir no máximo 30 caractéries")]
    public string Nome {get; set;}

    [Display(Name = "Descrição Resumida")]
    [ Required (ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage =  "A descrição deve possuir no máximo 300 carctéries")]
    public string DescricaoResumida {get; set;}


    [Display(Name = "Descrição Completa")]
    [StringLength(8000)]
    public string DecricaoCompleta {get; set;}

    [StringLength(10, ErrorMessage = " O SKU deve possur no máximo 10 carctéries")]
    public string SDU { get; set; }

    [Display(Name = "Preço com Desconto")]
    [Column(TypeName ="decimal(8,2)")]
    [Required(ErrorMessage = "Informe o Preço de Venda")]
    public decimal PrecoDesconto { get; set; }

}

