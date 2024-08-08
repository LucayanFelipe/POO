using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_heranca_0708
{
    internal class Caminhao:Veiculo
    {
        public Caminhao()
        {
            
        }

        public override void CalcularPedagio()
        {
            double pedagioCalculado = 0.0;
            pedagioCalculado = 7.0 * getEixos();
            pedagioCalculado *= 1.10;
            setPrecoPedagio(pedagioCalculado);

        }
    }
}
