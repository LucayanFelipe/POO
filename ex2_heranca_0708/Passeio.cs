using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_heranca_0708
{
    internal class Passeio:Veiculo
    {
        public Passeio()
        {

        }

        public override void CalcularPedagio()
        {
            double pedagioCalculado = 0.0;
            pedagioCalculado = 3.0 * getEixos();
            setPrecoPedagio(pedagioCalculado);

        }
    }
}
