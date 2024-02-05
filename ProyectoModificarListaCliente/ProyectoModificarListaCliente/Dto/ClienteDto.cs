using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModificarListaCliente.Dto
{
    internal class ClienteDto
    {
        //Atributos
        string name = "aaaaa";
        string lastname = "aaaaa";
        string email = "aaaaa";
        string nombreCompleto = "aaaaa";
        int dni = 0;

        //Constructores
        public ClienteDto(string name, string lastname, string email, int dni)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Email = email;
            this.Dni = dni;
            this.NombreCompleto = nombreCompleto;
        }
        public ClienteDto()
        {

        }

        //getters y setters
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public int Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }

        //ToString
        string respuesta;
        public override string ToString()
        {
            NombreCompleto = name + " " + lastname;
            string datos = NombreCompleto + " " + dni;
            return datos;
        }
    }
}
