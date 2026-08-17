using System.ComponentModel.DataAnnotations;

namespace TechChallenge.Models;

public class AlunoEquipe
{
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public int AlunoId { get; set; }
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public Aluno? Aluno { get; set; }
    public int EquipeId { get; set; }
    public Equipe? Equipe { get; set; }
    public DateTime DataEntrada { get; set; } = DateTime.Now;
}