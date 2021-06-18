using System;

namespace Models
{
    public class Proposta
    {
        public Proposta(int codigo, double valor, int parcelas, double renda)
        {
            Codigo = codigo;
            Valor = valor;
            Parcelas = parcelas;
            CalcularJuros(renda);
        }

        public int Codigo { get; private set; }
        public double Valor { get; private set; }
        public int Parcelas { get; private set; }
        private double Juros { get; set; }

        public string Descricao => $"[{Codigo}] Número de parcelas: {Parcelas} | Juros mensais: {Juros:F2}%";
        public string Detalhes => $"{Descricao}\nValor de crédito: {Valor:F2} | Valor da parcela: {CalcularValorParcela():F2} | Dia de vencimento das parcelas: 10";

        private void CalcularJuros(double renda)
        {
            if (renda < 5000)
            {
                Juros = 0.99;
            } 
            else if (renda < 10000)
            {
                Juros = 0.89;
            }
            else
            {
                Juros = 0.79;
            }
        }

        private double CalcularValorTotal()
        {
            var jurosEquivalentes = Math.Round((Math.Pow(1 + (Juros / 100), Parcelas) - 1) * 100, 2);

            return Math.Round(Valor + (Valor * (jurosEquivalentes / 100)), 2);
        }

        private double CalcularValorParcela()
        {
            var valorTotal = CalcularValorTotal();

            return Math.Round(valorTotal / Parcelas, 2);
        }
    }
}
