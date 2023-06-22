using Microsoft.AspNetCore.Mvc;

namespace FuncionesCalculadora.Controllers
{
  [ApiController]
  [Route("Funciones/[controller]")]
  public class PotenciaController : ControllerBase
  {
    private readonly ILogger<PotenciaController> _logger;

    public PotenciaController(ILogger<PotenciaController> logger)
    {
      _logger = logger;
    }


    [HttpGet(Name = "Potencia")]
    public int CalcularPotencia(int n1, int n2)
    {
      return (int)Math.Pow(n1, n2);
    }

  }
}
