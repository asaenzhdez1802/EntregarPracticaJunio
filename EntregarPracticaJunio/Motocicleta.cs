using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregarPracticaJunio
{
    internal class Motocicleta : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Motocicleta(int horasEstancia, int cilindrada) : base(horasEstancia)
        {
            Cilindrada = cilindrada;
        }

        public override decimal CalcularTarifa()
        {
            return HorasEstancia * 15.00m;
        }
    }
}
