using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_heranca_0708
{
    internal class Program
    {




        static void Main(string[] args)
        {
            string menu = "";
         
            while(menu!="0")
            {
                Console.Clear();
                Console.WriteLine("SELECIONE UMA OPÇÃO\n" +
                    "1: Passeio\n2: Utilitario\n3: Onibus\n4: Caminhao\n0: sair");
                menu = Console.ReadLine();
                switch(menu)
                {
                    case "1":
                        Console.Clear();
                        Passeio p = new Passeio();
                        Console.WriteLine("Informe a placa: ");
                        p.setPlaca(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Informe a quantidade de eixos");
                            p.setEixos(Convert.ToInt32(Console.ReadLine()));
                        } catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                        while(p.getTipo()!=1 && p.getTipo() != 2 && p.getTipo() != 3)
                        {
                            
                            Console.Clear();
                            try
                            {
                                Console.WriteLine($"Informe o tipo de veiculo:\n" +
                            $"1: pessoa fisica\n2: pessoa juridica\n3: oficial");
                                p.setTipo(Convert.ToInt32(Console.ReadLine()));
                            } catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        p.CalcularPedagio();
                        p.CalcularDesconto();
                        Console.WriteLine($"PEDAGIO CALCULADO: R$ {p.getPrecoPedagio()}\n" +
                            $"TIPO: {p.getTipo()} DESCONTO APLICADO!\n" +
                            $"VALOR FINAL QUE CLIENTE DEVE PAGAR: R$ {p.getValorFinal()}");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Utilitario u = new Utilitario();
                        Console.WriteLine("Informe a placa: ");
                        u.setPlaca(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Informe a quantidade de eixos");
                            u.setEixos(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                        while (u.getTipo() != 1 && u.getTipo() != 2 && u.getTipo() != 3)
                        {

                            Console.Clear();
                            try
                            {
                                Console.WriteLine($"Informe o tipo de veiculo:\n" +
                            $"1: pessoa fisica\n2: pessoa juridica\n3: oficial");
                                u.setTipo(Convert.ToInt32(Console.ReadLine()));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        u.CalcularPedagio();
                        u.CalcularDesconto();
                        Console.WriteLine($"PEDAGIO CALCULADO: R$ {u.getPrecoPedagio()}\n" +
                             $"TIPO: {u.getTipo()} DESCONTO APLICADO!\n" +
                             $"VALOR FINAL QUE CLIENTE DEVE PAGAR: R$ {u.getValorFinal()}");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Onibus o = new Onibus();
                        Console.WriteLine("Informe a placa: ");
                        o.setPlaca(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Informe a quantidade de eixos");
                            o.setEixos(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                        while (o.getTipo() != 1 && o.getTipo() != 2 && o.getTipo() != 3)
                        {

                            Console.Clear();
                            try
                            {
                                Console.WriteLine($"Informe o tipo de veiculo:\n" +
                            $"1: pessoa fisica\n2: pessoa juridica\n3: oficial");
                                o.setTipo(Convert.ToInt32(Console.ReadLine()));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        o.CalcularPedagio();
                        o.CalcularDesconto();
                        Console.WriteLine($"PEDAGIO CALCULADO: R$ {o.getPrecoPedagio()}\n" +
                             $"TIPO: {o.getTipo()} DESCONTO APLICADO!\n" +
                             $"VALOR FINAL QUE CLIENTE DEVE PAGAR: R$ {o.getValorFinal()}");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Caminhao c = new Caminhao();
                        Console.WriteLine("Informe a placa: ");
                        c.setPlaca(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Informe a quantidade de eixos");
                            c.setEixos(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                        while (c.getTipo() != 1 && c.getTipo() != 2 && c.getTipo() != 3)
                        {

                            Console.Clear();
                            try
                            {
                                Console.WriteLine($"Informe o tipo de veiculo:\n" +
                            $"1: pessoa fisica\n2: pessoa juridica\n3: oficial");
                                c.setTipo(Convert.ToInt32(Console.ReadLine()));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        c.CalcularPedagio();
                        c.CalcularDesconto();
                        Console.WriteLine($"PEDAGIO CALCULADO: R$ {c.getPrecoPedagio()}\n" +
                             $"TIPO: {c.getTipo()} DESCONTO APLICADO!\n" +
                             $"VALOR FINAL QUE CLIENTE DEVE PAGAR: R$ {c.getValorFinal()}");
                        Console.ReadKey();
                        break;
                }
            }
          
    
        }
    }
}
