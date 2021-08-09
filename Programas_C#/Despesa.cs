using System;

class Despesa
{
    string nomeDespesa;
    float valor;
    DateTime dataHora;

    DateTime dataValidade;


    public Despesa()
    {

    }

    public Despesa(string nomeDespesa, float valor, DateTime dataHora, DateTime dataValidade)
    {
        NomeDespesa = nomeDespesa;
        Valor = valor;
        DataHora = dataHora;
        DataValidade = dataValidade; 


    }

    public float Valor { get => valor; set => valor = value; }
    public DateTime DataHora { get => dataHora; set => dataHora = value; }
   
    public string NomeDespesa { get => nomeDespesa; set => nomeDespesa = value; }
    public DateTime DataValidade { get => dataValidade; set => dataValidade = value; }

    public override string ToString()
   {
       return "Nome Despesa: " + nomeDespesa.ToString() + " Valor da Despesa: " + valor.ToString() + " Data e Hora da Criação da Despesa: " + dataHora.ToString() + " Data de Validade: " + dataValidade.ToString();
   }

}