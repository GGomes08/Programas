using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio I - Nuvens de Cinza");
            Console.WriteLine("Informe o número de linhas e colunas respectivamente para a matriz");
            var linhasColunas = Console.ReadLine().Split(' ');
            var linhas = int.Parse(linhasColunas[0]);
            var colunas = int.Parse(linhasColunas[1]);
            Console.WriteLine(linhas+ " " + colunas);


        }
    }
}
