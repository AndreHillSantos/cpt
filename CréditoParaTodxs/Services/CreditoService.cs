using Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public static class CreditoService
    {
        public const double RENDA_MINIMA = 1100.0;
        public const double CREDITO_MINIMO = 1000.0;
        private const double CREDITO_MAXIMO = 200000.0;
        private const double COEFICIENTE_CREDITO = 10.0;

        private static readonly int[] _parcelas = { 12, 24, 36 };

        public static bool VerificarValor(string valorInformado, double valorMinimo, double valorMaximo, out double valorRetorno)
        {
            if (double.TryParse(valorInformado, out valorRetorno))
            {
                return valorRetorno >= valorMinimo && valorRetorno <= valorMaximo;
            }

            return false;
        }

        public static bool VerificarRenda(string rendaInformada, out double valorRenda)
        {
            return VerificarValor(rendaInformada, RENDA_MINIMA, double.MaxValue, out valorRenda);
        }

        public static bool VerificarCredito(string creditoInformado, double limiteCredito, out double valorDesejado)
        {
            return VerificarValor(creditoInformado, CREDITO_MINIMO, limiteCredito, out valorDesejado);
        }

        public static double CalcularLimiteCredito(double valorRenda)
        {
            if (valorRenda > (CREDITO_MAXIMO / COEFICIENTE_CREDITO))
            {
                return CREDITO_MAXIMO;
            }

            return valorRenda * COEFICIENTE_CREDITO;
        }

        public static IEnumerable<Proposta> CarregarPropostas(double valorRenda, double valorDesejado)
        {
            var propostas = new List<Proposta>();

            foreach (var quantidadeParcelas in _parcelas)
            {
                propostas.Add(new Proposta(Array.IndexOf(_parcelas, quantidadeParcelas) + 1, valorDesejado, quantidadeParcelas, valorRenda));
            }

            return propostas;
        }
    }
}
