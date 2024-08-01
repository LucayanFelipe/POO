using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3107_herancaExercicio
{
    internal class ContaEmpresarial:Conta
    {
        public double anuidade;
        public double limiteEmprestimo;
        public double totalEmprestimo;

        public void FazerEmprestimo(double valor)
        {
            Console.Clear();
            if(limiteEmprestimo>=valor && limiteEmprestimo>=totalEmprestimo)
            {
                totalEmprestimo += valor;
                Console.WriteLine($"Empréstimo realizado com sucesso!\n" +
                    $"saldo anterior {saldo}\n" +
                    $"saldo atual {saldo += valor}\n" +
                    $"SEU LIMITE DE EMPRESTIMO: R$ {limiteEmprestimo}\n" +
                    $"TOTAL DE EMPRESTIMO REALIZADO: R$ {totalEmprestimo}\n" +
                    $"pressione alguma tecla para continuar...");
                Console.ReadKey();
            } else
            {
                Console.WriteLine($"limite de emprestimo excedido! operação negada!\n" +
                    $"saldo anterior {saldo}\n" +
                    $"saldo atual {saldo}\n" +
                    $"SEU LIMITE DE EMPRESTIMO: R$ {limiteEmprestimo}\n" +
                    $"TOTAL DE EMPRESTIMO REALIZADO: R$ {totalEmprestimo}\n" +
                    $"pressione alguma tecla para continuar...");
                Console.ReadKey();
            }
        }

        public override void sacar(double valor)
        {
            Console.Clear();
            if (saldo < valor)
            {
                Console.WriteLine($"saldo insuficiente, operação cancelada!\n" +
                    $"tentativa de saque: R$ {valor}\n" +
                    $"saldo atual: R$ {saldo}\n");
                Console.ReadKey();
            }
           else 
           {
            if(valor>=5000)
            {
                Console.WriteLine($"saque acima de R$ 5000,00 taxa de R$ 5,00 aplicada!\n" +
                 $"saldo anterior: R$ {saldo}\n" +
                 $"saldo atual: R$ {saldo -= valor-5}\n" +
                 $"pressione uma tecla para continuar...");
                Console.ReadKey();
            } else
            {
                Console.WriteLine($"saque de R$ {valor} realizado!\n" +
                   $"saldo anterior: R$ {saldo}\n" +
                   $"saldo atual: R$ {saldo -= valor}\n" +
                   $"pressione uma tecla para continuar...");
                Console.ReadKey();
            }
           }
        }

    }
}
