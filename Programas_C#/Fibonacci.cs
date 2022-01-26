using System;

namespace Programas_C_
{
     class Fibonacci
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um numero:");
            numero = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i<=numero; i++)
            {
            Console.WriteLine("Fibonacci Recursivo: "+ fiboRec(i));
            }
            for(int i = 1; i<=numero; i++)
            {
            Console.WriteLine("Fibonacci Iterativo: "+ fiboIte(i));
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