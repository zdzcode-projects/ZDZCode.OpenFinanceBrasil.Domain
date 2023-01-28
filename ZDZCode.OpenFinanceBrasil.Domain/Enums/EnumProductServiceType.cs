using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Lista com a relação dos produtos e serviços com contrato vigente.
    /// </summary>
    public enum EnumProductServiceType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CONTA_DEPOSITO_A_VISTA = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CONTA_POUPANCA = 2,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CONTA_PAGAMENTO_PRE_PAGA = 3,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CARTAO_CREDITO = 4,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OPERACAO_CREDITO = 5,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEGURO = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PREVIDENCIA = 7,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INVESTIMENTO = 8,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OPERACOES_CAMBIO = 9,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CONTA_SALARIO = 10,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CREDENCIAMENTO = 11,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 12,
       
    }
}
