using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller")]
    public class UsuarioController
    {
        [HttpPost]
        public IActionResult CadastraUsuario 
            (CreateUsuarioDto dto)
        {
            throw new NotImplementedException();

        }
    }
}
