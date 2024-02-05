using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoModificarListaCliente.Dto;

namespace ProyectoModificarListaCliente.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de la funcionalidad
    /// 300124 dom
    /// </summary>
    internal class FuncionalidadImplementacion : FuncionalidadInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaClienteAntigua)
        {
            ClienteDto nuevoCliente = crearCliente();
            listaClienteAntigua.Add(nuevoCliente);
        }
        /// <summary>
        /// Método que pide al usuario la informacion necesaria para crear un nuevo cliente
        /// 300124 dom
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearCliente()
        {
            ClienteDto datosCliente = new ClienteDto();
            Console.WriteLine("Introduce el id del cliente: ");
            datosCliente.Dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del cliente: ");
            datosCliente.Name = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            datosCliente.Lastname = Console.ReadLine();
            Console.WriteLine("Introduzca el gmail del cliente: ");
            datosCliente.Email = Console.ReadLine();
            
            return datosCliente;
        }

        public void borrarDatosCliente(List<ClienteDto> listaClienteAntigua) 
        {
            ClienteDto datosBorrar = new ClienteDto();

            // Imprimimos la lista antes de eliminar un elemento
            Console.WriteLine("Lista antes de eliminar:");
            foreach (string elemento in datosBorrar)
            {
                Console.WriteLine(elemento);
            }

            // Eliminamos el elemento "Tres" de la lista
            datosBorrar.Remove("dni , name , lastname , email");

            // Imprimimos la lista después de eliminar el elemento "Tres"
            Console.WriteLine("Lista después de eliminar:");
            foreach (string elemento in datosBorrar)
            {
                Console.WriteLine(elemento);
            }
        }


        public void modificarDatosCliente(List<ClienteDto> listaClienteAntigua)
        {

        }
    }
}
