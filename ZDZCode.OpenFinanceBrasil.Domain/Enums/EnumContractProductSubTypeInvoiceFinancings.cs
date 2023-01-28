using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Sub tipo da modalidades de crédito contratadas, conforme circular 4.015 e descrição do DOC3040 do SCR). (Vide Enum) Desconto de duplicatas, Desconto de cheques, Antecipação da fatura do cartão de crédito, Outros direitos creditórios descontados, Outros títulos descontados.
    /// </summary>
    public enum EnumContractProductSubTypeInvoiceFinancings
    {
        /// <summary>
        ///     
        /// </summary>
        [Description("")]
        DESCONTO_DUPLICATAS = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESCONTO_CHEQUES = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ANTECIPACAO_FATURA_CARTAO_CREDITO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS_DIREITOS_CREDITORIOS_DESCONTADOS = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS_TITULOS_DESCONTADOS = 5,
    }
}
