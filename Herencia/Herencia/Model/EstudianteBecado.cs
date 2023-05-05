using System;
namespace Herencia.Model
{
	public class EstudianteBecado : Estudiante
	{

		public double horasTrabajo { get; set; }


        public override string ToString()
        {
            return base.ToString() + $" horas : {horasTrabajo} ";
        }

    }
}

