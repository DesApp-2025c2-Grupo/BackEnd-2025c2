using Aplicacion.Utilidades;
using Microsoft.AspNetCore.Mvc;

namespace Infraestructura.Endpoints;

[ApiController]
[Route("[controller]")] 
// Ac� en vez de [controller] puede ir un "/" mas el nombre que se le desea dar al path que representa al grupo de endpoints
// Si no coloca nada toma autom�ticamente el nombre del controlador sin el sufijo "Controller"
public class TestingController : ControllerBase
{
    [HttpGet("/testingCommonFunctions")]
    public IActionResult TestingCommonFunctions()
    {
        return Ok(CommonFunctions.Instance.GetRandomString(10));
    }
}
