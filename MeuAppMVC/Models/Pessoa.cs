using System.ComponentModel.DataAnnotations;

public class Pessoa
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A idade é obrigatória")]
    [Range(0, 150, ErrorMessage = "A idade deve estar entre 0 e 150")]
    public int Idade { get; set; }
}