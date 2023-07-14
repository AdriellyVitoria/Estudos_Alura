using Microsoft.AspNetCore.Authorization;

namespace UsuarioApi.Authorization;

public class IdadeMinima : IAuthorizationRequirement
{

    public IdadeMinima(int idade)
    {

        idade = idade;
    }

    public int idade { get; set; }
}
