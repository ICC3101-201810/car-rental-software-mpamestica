using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_19567517_1
{
    class Vehiculos
    {
        string tipo;
        string modelo;
        int precio;
        string requerida;
        int stock;
        string patente;

        public Vehiculos(string tipo, string modelo, int precio, string requerida, int stock, string patente)
        {
            this.tipo = tipo;
            this.modelo = modelo;
            this.precio = precio;
            this.requerida = requerida;
            this.stock = stock;
            this.patente = patente;
        }
    }
}
