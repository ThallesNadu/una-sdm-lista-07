using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EcoTrackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        private static readonly string[] Dicas = new[]
        {
            "Prefira transporte público ou bicicleta sempre que possível.",
            "Reduza o uso de plástico descartável no seu dia a dia.",
            "Desligue aparelhos eletrônicos quando não estiver usando.",
            "Economize água fechando a torneira ao escovar os dentes.",
            "Dê preferência a produtos com menor impacto ambiental."
        };

        private readonly Random _random = new Random();

        [HttpGet]
        public ActionResult<string> Get()
        {
            int index = _random.Next(Dicas.Length);
            return Ok(Dicas[index]);
        }
    }
}