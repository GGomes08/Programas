namespace Desafios.Classes_Nuvens_de_Cinzas
{
    public class AtributosMetodos
    {
        //Metodos(ainda terá Metodos)
        public static int numeroAeroportos(char[,] mapa)
        {
            int contador = 0;

            for(int i = 0; i<mapa.GetLength(0);i++)
            {
                for(int j = 0; j<mapa.GetLength(1);j++)
                {
                    if(mapa[i,j] == 'A')
                    {
                        contador+=1;
                    }
                }
            }
            return contador;
        }

        public static char[,] expansao(char[,] mapa)
        {
            char[,] mapaEsperado = new char[5,5];

            for(int i = 0; i<mapa.GetLength(0);i++)
            {
                for(int j = 0; j<mapa.GetLength(1);j++)
                {
                    if(mapa[i,j]==' ')
                    {
                        mapaEsperado[i,j]= ' ';
                    }
                    if(mapa[i,j]=='*')
                    {
                        mapaEsperado[i,j]= '*';
                        mapaEsperado[i - 1,j]= '*';
                        mapaEsperado[i + 1,j]= '*';
                        mapaEsperado[i,j + 1]= '*';
                        mapaEsperado[i,j - 1]= '*';
                    }
                    if(mapa[i,j]=='A')
                    {
                        mapaEsperado[i,j] = 'A';
                    }
                }
            }
            return mapaEsperado;
        }
    }
}