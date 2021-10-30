using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resolucion_Ejercicios.Api.Domain;
namespace Resolucion_Ejercicios.Api.Controllers

/*Nombre de la escuela: Universidad Tecnológica Metropolitana

Asignatura: Aplicaciones Web Orientadas a Servicios

Nombre del Maestro: Chuc Uc Joel Ivan

Nombre de la actividad: Actividad 2

Nombre del alumno: Guillermo Aldair Paredes Ayala

Cuatrimestre: 4

Grupo: B

Parcial: 2

*/

{
    [ApiController]
    [Route("[controller]")]
    public class ControladorResistencia : ControllerBase
    {
    [HttpGet("Ejercicio_1")]
        public ActionResult<Resistencia> Resistencias (string Banda1, string Banda2, string Banda3, string Banda4)
        {
            Resistencia Colors = new Resistencia();

                Colors.Colores = Banda1;

                var Texto = "";

                switch (Colors.Colores)
            {
                case "Negro":
                Colors.PrimerValor = 0;
                break;
                case "Café":
                Colors.PrimerValor = 1;
                break;
                case "Rojo":
                Colors.PrimerValor = 2;
                break;
                case "Naranja":
                Colors.PrimerValor = 3;
                break;
                case "Amarillo":
                Colors.PrimerValor = 4;
                break;
                case "Verde":
                Colors.PrimerValor = 5;
                break;
                case "Azul":
                Colors.PrimerValor = 6;
                break;
                case "Violeta":
                Colors.PrimerValor = 7;
                break;
                case "Gris":
                Colors.PrimerValor = 8;
                break;
                case "Blanco":
                Colors.PrimerValor = 9;
                break;
                default:
                Texto = $"Acabas de ingresar el color '{Banda1}' , este color es inválido, por favor ingresa un color válido";
                return Ok(Texto);
            }

            var CL1 = Colors.PrimerValor;

            Colors.Colores = Banda2;

            switch (Colors.Colores)
            {
                case "Negro":
                Colors.PrimerValor = 0;
                break;
                case "Café":
                Colors.PrimerValor = 1;
                break;
                case "Rojo":
                Colors.PrimerValor = 2;
                break;
                case "Naranja":
                Colors.PrimerValor = 3;
                break;
                case "Amarillo":
                Colors.PrimerValor = 4;
                break;
                case "Verde":
                Colors.PrimerValor = 5;
                break;
                case "Azul":
                Colors.PrimerValor = 6;
                break;
                case "Violeta":
                Colors.PrimerValor = 7;
                break;
                case "Gris":
                Colors.PrimerValor = 8;
                break;
                case "Blanco":
                Colors.PrimerValor = 9;
                break;
                default:
                return Ok(Texto);
            }

            var CL2 = Colors.PrimerValor;

            Colors.Colores = Banda3;

                switch (Colors.Colores)
            {
                case "Negro":
                Colors.PrimerValor = 1;
                break;
                case "Café":
                Colors.PrimerValor = 10;
                break;
                case "Rojo":
                Colors.PrimerValor = 100;
                break;
                case "Naranja":
                Colors.PrimerValor = 1000;
                break;
                case "Amarillo":
                Colors.PrimerValor = 10000;
                break;
                case "Verde":
                Colors.PrimerValor = 100000;
                break;
                case "Azul":
                Colors.PrimerValor = 1000000;
                break;
                case "Dorado":
                Colors.PrimerValor = 10;
                break;
                case "Plateado":
                Colors.PrimerValor = 100;
                break;
                default:
                return Ok(Texto);
            }

            var CL3 = Colors.SegundoValor;

                Colors.Colores = Banda4;

                switch (Colors.Colores)
            {

                case "Dorado":
                Colors.PrimerValor = 5;
                break;
                case "Plateado":
                Colors.PrimerValor = 10;
                break;
                default:
                return Ok(Texto);
            
            }

            var CL4 = Colors.PrimerValor;
            
            float Finally;

            var NumeroUno  = Int32.Parse($"{CL1}{CL2}");

            if (Banda3 == "Dorado" || Banda3 == "Plateado")
            {
                Finally = (NumeroUno / CL3);
            }
            else
            {
                Finally = (NumeroUno * CL3);
            }

            Texto = "El resultado final es de: "+ Finally +" Ω y Resiste una tolerancia de; " + CL4 + "%";

            return Ok(Texto);
        }
    }
}
