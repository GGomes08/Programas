using System;

class Despesa
{
    string nomeDespesa;
    float valor;
    DateTime dataHora;


    public Despesa()
    {

    }

    public Despesa(string nomeDespesa, float valor, DateTime dataHora)
    {
        NomeDespesa = nomeDespesa;
        Valor = valor;
        DataHora = dataHora;

    }

    public float Valor { get => valor; set => valor = value; }
    public DateTime DataHora { get => dataHora; set => dataHora = value; }
    public string NomeDespesa { get => nomeDespesa; set => nomeDespesa = value; }


   public override string ToString()
   {
       return "Nome Despesa: " + nomeDespesa.ToString() + " Valor da Despesa: " + valor.ToString() + " Data e Hora da Criação da Despesa: " + dataHora.ToString();
   }

}