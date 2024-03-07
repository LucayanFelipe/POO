using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_280224
{
    internal class Aluno
    {
        public string nome;
        public string cpf;
        public string email;

        public bool verifycpf (string novoCpf)
        {
            if (novoCpf.Length == 11)
            {
                cpf = formatcpf(novoCpf);
                return false;
            } else
            {
                Console.WriteLine("CPF INVALIDO DIGITE NOVAMENTE! ");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
        }

        public string formatcpf (string novoCpf)
        {
            //025.147.052-07
            string formatado = novoCpf;
            formatado = formatado.Insert(3, ".");
            formatado = formatado.Insert(7, ".");
            formatado = formatado.Insert(11, "-");
            return formatado;
        }
    }

   
}
