using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public override string ToString()
        {
            return $"hola mi nombre es {nombre};
        }
    }
}
