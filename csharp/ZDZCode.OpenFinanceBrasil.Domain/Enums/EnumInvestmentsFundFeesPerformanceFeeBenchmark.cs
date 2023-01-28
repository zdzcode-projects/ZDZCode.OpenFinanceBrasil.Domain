using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Índice utilizado como referência para avaliação de desempenho do fundo de investimento. Em linha com padronização na listagem de fundos da ANBIMA, com opção “outros”, permitindo campo livre caso a opção não seja previamente fornecida.Listagem de benchmark disponível no link https://data.anbima.com.br/fundos , opção Características > Benchmark
    /// </summary>
    public enum EnumInvestmentsFundFeesPerformanceFeeBenchmark
    {
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        CDI = 1,
        
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IBOVESPA_FECHAMENTO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IBOVESPA = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IMA_B = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IBRX = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IPCA = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IMA_B_5 = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        DOLAR_PTAX = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IBRX_100 = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        TAXA_SELIC = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IMA_B_5_PLUS = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IBOVESPA_MEDIO = 12,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IRF_M = 13,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IMA_GERAL = 14,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        INPC = 15,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IGP_M = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        SMLL_SMALL_CAP = 17,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IDA_IPCA = 18,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        ISE = 19,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IRF_M_1 = 20,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IBRX_50 = 21,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IDIV_DIVIDENDOS = 22,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IFIX = 23,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        GLOBAL_BDRX = 24,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IMA_S = 25,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IDKA_IPCA_2A = 26,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IRF_M_1_PLUS = 27,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        OUTROS = 28,     
    }
}
