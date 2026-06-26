using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregarPracticaJunio
{
    public abstract class Vehiculo
    {
        public int HorasEstancia { get; set; }

        public Vehiculo(int horasEstancia)
        {
            HorasEstancia = horasEstancia;
        }

        public abstract decimal CalcularTarifa();
    }
}
