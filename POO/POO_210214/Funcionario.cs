using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_210214
{
    internal class Funcionario
    {
        public string nome;
        public string cpf;
        public string email;
        public string senha;
        public string sexo;
        public DateTime dataNascimento;

        public void CalcularIdade ()
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
            int mesAtual = dataAtual.Month;
            int diaAtual = dataAtual.Day;

            int anoNascimento = dataNascimento.Year;
            int mesNascimento = dataNascimento.Month;
            int diaNascimento = dataNascimento.Day;

            /*
            dia = dia - diaF;
            if(dia<=0) mes--;
            mes = mes - mesF;
            if(mes<=0) ano--;
            ano = ano - anoF;
            */


            anoAtual = anoAtual - anoNascimento;
            if(mesAtual < mesNascimento)
            {
                anoAtual--;
            } else if (mesAtual == mesNascimento)
            {
                if(diaAtual < diaNascimento)
                {
                    anoAtual--;
                }
            }

            Console.WriteLine($"Idade: {anoAtual}");
            Console.ReadLine();





        }

    }
}
