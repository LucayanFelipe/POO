using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_heranca_0708
{
    internal abstract class Veiculo
    {
        private string placa;
        public void setPlaca (string placa)
        {
            this.placa = placa;
        } 
        public string getPlaca()
        {
            return placa;
        }

        private int qtdEixos;
        public void setEixos(int qtdEixos)
        {
         
                if (qtdEixos < 0)
                {
                    throw new Exception("Valor menor que zero, não permitido.");

                }
                else {
                    this.qtdEixos = qtdEixos;
                }
            
        }
        public int getEixos()
        {
            return qtdEixos;
        }

        private int tipo;

        public void setTipo(int tipo)
        {
            this.tipo = tipo;
        }
        public int getTipo()
        {
            return tipo;
        }

        private double precoPedagio;
        public void setPrecoPedagio(double precoPedagio)
        {
            this.precoPedagio = precoPedagio;
        }
        public double getPrecoPedagio()
        {
            return precoPedagio;
        }

        private double valorFinal;
        public void setValorFinal(double valorFinal)
        {
            this.valorFinal = valorFinal;
        }
        public double getValorFinal()
        {
            return valorFinal;
        }

        public Veiculo()
        {

        }

        public abstract void CalcularPedagio();
    

        public void CalcularDesconto()
        {
            if(getTipo() == 1)
            {
                valorFinal = precoPedagio;
            }
            if(getTipo()== 2)
            {
                valorFinal = precoPedagio - precoPedagio * 0.05;
            }
            if(getTipo()==3)
            {
                valorFinal = 0;
            }
        }

        
    }
}
