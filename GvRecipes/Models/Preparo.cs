
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GvRecipes.Models;

[Table("Preparos")]
public class Preparo
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int ReceitaId { get; set; }
    [ForeignKey(nameof(ReceitaId))]
    public Receita Receita { get; set; }

    [Required]
    [StringLength(1000)]
    public string Texto { get; set; }
}
