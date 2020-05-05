using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string nomeH, nomeM, idadeH, idadeM;


                //ESCREVE NA TELA "INFORME O NOME DA MULHER"
                Console.WriteLine("informe o nome da mulher");

                //TRAVA O A FRASE ACIMA NA TELA
                nomeM = Console.ReadLine();

                //ESCREVE NA TELA "INFORME O NOME DA MULHER"
                Console.WriteLine("informe o nome do homem");

                //TRAVA O A FRASE ACIMA NA TELA
                nomeH = Console.ReadLine();

                //ESCREVE NA TELA "informe a idade do homem"
                Console.WriteLine("informe a idade do homem");

                //TRAVA O A FRASE ACIMA NA ELA
                idadeH = Console.ReadLine();

                //ESCREVE NA TELA "informe a idade da mulher"
                Console.WriteLine("informe a idade da mulher");

                //TRAVA O A FRASE ACIMA NA ELA
                idadeM = Console.ReadLine();
               

                int divisao = Convert.ToInt32(idadeH) / Convert.ToInt32(idadeM);

                Console.WriteLine($"A divisão das idades é {divisao}");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}
