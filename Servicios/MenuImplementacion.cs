using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casodeusopersonal1Ejercicio.Servicios
{
    /// <summary>
    /// Implementacion de las acciones del menu
    /// 200923
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido a Miljuegos ";

            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;

            Console.WriteLine("##############################");
            Console.WriteLine("0. Cerrar aplicion");
            Console.WriteLine("1.Inicio ");
            Console.WriteLine("2.Juegos");
            Console.WriteLine("3.Biblioteca");
            Console.WriteLine("4.Canjear Codigos");
            Console.WriteLine("5.Perfil");
            Console.WriteLine("##############################");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - '0';

            return opcionIntroducida;


        }
    }
}
