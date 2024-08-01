using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3107_herancaExercicio
{
    internal class Conta
    {
        public string nConta;
        public string agencia;
        public string titular;
        protected double saldo;

        public void mostrarSaldo()
        {
            Console.WriteLine($"saldo: {saldo}\n");
        }
        
        public virtual void sacar(double valor)
        {
            Console.Clear();
            if (saldo < valor)
            {
                Console.WriteLine($"saldo insuficiente, operação cancelada!\n" +
                    $"tentativa de saque: R$ {valor}\n" +
                    $"saldo atual: R$ {saldo}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"saque de R$ {valor} realizado!\n" +
                    $"saldo anterior: R$ {saldo}\n" +
                    $"saldo atual: R$ {saldo -= valor}\n" +
                    $"pressione uma tecla para continuar...");
                Console.ReadKey();
            }
        }
           
        public void depositar(double valor)
        {
            Console.Clear();
            Console.WriteLine($"deposito de R$ {valor} realizado!\n" +
                $"saldo anterior: {saldo}\n" +
                $"saldo atual: {saldo+=valor}\n" +
                $"pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
