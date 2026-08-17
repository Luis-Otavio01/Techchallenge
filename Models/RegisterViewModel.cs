using System.ComponentModel.DataAnnotations;

namespace TechChallenge;

public class RegisterViewModel
{
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string Nome { get; set; }
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string Email { get; set; }
    [Required][DataType(DataType.Password)] public string Senha { get; set; }
    [Compare("Senha")] public string ConfirmarSenha { get; set; }
    [Required] public string Role { get; set; } // Aluno ou Professor
}
