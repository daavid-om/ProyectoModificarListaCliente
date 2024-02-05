using EjercicioCorreccion.Servicios;
using ProyectoModificarListaCliente.Dto;
using ProyectoModificarListaCliente.Servicios;

namespace ProyectoModificarListaCliente.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 300124 - dom
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// 300124 - dom
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //creamos los objetos
            MenuInterfaz mi = new MenuImplementacion();
            FuncionalidadInterfaz fi = new FuncionalidadImplementacion();
            List<ClienteDto> listaCliente = new List<ClienteDto>();

            //bucle menu
            int opcionSeleccionada = 0;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] Ha seleccionado la opcion 0");
                        Console.WriteLine("Se cierra la aplicación");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] Ha seleccionado la opcion 1");
                        fi.darAltaCliente(listaCliente);
                        break;
                    case 2:
                        Console.WriteLine("[INFO] Ha seleccionado la opcion 2");
                        fi.borrarDatosCliente(listaCliente);
                        break;
                    case 3:
                        Console.WriteLine("[INFO] Ha seleccionado la opcion 3");
                        fi.modificarDatosCliente(listaCliente);
                        break;
                    default:
                        Console.WriteLine("[INFO] La opcion seleccionada no coincide con ninguna opción del menu");
                        break;
                }
            }

        }
    }
}
