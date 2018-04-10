using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_19567517_1
{
    class Arriendo 
    {
        List<string> lista = new List<string>();

        public void AgregarArriendo (Cliente cliente, Sucursales sucursales, Accesorios accesorios)
        {


        }
        public class Accesorios : Arriendo
        {
            string tipo;
            int precio;

            public Accesorios(string tipo, int precio) : base()
            {
                this.tipo = tipo;
                this.precio = precio;

            }
        }
    }
}
