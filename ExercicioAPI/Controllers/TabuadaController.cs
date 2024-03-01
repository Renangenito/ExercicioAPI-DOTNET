using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabuadaController : ControllerBase
    {

        [HttpGet("{anoNascimento}")]

        public string get(int anoNascimento)
        {
            int idade = DateTime.Now.Year - anoNascimento;
            
            if (idade > 18)
            {
                return "Você tem "+ idade + " anos e é maior de idade";
            }
            else
            {
                return "Você tem " + idade + " anos e é menor de idade";
            }
        }
    }
}
