using System;
namespace Herencia.Model
{
	public class Clase
	{
		public string nombre { get; set; }
		public string unidadesValorativas { get; set; }
		public double notaFinal { get; set; }

        public Clase(string n, string uv, double nota) {

            nombre = n;
            unidadesValorativas = uv;
            notaFinal = nota;


        }

        public override string ToString()
        {
            return $" {nombre} : {notaFinal} ";
        }
    }
}

