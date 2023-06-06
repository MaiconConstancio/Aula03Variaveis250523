using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Variaveis
{
    class Program
    {
        static void Main(string[] args)                       
        {
            // A variavel String (Criador) trás o nome que é a váriavel (NOME QUE QUER COLOCAR)
            string criador = "MK"; // variavel para nome
            int idade = 23; // variavel para numero
            float dinheiro = 2.50f;
            int soma = 52 + 77; // Dá para somar na variável

            float peso = 64.0f;
            float altura = 1.79f;
            float imc = peso / (altura * altura);

            Console.WriteLine($"Meu imc é {imc}\n\n");


            ///Console.Write("Meu nome é " + criador); /// Segunda forma de escrever o codico de cima
            ///Console.Write(" e eu tenho " + idade);
            ///Console.WriteLine(" anos.");

            //Console.WriteLine("Meu nome é " + criador + " e eu tenho " + idade + " anos."); /// Forma antiga, (usada antes de 2015) = CONCATENAÇÃO

            Console.WriteLine($"Meu nome é {criador} e eu tenho {idade} anos."); /// Forma moderna (Implementado em 2015) = interpolação


            Console.WriteLine($"Na minha carteira tem {dinheiro} Reais");


            Console.WriteLine("Aula 03 variáveis");
            Console.WriteLine("Programa Criado por " + criador);
            // Juntar um Texto com outro se chama CONCATENAÇÃO
            Console.WriteLine("Minha idade é " + idade);

            Console.WriteLine("Eu sou o " + criador);
            Console.WriteLine("Lembrando quem fez foi o " + criador);








            Console.ReadKey(true); // Trava a tela
        }
    }
}
