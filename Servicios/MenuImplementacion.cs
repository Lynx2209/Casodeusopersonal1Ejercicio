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
            string mensaje = "Bienvenido a la pagina para comprar tu carnet o comprar entradas para ver los partidos del Sevilla FC";

            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;

            Console.WriteLine("##############################");
            Console.WriteLine("0. Cerrar aplicion");
            Console.WriteLine("1.Comprar Carnet ");
            Console.WriteLine("2.Comprar entradas");
            Console.WriteLine("##############################");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - '0';

            return opcionIntroducida;


        }
    }
}
