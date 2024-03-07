namespace POO_Voo
{
    internal class Program
    {

        public void ex1()
        {
            Voo v1 = new Voo(1, DateTime.Now, 100);
            v1.ocupa(1);
            v1.ocupa(2);
            v1.printarVoo();
            v1.vagasDisponiveis();

            Console.WriteLine(
                $"numero do voo: {v1.getVoo()}\n" +
                $"data do voo: {v1.getData()}");
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
          

        }
    }
}
