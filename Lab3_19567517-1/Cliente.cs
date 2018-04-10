using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_19567517_1
{
    class Cliente
    {
        string rut;
        string nombre;
        string edad;
        string categoria;

        public Cliente(string rut, string nombre, string edad, string categoria)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.edad = edad;
            this.categoria = categoria;
        }
        public class Persona : Cliente
        {
            string Licencia;
            string tipo;

            public Persona(string Licencia, string tipo, string rut, string nombre, string edad, string categoria) : base(rut, nombre, edad, categoria)
            {
                this.Licencia = Licencia;
                this.tipo = tipo;
            }
        }
        public class Empresa : Cliente
        {
            string autorizacion;
            string tipo;
            public Empresa(string autorizacion, string tipo, string rut, string nombre, string edad, string categoria) : base(rut, nombre, edad, categoria)
            {
                this.autorizacion = autorizacion;
                this.tipo = tipo;
            }
        }

    }
}
