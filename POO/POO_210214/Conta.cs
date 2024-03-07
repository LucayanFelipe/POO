using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_210214
{
    internal class Conta
    {
        public string id;
        public string agencia;
        public string numeroConta;
        public string nomeProprietario;
        public double saldo;

        public void Depositar (double saldoAcrescimo)
        {
            if (saldoAcrescimo < 0)
            {
                Console.WriteLine("Favor informar deposito válido");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("Deposito realizado!" +
                    "\nsaldo anterior: "+ saldo + $"\nsaldo atual: {saldo+saldoAcrescimo}\n");
                saldo += saldoAcrescimo;
                Console.ReadKey();
            }
        }

        public void Sacar (double valorSaque)
        {
            if(valorSaque<0 || valorSaque >= saldo)
            {
                Console.WriteLine("Não foi possivel realizar o saque" +
                    "\nverifique se o valor não é negativo ou maior que o saldo" +
                    "\nSEU SALDO: "+ saldo);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Valor sacado com sucesso!\n" +
                    "saldo anterior: " + saldo + $"\nsaldo atual: {saldo-valorSaque}");
                saldo -= valorSaque;
                Console.ReadKey();
            }
        }

        public void Transferir (Conta destino, double valor)
        {
            destino.saldo += valor;
            saldo -= valor;

        }
    }
}
