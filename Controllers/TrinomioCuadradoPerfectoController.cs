using Microsoft.AspNetCore.Mvc;

namespace FuncionesCalculadora.Controllers
{
  [ApiController]
  [Route("Funciones/[controller]")]
  public class TrinomioCuadradoPerfectoController : ControllerBase
  {
    private readonly ILogger<TrinomioCuadradoPerfectoController> _logger;

    public TrinomioCuadradoPerfectoController(ILogger<TrinomioCuadradoPerfectoController> logger)
    {
      _logger = logger;
    }


    [HttpGet(Name = "TrinomioCuadradoPerfecto")]
    public int CalcularTrinomioCuadradoPerfecto(int a, int b)
    {
      return ((int)Math.Pow(a, 2) + 2 * (a * b) - (int)Math.Pow(b, 2));
    }

  }
}
