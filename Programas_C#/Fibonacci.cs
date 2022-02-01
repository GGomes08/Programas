using System;

namespace Programas_C_
{
     class Fibonacci
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um termo de Fibonacci:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite agora 'R'(Fibonacci Recursivo) ou 'I'(Fibonacci Iterativo):");
            char letra = Convert.ToChar(Console.ReadLine());

            if(letra == 'R')
            {
            for(int i = 1; i<=numero; i++)
            {
            Console.WriteLine("Fibonacci Recursivo: "+ fiboRec(i));
            }
            }
            else if(letra == 'I')
            {
            for(int i = 1; i<=numero; i++)
            {
            Console.WriteLine("Fibonacci Iterativo: "+ fiboIte(i));
            }
            }
        }

        static int fiboRec(int numero)
        {
            if(numero > 1)
            {
                return fiboRec(numero-1)+ fiboRec(numero-2);
            }
            else
            {
                if(numero==1) return 1;
                else return 0;
            }
        }

        static int fiboIte(int numero)
        {
            int inicio=0;
            int prox= 1;
            int aux= 0;

            for(int i= 1; i< numero; i++)
            {
                aux= inicio+prox;
                inicio=prox;
                prox= aux;
            }
            return aux;
        }
        
    }
}