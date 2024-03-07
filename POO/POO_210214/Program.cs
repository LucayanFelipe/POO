using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace POO_210214
{
    internal class Program
    {

        //025.147.052.07
        static public string cpf_masc(string cpf)
        {
           
            string copia = cpf;
            string novo = "";
            for (int i = 3; i < cpf.Length; i += 4)
            {
                novo = copia.Insert(i, ".");
                copia = novo;
            }
                novo = copia.Insert(11, "-");
                copia = novo;


            return copia;
        }


        static public Boolean cpfValidation(string cpf)
        {
            if (cpf.Length == 11) return false;
            else
            {
                Console.Clear();
                Console.WriteLine("CPF INVALIDO!");
                Console.ReadKey();
                return true;
            }
        }
        /*    
        30 01 2004
        21 12 2024
         */

        static public string [] dataVetor (string dataRecebida)
        {
            string[] aux = new string [3];
            aux[0] = dataRecebida;


            return aux;
        }

        static public bool verifySimilarId(Conta [] c, int qtdConta)
        {
            for (int i = 0; i < qtdConta; i++)
            {
                for (int j = i+1; j <= qtdConta; j++)
                {
                    if (j > qtdConta) return false;
                    if (i == j) j++; 
                    if (String.Equals(c[i].id, c[j].id))
                    {
                        return true;
                    }
                }
            }
                return false;

        }



        static void Main(string[] args)
        {
            string menu = "";
            int qtd = 0, qtdConta=0;
            Funcionario [] func = new Funcionario[50];
            Conta[] conta = new Conta[50];
            Conta conta1, conta2;
            string idTemp = "";

            while (menu != "stop")
            {
                bool flagID = false;
                string dataTemporaria = "";
                string[] dataSeparada = new string[3];
                Console.Clear();
                Console.WriteLine("Bem vindo selecione uma opção:\n1: Cadastrar aluno\n2: Consultar alunos\n3: Cadastrar conta\n4: Consultar contas\n" +
                    "5: Depositar conta\n6: Sacar conta\n7: Transferir entre contas");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        func[qtd] = new Funcionario();
                        Console.WriteLine("Informe o nome: ");
                        func[qtd].nome = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Informe o cpf: ");
                            func[qtd].cpf = Console.ReadLine();
                        } while (cpfValidation(func[qtd].cpf));

                        Console.WriteLine("Informe o email: ");
                        func[qtd].email = Console.ReadLine();
                        Console.WriteLine("Informe a senha: ");
                        func[qtd].senha = Console.ReadLine();
                        /* INCOMPLETO
                        Console.WriteLine("Informe a data de nascimento");
                        dataTemporaria = Console.ReadLine();
                        dataSeparada = dataVetor(dataTemporaria);
                        func[qtd].dataNascimento = new DateTime(Convert.ToInt32(dataSeparada[0]), Convert.ToInt32(dataSeparada[1]), Convert.ToInt32(dataSeparada[2]));
                        */ 
                        qtd++;
                        break;
                    case "2":
                        Console.Clear();
                        for(int i = 0; i < qtd;i++)
                        {
                                Console.WriteLine
                                ($"---------XX--------XX---------\n" +
                                $"aluno {i+1}:\n" +
                                $"nome: {func[i].nome}     cpf: {cpf_masc(func[i].cpf)}\n" +
                                $"email: {func[i].email}   senha:  {func[i].senha}\n" +
                                $"---------XX--------XX---------\n");
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        conta[qtdConta] = new Conta();
                        flagID = false; //reinicia a flag
                        for (int i = 0; i < qtdConta+1; i++)
                        {
                            if (conta[qtdConta].id == null)
                            {
                                Console.WriteLine("Informe o id da conta: ");
                                conta[qtdConta].id = Console.ReadLine();
                            } else if (verifySimilarId(conta, qtdConta))
                            {
                                Console.WriteLine("ERRO! tentativa de cadastrar id's iguais!");
                                Console.ReadKey();
                                flagID = true;
                                break;
                            }
                        }
                        if(flagID) { break; } //verifica se os id's são iguais e quebra o switch case
                        Console.WriteLine("Informe o nome do proprietario: ");
                        conta[qtdConta].nomeProprietario = Console.ReadLine();
                        Console.WriteLine("Informe a agencia da conta: ");
                        conta[qtdConta].agencia = Console.ReadLine();
                        Console.WriteLine("Informe o numero da conta: ");
                        conta[qtdConta].numeroConta = Console.ReadLine();
                        Console.WriteLine("Informe o saldo da conta: ");
                        conta[qtdConta].saldo = Convert.ToDouble(Console.ReadLine());
                        qtdConta++;
                        break;
                    case "4":
                        Console.Clear();
                        for (int i = 0; i < qtdConta; i++)
                        {
                            Console.WriteLine
                            ($"---------XX--------XX---------\n" +
                            $"id: {conta[i].id}\n" +
                            $"nome: {conta[i].nomeProprietario}     agencia: {conta[i].agencia}\n" +
                            $"numero da conta: {conta[i].numeroConta}   saldo: R$ {conta[i].saldo}\n" +
                            $"---------XX--------XX---------\n");
                        }
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.Clear();
                        for (int i = 0; i < qtdConta; i++)
                        {
                            Console.WriteLine
                            ($"---------XX--------XX---------\n" +
                            $"id: {conta[i].id}\n" +
                            $"nome: {conta[i].nomeProprietario}     agencia: {conta[i].agencia}\n" +
                            $"numero da conta: {conta[i].numeroConta}   saldo: R$ {conta[i].saldo}\n" +
                            $"---------XX--------XX---------\n");
                        }

                        Console.WriteLine("\nDigite o id da conta depositante: ");
                        idTemp = Console.ReadLine();
                        for(int i = 0;i<qtdConta;i++)
                        {
                            if (String.Equals(idTemp, conta[i].id))
                            {
                                Console.Clear();
                                Console.WriteLine("Conta encontrada! ");
                                Console.WriteLine
                                ($"---------XX--------XX---------\n" +
                                $"id: {conta[i].id}\n" +
                                $"nome: {conta[i].nomeProprietario}     agencia: {conta[i].agencia}\n" +
                                $"numero da conta: {conta[i].numeroConta}   saldo: R$ {conta[i].saldo}\n" +
                                $"---------XX--------XX---------\n");

                                Console.WriteLine("\nInforme a quantidade que deseja depositar: ");
                                double valor = Convert.ToDouble(Console.ReadLine());
                                conta[i].Depositar(valor);
                            }
                        }
                        break;
                    case "6":
                        Console.Clear();
                        for (int i = 0; i < qtdConta; i++)
                        {
                            Console.WriteLine
                            ($"---------XX--------XX---------\n" +
                            $"id: {conta[i].id}\n" +
                            $"nome: {conta[i].nomeProprietario}     agencia: {conta[i].agencia}\n" +
                            $"numero da conta: {conta[i].numeroConta}   saldo: R$ {conta[i].saldo}\n" +
                            $"---------XX--------XX---------\n");
                        }

                        Console.WriteLine("\nDigite o id da conta sacadora: ");
                        idTemp = Console.ReadLine();
                        for (int i = 0; i < qtdConta; i++)
                        {
                            if (String.Equals(idTemp, conta[i].id))
                            {
                                Console.Clear();
                                Console.WriteLine("Conta encontrada! ");
                                Console.WriteLine
                                ($"---------XX--------XX---------\n" +
                                $"id: {conta[i].id}\n" +
                                $"nome: {conta[i].nomeProprietario}     agencia: {conta[i].agencia}\n" +
                                $"numero da conta: {conta[i].numeroConta}   saldo: R$ {conta[i].saldo}\n" +
                                $"---------XX--------XX---------\n");

                                Console.WriteLine("\nInforme a quantidade que deseja sacar: ");
                                double valor = Convert.ToDouble(Console.ReadLine());
                                conta[i].Sacar(valor);
                            }
                        }
                        break;

                    case "7":
                        Console.Clear();
                        for (int i = 0; i < qtdConta; i++)
                        {
                            Console.WriteLine
                            ($"---------XX--------XX---------\n" +
                            $"id: {conta[i].id}\n" +
                            $"nome: {conta[i].nomeProprietario}     agencia: {conta[i].agencia}\n" +
                            $"numero da conta: {conta[i].numeroConta}   saldo: R$ {conta[i].saldo}\n" +
                            $"---------XX--------XX---------\n");
                        }

                        bool loop1 = true;
                        double valor1 = 0.0;
                        int pos = 0;
                        do
                        {
                            Console.WriteLine("\nDigite o id da conta a receber: ");
                            idTemp = Console.ReadLine();
                            
                            for (int i = 0; i < qtdConta; i++)
                            {
                                if (String.Equals(idTemp, conta[i].id))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Conta encontrada! ");
                                    Console.WriteLine
                                    ($"---------XX--------XX---------\n" +
                                    $"id: {conta[i].id}\n" +
                                    $"nome: {conta[i].nomeProprietario}     agencia: {conta[i].agencia}\n" +
                                    $"numero da conta: {conta[i].numeroConta}   saldo: R$ {conta[i].saldo}\n" +
                                    $"---------XX--------XX---------\n");
                                    pos = i;
                                    loop1 = false;
                                }
                                if(pos == 0)
                                {
                                    Console.WriteLine("id não encontrado");
                                    Console.ReadKey();
                                }
                            }
                        } while (loop1);

                        Console.WriteLine("\nDigite o id da conta a pagar: ");
                        idTemp = Console.ReadLine();
                        for (int i = 0; i < qtdConta; i++)
                        {
                            if (String.Equals(idTemp, conta[i].id))
                            {
                                Console.Clear();
                                Console.WriteLine("Conta encontrada! ");
                                Console.WriteLine
                                ($"---------XX--------XX---------\n" +
                                $"id: {conta[i].id}\n" +
                                $"nome: {conta[i].nomeProprietario}     agencia: {conta[i].agencia}\n" +
                                $"numero da conta: {conta[i].numeroConta}   saldo: R$ {conta[i].saldo}\n" +
                                $"---------XX--------XX---------\n");
                                Console.WriteLine("\nInforme a quantidade que deseja transferir: ");
                                valor1 = Convert.ToDouble(Console.ReadLine());
                                conta[pos].Transferir(conta[i],valor1);
                            }
                        }
                        break;


                }
            }
        }
    }
}
