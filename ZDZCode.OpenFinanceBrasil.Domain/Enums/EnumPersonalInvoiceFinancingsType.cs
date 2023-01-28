using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPersonalInvoiceFinancingsType
    {
        /// <summary>
        /// Desconto de duplicatas.
        /// </summary>
        [Description("Desconto de duplicatas")]
        DESCONTO_DUPLICATAS = 1,

        /// <summary>
        /// Desconto de cheques.
        /// </summary>
        [Description("Desconto de cheques")]
        DESCONTO_CHEQUES = 2,

        /// <summary>
        /// Antecipação de fatura de cartão de crédito.
        /// </summary>
        [Description("Antecipação de fatura de cartão de crédito")]
        ANTECIPACAO_FATURA_CARTAO_CREDITO = 3,

        /// <summary>
        /// Outros direitos creditórios descontados.
        /// </summary>
        [Description("Outros direitos creditórios descontados")]
        OUTROS_DIREITOS_CREDITORIOS_DESCONTADOS = 4,

        /// <summary>
        /// Outros títulos descontados.
        /// </summary>
        [Description("Outros títulos descontados")]
        OUTROS_TITULOS_DESCONTADOS = 5,
    }
}
