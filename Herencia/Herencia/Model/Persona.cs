using System;
namespace Herencia.Model
{
	public class Persona
	{
		public string nombre { get; set; }
		public string apellido { get; set; }
		public DateTime fechaNacimiento { get; set; }



        public override string ToString()
        {
            return $" Hola mi nombre es {nombre} y naci el {fechaNacimiento} ";
        }



    }
}

