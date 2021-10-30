using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Resolucion_Ejercicios.Api.Infraestructure;

/*Nombre de la escuela: Universidad Tecnológica Metropolitana

Asignatura: Aplicaciones Web Orientadas a Servicios

Nombre del Maestro: Chuc Uc Joel Ivan

Nombre de la actividad: Actividad 2

Nombre del alumno: Guillermo Aldair Paredes Ayala

Cuatrimestre: 4

Grupo: B

Parcial: 2

*/

namespace Resolucion_Ejercicios.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControladorAlcoholemia : ControllerBase
    {
    [HttpGet("Ejercicio_2")]

        public string Resultado (string bebida, double cantidad, double peso)
        {
            double alcoholRespuesta;
            var repositorio = new OperacionesAlcohol();
            alcoholRespuesta = repositorio.PruebaAlcoholemia(bebida, cantidad, peso);
            if(alcoholRespuesta <= 0.8)
            {
                return "Usted tiene " + alcoholRespuesta + "% de alcohol en la sangre. Por lo que tiene un nivel aceptable para manejar. Disfrute su viaje";
            }
            else
            {
                return "Usted tiene un nivel de " + alcoholRespuesta + "% de alcohol en la sangre. Por lo que su nivel es mayor al permitido. Queda arrestado por irresponsable";
            }
        }
    }
}