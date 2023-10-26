using Microsoft.AspNetCore.Mvc;

namespace MemotecaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PensamentoController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("oiiii");
    }
}