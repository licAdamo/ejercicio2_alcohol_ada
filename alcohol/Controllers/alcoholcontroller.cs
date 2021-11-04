using alcohol.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
/*Nombre de la escuela: Universidad Tecnológica Metropolitana
Profesor: Joel Chuc Uc
Materia: Aplicaciones web orientadas a servicios
Alumna: Ada Nazcais Martin Morales
cuarto cuatrimestre
Grupo: A
Parcial 2
Actividad 2: Desarrollar y crear Api's*/

namespace alcohol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class alcoholcontroller : ControllerBase
    {
        [HttpGet]
        [Route("alcolimetro")]
        
        public IActionResult alcolimetro(string bebida,int cantidad, int peso)
        {
            
            var resultado = new bebida();
            resultado.calcularalcoholconsumido(bebida,cantidad);
            if(bebida.ToLower()!= "brandy" && bebida.ToLower()!="cerveza" && bebida.ToLower()!="vino" && bebida.ToLower()!="cava" && bebida.ToLower()!="vermu" && bebida.ToLower()!="licor")
            {
                return Ok(" La bebida incorrecta, inserte de nuevo.");
            }
            resultado.calcularlorestante(peso);
            
            return Ok(resultado.respuesta());
        }
        
    
    }
}
