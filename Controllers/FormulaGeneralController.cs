using Microsoft.AspNetCore.Mvc;

namespace FuncionesCalculadora.Controllers
{
  [ApiController]
  [Route("Funciones/[controller]")]
  public class FormulaGeneralController : ControllerBase
  {
    private readonly ILogger<FormulaGeneralController> _logger;

    public FormulaGeneralController(ILogger<FormulaGeneralController> logger)
    {
      _logger = logger;
    }


    [HttpGet(Name = "FormulaGeneral")]
    public string FormulaGeneral(int a, int b, int c)
    {
      double x1 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / 2 * a;
      double x2 = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / 2 * a;
      return string.Concat("x1: ", x1, ", x2: ", x2);
    }

  }
}
