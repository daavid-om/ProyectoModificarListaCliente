using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoModificarListaCliente.Dto;

namespace ProyectoModificarListaCliente.Servicios
{
    /// <summary>
    /// Interfaz que implementa la funcionalidad de la aplicacion
    /// 300124 dom
    /// </summary>
    internal interface FuncionalidadInterfaz
    {
        /// <summary>
        /// Método que recoge informacion del cliente
        /// 300124 dom
        /// </summary>
        /// <param name="listaClienteAntigua"></param>
        public void darAltaCliente(List<ClienteDto> listaClienteAntigua);

        /// <summary>
        /// Método que borra datos del cliente
        /// 300124 dom
        /// </summary>
        /// <param name="listaClienteAntigua"></param>
        public void borrarDatosCliente(List<ClienteDto> listaClienteAntigua);

        /// <summary>
        /// Método que modica los datos del cliente
        /// </summary>
        /// <param name="listaClienteAntigua"></param>
        public void modificarDatosCliente(List<ClienteDto> listaClienteAntigua);

    }
}
