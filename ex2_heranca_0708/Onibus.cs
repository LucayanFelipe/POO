using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_heranca_0708
{
    internal class Onibus:Veiculo
    {
        public Onibus()
        {

        }

        public override void CalcularPedagio()
        {
            double pedagioCalculado = 0.0;
            pedagioCalculado = 5.0 * getEixos();
            pedagioCalculado *= 1.05;
            setPrecoPedagio(pedagioCalculado);

        }
    }
}
