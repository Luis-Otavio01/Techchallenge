using System.ComponentModel.DataAnnotations;
using TechChallenge.Models;

namespace TechChallenge;

public class Professor
{
    public int Id { get; set; }
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string Nome { get; set; }
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string Email { get; set; }
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string Especialidade { get; set; }
    [DataType(DataType.Date)] public DateTime DataContratacao { get; set; }
    public bool Ativo { get; set; } = true;
    public ICollection<Projeto>? Projetos { get; set; } = new List<Projeto>();
}