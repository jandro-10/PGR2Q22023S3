using System;
using System.Collections.Generic;
namespace Herencia.Model
{
	public class Estudiante : Persona
	{

		public string numeroCuenta { get; set; }

        public List<Clase> listClases { get; set; } = new List<Clase>();
        public List<string> listTelefonos { get; set; } = new List<string>();
        public double promedio { get; set; } 

        // Polimorfismo es la habilidad de poder sobre escribir un metodo de la clase padre
        // o de la clase base.

        public override string ToString()
        {
            return $"Hola mi nombre es, {nombre} y mi numero de cuenta es {numeroCuenta}";
        }

        public string getTelefonos() {


            string reporte = "";

            foreach (string x in listTelefonos) {

                reporte += x + ",";

            }

            return reporte;
        }

        public void calcularPromedio() {

            double p= 0;

            foreach (Clase n in listClases) {
                p = p + n.notaFinal;
            }

            p = p / listClases.Count;

            promedio = p;

        }

    }
}

