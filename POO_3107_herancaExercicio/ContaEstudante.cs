using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3107_herancaExercicio
{
    internal class ContaEstudante:Conta
    {
        public double limiteChequeEspecial;
        public string cpf;
        public string nomeInstituicao;

        public override void sacar(double valor)
        {
            Console.Clear();
            if (saldo + limiteChequeEspecial < valor)
            {
                Console.WriteLine($"saldo insuficiente, operação cancelada!\n" +
                    $"tentativa de saque: R$ {valor}\n" +
                    $"saldo atual: R$ {saldo}\n" +
                    $"limiteChequeEspecial disponivel: R$ {limiteChequeEspecial}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"saque de R$ {valor} realizado!\n" +
                    $"saldo anterior: R$ {saldo}\n" +
                    $"saldo atual: R$ {saldo -= valor}\n" +
                    $"limite cheque especial estudantil: {limiteChequeEspecial}");
                if (saldo < 0)
                {
                    Console.WriteLine($"\nfoi utilizado o limiteChequeEspecial nesse saque!\n" +
                        $"novo limite cheque especial estudantil: {limiteChequeEspecial+=saldo}");
                }
                Console.ReadKey();
            }
        }
    }
}
