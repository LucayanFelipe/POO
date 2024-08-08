using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_heranca_0708
{
    internal class Utilitario:Veiculo
    {
        public Utilitario()
        {

        }

        public override void CalcularPedagio()
        {
            double pedagioCalculado = 0.0;
            pedagioCalculado = 3.5 * getEixos();
            pedagioCalculado *= 1.02;
            setPrecoPedagio(pedagioCalculado);

        }
    }
}
