using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregarPracticaJunio
{
    internal class Automovil: Vehiculo
    {
        public string Placa { get; set; }

        public Automovil(int horasEstancia, string placa) : base(horasEstancia)
        {
            Placa = placa;
        }

        public override decimal CalcularTarifa()
        {
            return HorasEstancia * 30.00m;
        }
    }
}
