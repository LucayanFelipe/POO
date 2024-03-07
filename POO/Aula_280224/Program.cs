namespace Aula_280224
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno aluno;
            string menu="";
            int pos = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1: cadastrar aluno\n2: consultar alunos\n3: excluir aluno\n4: atualizar dados de um aluno\n0: parar o programa");
                menu = Console.ReadLine();

                switch(menu)
                {
                    case "1":
                        Console.Clear();
                        aluno = new Aluno();
                        Console.WriteLine("Informe um nome: ");
                        aluno.nome = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Informe o cpf: ");
                            aluno.cpf = Console.ReadLine();
                        } while (aluno.verifycpf(aluno.cpf));
                        Console.WriteLine("Informe o email: ");
                        aluno.email = Console.ReadLine();
                        alunos.Add(aluno);
                        break;
                    case "2":
                        Console.Clear();
                        for (int i=0; i<alunos.Count;i++)
                        {
                            Console.WriteLine($"{i+1}º aluno(a): {alunos[i].nome}\n" +
                                $"cpf: {alunos[i].cpf}\n" +
                                $"email: {alunos[i].email}\n");
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        for (int i = 0; i < alunos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}º aluno(a): {alunos[i].nome}\n" +
                                $"cpf: {alunos[i].cpf}\n" +
                                $"email: {alunos[i].email}\n");
                        }
                        Console.WriteLine("\nDigite a posição do aluno que deseja deletar!");
                        pos = Convert.ToInt32(Console.ReadLine());
                        alunos.RemoveAt(pos-1);
                        break;
                    case "4":
                        Console.Clear();
                        for (int i = 0; i < alunos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}º aluno(a): {alunos[i].nome}\n" +
                                $"cpf: {alunos[i].cpf}\n" +
                                $"email: {alunos[i].email}\n");
                        }
                        Console.WriteLine("\nDigite a posição do aluno que deseja atualizar os dados!");
                        pos = Convert.ToInt32(Console.ReadLine());
                        pos--;
                        Console.WriteLine("Informe um nome: ");
                        alunos[pos].nome = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Informe o cpf: ");
                            alunos[pos].cpf = Console.ReadLine();
                        } while (alunos[pos].verifycpf(alunos[pos].cpf));
                        Console.WriteLine("Informe o email: ");
                        alunos[pos].email = Console.ReadLine();

                        break;
                    case "0":
                        menu = "stop";
                        break;
                }


            } while (menu!="stop");

            


           
        }
    }
}
