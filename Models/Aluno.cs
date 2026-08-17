using System.ComponentModel.DataAnnotations;

namespace TechChallenge;

public class Aluno
{
    [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public int Id { get; set; } // Primary Key
    [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string Nome { get; set; }
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string Email { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }
}
