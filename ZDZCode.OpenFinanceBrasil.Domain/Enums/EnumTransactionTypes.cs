using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo de Transação
    /// </summary>
    public enum EnumTransactionTypes
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TED = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DOC = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PIX = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRANSFERENCIA_MESMA_INSTITUICAO = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BOLETO = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CONVENIO_ARRECADACAO = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PACOTE_TARIFA_SERVICOS = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TARIFA_SERVICOS_AVULSOS = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FOLHA_PAGAMENTO = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DEPOSITO = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SAQUE = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CARTAO = 12,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ENCARGOS_JUROS_CHEQUE_ESPECIAL = 13,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RENDIMENTO_APLIC_FINANCEIRA = 14,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PORTABILIDADE_SALARIO = 15,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RESGATE_APLIC_FINANCEIRA = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OPERACAO_CREDITO = 17,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 18,
    }
}
