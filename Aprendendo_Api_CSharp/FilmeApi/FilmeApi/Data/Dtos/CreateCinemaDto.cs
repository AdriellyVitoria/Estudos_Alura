using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Data.Dtos;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O Campo de nome é obrigatório.")]
    public string Nome { get; set; }
    public int EndrecoId { get; set; }
}
