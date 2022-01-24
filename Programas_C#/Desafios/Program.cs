using System;
using Desafios.Classes_Nuvens_de_Cinzas;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio I - Nuvens de Cinza");
            contaAeroportos();


        }

        public static void contaAeroportos(){

            char[,] mapa = new char[,]{
                {' ',' ',' ',' ',' '},
                {' ','*',' ',' ',' '},
                {'A',' ',' ','*',' '},
                {' ','*',' ',' ','A'},
                {' ',' ',' ',' ',' '},
            };

            char[,] mapaAtual = AtributosMetodos.expansao(mapa);
            int numAero = AtributosMetodos.numeroAeroportos(mapa);
            Console.WriteLine(mapaAtual[2,0]);
            Console.WriteLine(numAero);
        }
    }
}
