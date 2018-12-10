using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_Busqueda.Models
{
    public class Estudiantes
    {
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double Promedio { get; set; }
        public DateTime FechaRegistro { get; set; }

        public List<Estudiantes> lista()
        {
            var Estudiante1 = new Estudiantes()
            {
                Carnet = 001,
                Nombre = "Marcos",
                Materia ="Matematica",
                Promedio = 8.8,
                FechaRegistro = DateTime.Now
            };
            var Estudiante2 = new Estudiantes()
            {
                Carnet = 002,
                Nombre = "Tomas",
                Materia = "Informatica",
                Promedio = 9.5,
                FechaRegistro = DateTime.Now

            };

            var Estudiante3 = new Estudiantes()
            {
                Carnet = 003,
                Nombre = "Antinio",
                Materia = "Programacion",
                Promedio = 10,
                FechaRegistro = DateTime.Now

            };

            var Estudiante4 = new Estudiantes()
            {
                Carnet = 004,
                Nombre = "Santiago",
                Materia = "EStadistica",
                Promedio = 7.5,
                FechaRegistro = DateTime.Now

            };


            var Estudiante5 = new Estudiantes()
            {
                Carnet = 005,
                Nombre = "Francisco",
                Materia = "Fundamento de Programacon",
                Promedio = 6,
                FechaRegistro = DateTime.Now

            };
            return new List<Estudiantes>() { Estudiante1, Estudiante2, Estudiante3, Estudiante4, Estudiante5 };


        }
    }
}