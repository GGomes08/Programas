// See https://aka.ms/new-console-template for more information
namespace Programas_CSharp{

    class Compactador{
        public static void Main(string[] args){
            var caminhoArq = "./";
            var arqTexto = "textoDescompactado.txt";
            var arqTextoSaida = "textoCompactado.txt";
            var caminhoCompleto = caminhoArq + arqTexto;
            var caminhoCompactado = caminhoArq + arqTextoSaida;

            if (!Directory.Exists(caminhoArq))
                File.Create(caminhoArq);

            if (!File.Exists(caminhoCompleto))
                File.Create(caminhoCompleto);

            using (var sw = new StreamWriter(caminhoCompleto))
            {
                sw.WriteLine("Dear Sally,");
                sw.WriteLine("Please, please do it--it would please");
                sw.WriteLine("Mary very, very much. And Mary would");
                sw.WriteLine("do everything in Mary's power to make");
                sw.WriteLine("it pay off for you.");
                sw.WriteLine("-- Thank you very much --");
                sw.WriteLine("0");
                sw.Close();
            }

            string[] vet = new string[100];
            char letra;
            int pos = 0;
            int contPalavras = 0;
            string palavra = "";
            bool verifica = false;
            StreamReader entrada = new StreamReader(caminhoCompleto);
            StreamWriter saida = new StreamWriter(caminhoCompactado);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Seja Bem Vindo a Aplicação de compactar um arquivo texto");
            Console.WriteLine("Iremos compactar o conteudo que se encontra no"
                    + " arquivo texto nomeado como 'textoDescompactado'.");
            do
            {
                letra = (char)entrada.Read();

                if (Char.IsLetter(letra))
                {
                    palavra += letra;
                }
                else
                {
                    if (palavra.Length != 0)
                    {
                        pos = BuscaRecursiva(vet, palavra, 0, vet.Length - 1);
                        if (pos == -1)
                        {
                            saida.Write(palavra);

                        }
                        else if (pos >= 0)
                        {
                            verifica = VerificaPal(vet, palavra, pos);
                            if ((pos >= 0) && (verifica = true))
                            {
                                RemovePal(vet, pos);
                                saida.Write(pos + 1 + "");

                            }
                        }

                        InserePalavras(vet, palavra, contPalavras);
                        palavra = "";
                    }
                    saida.Write(letra);

                }

            } while (letra != '0');
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Por favor, verifique o 'textoCompactado.txt' localizado na pasta de documentos!");

            entrada.Close();
            saida.Close();
        }
        static int BuscaRecursiva(String[] vet, String palavra, int esq, int dir)
        {
            if (dir < esq)
            {
                return -1;
            }
            if (palavra.Equals(vet[esq]))
            {
                return esq;
            }
            return BuscaRecursiva(vet, palavra, esq + 1, dir);
        }
        //Metodo que insere as Palavras
        static void InserePalavras(String[] vet, String x, int cont)
        {
            for (int i = vet.Length - 1; i > 0; i--)
            {
                if (vet[i - 1] != null)
                {
                    vet[i] = vet[i - 1];
                    cont++;
                }
            }
            vet[0] = x;
        }

        static void RemovePal(String[] vet, int a)
        {
            if (a >= 0 && a < vet.Length)
            {
                for (int i = a; i < vet.Length - 1; i++)
                {
                    vet[i] = vet[i + 1];
                    vet[i + 1] = null;

                }

            }

        }
        static bool VerificaPal(String[] vet, String a, int b)
        {
            if (a.Equals(vet[b]))
            {
                return true;
            }
            return false;
        }
    }
}
