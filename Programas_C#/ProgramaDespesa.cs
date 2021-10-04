using System;
using System.Collections.Generic;

namespace Programas_C_
{
    class ProgramaDespesa
    {
        static void Main(string[] args)
        {
            List<Despesa> lista = new List<Despesa>();
            int op = 0;
            Console
                .WriteLine("Olá e seja bem vindo a aplicação de Despesas de Gustavo");
            Console.WriteLine("Informe seu nome para começarmos o programa.");
            string nomeUsuario = Console.ReadLine();
            float saldo = 0;
            float somaTotal = 0;
            float somaAux = 0;

            do
            {
                Console.WriteLine("Nome do Usuario: " + nomeUsuario);
                Console.WriteLine("Saldo: R$" + saldo);
                Console.WriteLine("=========================================");
                Console.WriteLine("<0>-Sair do Programa");
                Console.WriteLine("<1>-Add Despesa");
                Console.WriteLine("<2>-Editar Despesa");
                Console.WriteLine("<3>-Eliminar Despesa");
                Console.WriteLine("<4>-Listar Despesa");
                Console.WriteLine("<5>-Add Dinheiro na Conta");
                Console.WriteLine("<6>-Fazer Especulação e Pagar Despesas de um periodo");
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
                        Console.WriteLine("");
                        Console.WriteLine("Opcao Adicionar Despesa");
                        Despesa desp;
                        Console.Write("Nome da Despesa:");
                        string nome = Console.ReadLine();
                        Console.Write("Valor da Despesa:");
                        float valor = float.Parse(Console.ReadLine());
                        Console.Write("Data de Validade da Despesa:(Ex: xx-xx-xxxx ou xx/xx/xxxx)");
                        string dataVal = Console.ReadLine();
                        DateTime dataValConv;
                        var dataValida =
                            DateTime.TryParse(dataVal, out dataValConv);
                        DateTime dataCriada = DateTime.Now;
                        desp =
                            new Despesa(nome, valor, dataCriada, dataValConv);
                        Console.WriteLine("Despesa Adicionado");
                        lista.Add (desp);
                        int count = 0;
                        foreach (Despesa item in lista)
                        {
                            Console.WriteLine("Indice:" + count + " " + item);
                            count++;
                            somaAux = item.Valor;
                        }

                        somaTotal += somaAux;

                        Console.WriteLine (somaTotal);
                        break;
                        case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Em breve nova função");
                        //Pensar na logica
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Opção Eliminar Despesa");
                        Console
                            .WriteLine("Informe o Indice da Despesa para ser eliminada");
                        count = 0;
                        foreach (Despesa item in lista)
                        {
                            Console.WriteLine("Indice:" + count + " " + item);
                            count++;

                            somaAux = item.Valor;
                        }
                        somaTotal += somaAux;
                        Console.WriteLine (somaTotal);
                        int indiceDespesa = Convert.ToInt32(Console.ReadLine());

                        if (indiceDespesa > count)
                        {
                            Console
                                .WriteLine("A Despesa não se encontra aqui, informe uma que exista");
                        }
                        else
                        {
                            lista.RemoveAt (indiceDespesa);
                            Console.WriteLine("A Despesa foi deletada");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Opcao Listar Despesas");
                        //Listagem por adição e periodo precisa ser revisada
                        /*Console
                            .WriteLine("Deseja listar por adição ou por periodo ?");
                        string opLista = Console.ReadLine();*/

                        if (lista.Count == 0)
                        {
                            Console.WriteLine("A lista se encontra vazia");
                        }
                        else
                        {
                            Console.WriteLine("Lista das Despesas");
                            foreach (Despesa item in lista)
                            {

                                somaAux = item.Valor;

                                Console.WriteLine(item);
                            }
                            somaTotal += somaAux;
                            Console.WriteLine("Aqui se encontram:" + lista.Count + " Despesas");
                            Console.WriteLine("Soma Total das Despesas:" + somaTotal);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Opcao 4");
                        Console
                            .WriteLine("Você deseja adicionar um saldo na conta, " +
                            nomeUsuario +
                            "?");
                        float saldoAdd = float.Parse(Console.ReadLine());

                        saldo += saldoAdd;

                        break;
                    case 6:
                        //Por hora fará a especulação de todas as despesas.
                        Console.WriteLine("Opcao 5");
                        float saldoFinal = saldo - somaTotal;
                        float despesaFinal = somaTotal - saldo;

                        if (saldo > somaTotal)
                        {
                            Console
                                .WriteLine("O saldo que restará caso pague estas despesas será de:" +
                                saldoFinal);
                        }
                        else if (saldo < somaTotal)
                        {
                            Console
                                .WriteLine("O saldo que possui não será o suficiente para pagar as despesas irá sobrar:" +
                                despesaFinal +
                                " para ser pago");
                        }
                        else if (saldo == somaTotal && saldo > 0)
                        {
                            Console
                                .WriteLine("Seu saldo é suficiente para estas despesas, precisará adicionar mais saldo para especular a quitação das despesas");
                        }
                        else if (saldo == 0)
                        {
                            Console
                                .WriteLine("Seu saldo se encontra zerado para a especulação de despesas");
                        }
                        break;
                }
            }
            while (op != 0 || op >= 7);
        }
    }
}
