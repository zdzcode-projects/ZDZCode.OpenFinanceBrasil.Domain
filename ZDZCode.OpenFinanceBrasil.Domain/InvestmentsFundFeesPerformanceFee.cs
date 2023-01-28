using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFundFeesPerformanceFee
    {
        /// <summary>
        /// Metodologia do campo para taxa de performance.
        /// Passivo
        /// Ativo
        /// Ajuste
        /// </summary>
        public EnumInvestmentsFundFeesPerformanceFeeMethod Method { get; set; }

        /// <summary>
        /// Índice utilizado como referência para avaliação de desempenho do fundo de investimento.
        /// Em linha com padronização na listagem de fundos da ANBIMA, com opção “outros”, permitindo campo livre caso a opção não seja previamente fornecida.Listagem de benchmark disponível no link https://data.anbima.com.br/fundos , opção Características > Benchmark
        /// </summary>
        public EnumInvestmentsFundFeesPerformanceFeeBenchmark Benchmark { get; set; }

        /// <summary>
        /// Campo a ser preenchido pelas participantes quando houver ‘Outros’ no campo ‘Taxa de Performance - Benchmark’.
        /// </summary>
        public string BenchmarkAdditionalInfo { get; set; }

        /// <summary>
        /// Taxa cobrada do fundo em função de resultado conforme regras dispostas no regulamento do fundo.
        /// </summary>
        public string Amount { get; set; }
    }
}
