using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Voo
{
    internal class Voo
    {
        private DateTime dataHora;
        private int numMaxVagas;
        private int numVoo;
        private int [] vagas;

        public Voo(int numVoo, DateTime dataHora, int numMaxVagas)
        {
            this.numVoo = numVoo;
            this.dataHora = dataHora;
            this.numMaxVagas = numMaxVagas; 
            vagas = new int[numMaxVagas];

            //deixa todas as vagas disponiveis
            for (int i=1;i<numMaxVagas; i++)
            {
                vagas[i] = 0;
            }
        }

        public void printarVoo()
        {
            Console.WriteLine("POLTRONAS: (O) disponivel (X) indisponivel\n");
            for (int i =0;i<numMaxVagas;i++)
            {
                if (vagas[i]==0) Console.Write($"{i+1}: O\t");
                if (vagas[i] == 1) Console.Write($"{i+1}: X\t");
                if(i%10==0 && i!=0) Console.WriteLine();
            }
            Console.WriteLine();
        }

        public bool ocupa (int pos)
        {
            if (pos > 0)
            {
                pos--;
                //ocupa a vaga na posição especificada
                if (vagas[pos] == 0)
                {
                    vagas[pos] = 1;
                    Console.WriteLine($"Cadeira {pos+1} ocupada com sucesso!");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Cadeira {pos+1} indisponivel!");
                    return false;
                }
            } 
            else
            {
                Console.WriteLine($"Cadeira {pos+1} indisponivel!");
                return false;
            }
        }

        public int vagasDisponiveis()
        {
            int disponivel = 0;
            //verifica quais estão disponiveis
            for(int i=0;i<numMaxVagas;i++)
            {
                if (vagas[i] == 0) disponivel++;
                if (vagas[i] == 1)
                {
                    Console.WriteLine($"cadeira {i+1} ocupada!\n");
                }
            }
            return disponivel;
        }

        public void verifica(int pos)
        {
            pos--;
                if (vagas[pos] == 0)
                {
                    Console.WriteLine("Desocupado!");
                   
                }
                if (vagas[pos] == 1)
                {
                    Console.WriteLine("Ocupada!");
                   
                }
       
        }


        public int ProximoLivre()
        {
            for(int i=0;i<numMaxVagas;i++)
            {
                if (vagas[i]==0)
                {
                    Console.WriteLine($"cadeiras até {i-1} ocupada!");
                    Console.WriteLine($"cadeira {i} disponivel!");
                    return i;
                }
            }
            return 0;
        }

        public int getVoo ()
        {
            return numVoo;
        }
        public DateTime getData ()
        {
            return dataHora;
        }
        
        

    }
}
