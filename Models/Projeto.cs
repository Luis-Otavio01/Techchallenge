using System.ComponentModel.DataAnnotations;

namespace TechChallenge.Models;

public class Projeto
{
    public int Id { get; set; }
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string Nome { get; set; }
     [Required (ErrorMessage = "O campo ID é obrigatorio")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string? Descricao { get; set; }
    [DataType(DataType.Date)] public DateTime DataInicio { get; set; }
    [DataType(DataType.Date)] public DateTime? DataFim { get; set; }
    [Range(0,1000)] public int Pontuacao { get; set; }
    public int ProfessorId { get; set; }
    public int CategoriaId { get; set; }
    public int EquipeId { get; set; }
    public Professor? Professor { get; set; }
    public Categoria? Categoria { get; set; }
    public Equipe? Equipe { get; set; }
}