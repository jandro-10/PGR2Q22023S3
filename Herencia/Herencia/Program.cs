using System;
namespace Herencia;
using Herencia.Model;

class Program
{
    static void Main(string[] args)
    {


        Persona p = new Persona() {

            nombre = "Fernando",
            apellido = "Lopez",
            fechaNacimiento = new DateTime (1988, 11, 30)

        };

        Estudiante e = new Estudiante() {

            nombre ="Lia",
            apellido = "Garay",
            fechaNacimiento = new DateTime (1994, 11, 30),
            numeroCuenta = "T12344"

        };


        e.listTelefonos.Add("98001234");
        e.listTelefonos.Add("89123478");

        e.listClases.Add(new Clase("Progra 1", "4", 89));
        e.listClases.Add(new Clase("Progra 2", "4", 90));
        e.listClases.Add(new Clase("Español", "3", 70));


        e.calcularPromedio();

        Console.WriteLine(p.ToString());
        Console.WriteLine(e.ToString());
        Console.WriteLine(e.getTelefonos());
        Console.WriteLine(e.promedio);



    }
}

