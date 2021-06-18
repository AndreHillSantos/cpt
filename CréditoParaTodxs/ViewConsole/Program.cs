using Services;
using System;
using System.Linq;

namespace ViewConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao CréditoParaTodxs!\nAqui você poderá realizar um empréstimo pessoal de acordo com a sua saúde financeira.\nQual o valor da sua renda mensal?");

            var rendaInformada = Console.ReadLine();
            double valorRenda;

            while (!CreditoService.VerificarRenda(rendaInformada, out valorRenda))
            {
                Console.WriteLine($"Infelizmente a renda mensal informada não é válida. Por favor, informe um valor válido. (Valor de renda mínima: {CreditoService.RENDA_MINIMA:F2})");
                rendaInformada = Console.ReadLine();
            }

            var limiteCredito = CreditoService.CalcularLimiteCredito(valorRenda);

            Console.WriteLine($"Você possui o limite de crédito avaliado em {limiteCredito:F2}.\nQual valor você deseja contratar?");

            var creditoInformado = Console.ReadLine();
            double valorDesejado;

            while (!CreditoService.VerificarCredito(creditoInformado, limiteCredito, out valorDesejado))
            {
                Console.WriteLine($"O valor informado não é válido. O crédito mínimo é de {CreditoService.CREDITO_MINIMO:F2} e máximo é de {limiteCredito:F2}. Favor informar um valor entre os limites.");
                creditoInformado = Console.ReadLine();
            }

            var propostas = CreditoService.CarregarPropostas(valorRenda, valorDesejado);

            Console.WriteLine($"Estas são as propostas disponíveis para você. Selecione uma delas através de seu código para saber mais detalhes.");
            
            foreach(var proposta in propostas)
            {
                Console.WriteLine(proposta.Descricao);
            }

            Console.WriteLine("Qual proposta você deseja saber mais detalhes?");

            var codigoInformado = Console.ReadLine();
            double codigoSelecionado;

            while (!CreditoService.VerificarValor(codigoInformado, 1, 3, out codigoSelecionado))
            {
                Console.WriteLine($"O código informado não é válido. O código deve ser 1, 2 ou 3.");
                codigoInformado = Console.ReadLine();
            }

            var propostaSelecionada = propostas.FirstOrDefault(x => x.Codigo == codigoSelecionado);

            Console.WriteLine("Esta é a proposta selecionada por você.");
            Console.WriteLine(propostaSelecionada.Detalhes);
            Console.WriteLine("Deseja realizar a contratação desta proposta? (Digite 'S' para Sim ou 'N' para Não)");

            var propostaAceita = Console.ReadLine().ToUpper();

            while (propostaAceita != "S" && propostaAceita != "N")
            {
                Console.WriteLine("Não foi possível entender a confirmação. Por favor, digite 'S' para Sim ou 'N' para Não.");
                propostaAceita = Console.ReadLine().ToUpper();
            }

            if (propostaAceita == "S")
            {
                Console.WriteLine("Contratação efetuada com sucesso!");
            } 
            else
            {
                Console.WriteLine("Contratação recusada. Favor reiniciar o processo.");
            }
        }
    }
}
