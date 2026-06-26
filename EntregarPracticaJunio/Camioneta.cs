using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregarPracticaJunio
{
    internal class Camioneta : Vehiculo
    {
        public int NumeroEjes { get; set; }

        public Camioneta(int horasEstancia, int numeroEjes) : base(horasEstancia)
        {
            NumeroEjes = numeroEjes;
        }

        public override decimal CalcularTarifa()
        {
            return HorasEstancia * 45.00m;
        }
    }
}
