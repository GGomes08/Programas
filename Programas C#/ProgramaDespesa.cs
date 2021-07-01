using System;
using System.Collections.Generic;

namespace Programas_C_
{
    class ProgramaDespesa
    {
        static void Main(string[] args)
        {
            List<Despesa> lista = new List<Despesa>();
            List<string> listaS = new List<string>();
            int op = 0;
            Console.WriteLine("Olá e seja bem vindo a aplicação de Despesas de Gustavo");
            Console.WriteLine("Informe seu nome para começarmos o programa.");
            string nomeUsuario = Console.ReadLine();
            float saldo = 0;
            float somaTotal = 0;

            do
            {
                Console.WriteLine("Nome do Usuario: " + nomeUsuario);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("=========================================");
                Console.WriteLine("<0>-Sair do Programa");
                Console.WriteLine("<1>-Add Despesa");
                Console.WriteLine("<2>-Eliminar Despesa");
                Console.WriteLine("<3>-Listar Despesa por adição ou por periodo");
                Console.WriteLine("<4>-Add Dinheiro na Conta");
                Console.WriteLine("<5>-Pagar Despesa de um periodo");
                Console.WriteLine("========================================");
                Console.Write("Opcão Selecionada:");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Opcao Sair do Programa");
                        Environment.Exit(0);
                        break;
                    case 1:
                        //Na primeira opção você adiciona a despesa com o nome, valor e o tempo de validade até pagar
                        Console.WriteLine("Opcao Adicionar Despesa");
                        Despesa desp;
                        string nome = Console.ReadLine();
                        float valor = float.Parse(Console.ReadLine());
                        DateTime dataCriada = DateTime.Now;
                        desp = new Despesa(nome, valor, dataCriada);
                        Console.WriteLine("Despesa Adicionado");
                        lista.Add(desp);
                        break;
                    case 2:
                        //Precisa ser desenvolvido melhor
                        Console.WriteLine("Opção Eliminar Despesa");
                        Console.WriteLine("Informe o Indice da Despesa para ser eliminada");
                        int count = 0;
                        foreach (Despesa item in lista)
                        {

                            Console.WriteLine("Indice:" + " " + count + item);
                            count++;
                            float somaAux = item.Valor;
                            somaTotal += somaAux;

                        }
                        Console.WriteLine(somaTotal);
                        int indiceDespesa = Convert.ToInt32(Console.ReadLine());
                        somaTotal = 0;


                        if (indiceDespesa > count)
                        {
                            Console.WriteLine("A Despesa não se encontra aqui, informe uma que exista");

                        }
                        else
                        {
                            lista.RemoveAt(indiceDespesa);
                            Console.WriteLine("A Despesa foi deletada");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Opcao Listar Despesas");
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("A lista se encontra vazia");
                        }
                        else
                        {
                            Console.WriteLine("Lista das Despesas");
                            foreach (Despesa item in lista)
                                Console.WriteLine(item);
                            Console.WriteLine("Aqui se encontram:" + lista.Count + " Despesas");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Opcao 4");
                        Console.WriteLine("Você deseja adicionar um saldo na conta, " + nomeUsuario + "?");
                        float saldoAdd = float.Parse(Console.ReadLine());

                        saldo += saldoAdd;

                        break;
                    case 5:
                        Console.WriteLine("Opcao 5");
                        break;
                }
            } while (op != 0 || op >= 6);
        }
    }
}