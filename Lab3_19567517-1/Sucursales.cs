using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_19567517_1
{
    class Sucursales
    {
        string nombreSuc;
        int stockMax;
        List<Vehiculos> repertorio = new List<Vehiculos>();

        public Sucursales(string nombreSuc, int stockMax, List<Vehiculos> repertorio)
        {
            this.nombreSuc = nombreSuc;
            this.stockMax = stockMax;
            this.repertorio = repertorio;

        }
        public void AgregarVehiculo(Vehiculos vehiculos, Sucursales sucursales)
        {
            while (sucursales.stockMax > 0)
            {
                repertorio.Add(vehiculos);
                sucursales.stockMax = (sucursales.stockMax - 1);

            }
        }
    }
}
