using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3107_herancaExercicio
{
    internal class Program
    {

        static Conta menuConta(Conta c)
        {
            string menu = "";
            double valor = 0.0;

            while (menu != "voltar")
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção!\n" +
                    "1: cadastrar conta\n" +
                    "2: consultar conta\n" +
                    "3: sacar\n" +
                    "4: depositar\n" +
                    "digite 'voltar' para retornar ao menu anterior!");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        c.nConta = "14235";
                        c.agencia = "1337";
                        Console.WriteLine("Digite o nome do titular");
                        c.titular = Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"******** CONTA PADRÃO ********\n" +
                            $"numero da conta: {c.nConta}\n" +
                            $"agencia: {c.agencia}\n" +
                            $"titular: {c.titular}");
                        c.mostrarSaldo();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Digite o valor que deseja sacar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        c.sacar(valor);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Digite o valor que deseja depositar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        c.depositar(valor);
                        break;
                    default:
                        break;
                }
            }
            return c;
        }

        static ContaEstudante menuContaEstudante(ContaEstudante c)
        {
            string menu = "";
            double valor = 0.0;

            while (menu != "voltar")
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção!\n" +
                    "1: cadastrar conta\n" +
                    "2: consultar conta\n" +
                    "3: sacar\n" +
                    "4: depositar\n" +
                    "5: adicionar limite cheque especial\n" +
                    "digite 'voltar' para retornar ao menu anterior!");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        c.nConta = "435345";
                        c.agencia = "3456";
                        Console.WriteLine("Digite o nome do titular");
                        c.titular = Console.ReadLine();
                        Console.WriteLine("Digite seu cpf");
                        c.cpf = Console.ReadLine();
                        Console.WriteLine("Digite o nome da instituição");
                        c.nomeInstituicao = Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"******** CONTA ESTUDANTIL ********\n" +
                            $"numero da conta: {c.nConta}\n" +
                            $"agencia: {c.agencia}\n" +
                            $"titular: {c.titular}\n" +
                            $"cpf: {c.cpf}\n" +
                            $"nome instituição {c.nomeInstituicao}");
                        c.mostrarSaldo();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Digite o valor que deseja sacar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        c.sacar(valor);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Digite o valor que deseja depositar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        c.depositar(valor);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine($"limite cheque especial atual: R$ {c.limiteChequeEspecial}" +
                            $"\ndigite quanto deseja adicionar de limite: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"operação realizada com sucesso!\n" +
                            $"limite cheque especial anterior: {c.limiteChequeEspecial}\n" +
                            $"limite cheque especial atual: {c.limiteChequeEspecial += valor}");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
            return c;
        }

        static ContaEmpresarial menuContaEmpresarial(ContaEmpresarial c)
        {
            string menu = "";
            double valor = 0.0;

            while (menu != "voltar")
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção!\n" +
                    "1: cadastrar conta\n" +
                    "2: consultar conta\n" +
                    "3: sacar\n" +
                    "4: depositar\n" +
                    "5: aumentar limite emprestimo\n" +
                    "6: realizar emprestimo\n" +
                    "digite 'voltar' para retornar ao menu anterior!");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        c.nConta = "56785678";
                        c.agencia = "5446";
                        Console.WriteLine("Digite o nome do titular");
                        c.titular = Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"******** CONTA EMPRESARIAL ********\n" +
                            $"numero da conta: {c.nConta}\n" +
                            $"agencia: {c.agencia}\n" +
                            $"titular: {c.titular}\n" +
                            $"limite de emprestimo: {c.limiteEmprestimo}\n");
                        c.mostrarSaldo();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Digite o valor que deseja sacar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        c.sacar(valor);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Digite o valor que deseja depositar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        c.depositar(valor);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine($"seu limite de emprestimo: R$ {c.limiteEmprestimo}" +
                            $"\ndigite quanto deseja adicionar de limite: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"operação realizada com sucesso!\n" +
                            $"limite de emprestimo anterior: {c.limiteEmprestimo}\n" +
                            $"limite de emprestimo atual: {c.limiteEmprestimo += valor}");
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine($"seu limite de emprestimo: {c.limiteEmprestimo}\n" +
                            $"digite o quanto deseja pegar de emprestimo: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        c.FazerEmprestimo(valor);
                        break;
                    default:
                        break;
                }
            }
            return c;
        }

        static void Main(string[] args)
        {
            Conta c1 = new Conta(); 
            ContaEstudante c2 = new ContaEstudante();
            ContaEmpresarial c3 = new ContaEmpresarial();
            string menu = "";

            while(menu!="sair")
            {
                Console.Clear();
                Console.WriteLine("Selecione um tipo de conta!\n" +
                    "1: conta normal\n" +
                    "2: conta estudante\n" +
                    "3: conta empresarial\n" +
                    "digite 'sair' para finalizar!");
                menu = Console.ReadLine();

                switch(menu)
                {
                    case "1":
                        c1 = menuConta(c1);
                        break;
                    case "2":
                        c2 = menuContaEstudante(c2);
                        break;
                    case "3":
                        c3 = menuContaEmpresarial(c3);
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
