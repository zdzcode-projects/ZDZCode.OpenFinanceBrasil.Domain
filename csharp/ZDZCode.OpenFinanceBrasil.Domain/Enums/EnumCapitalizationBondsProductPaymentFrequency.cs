using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Pagamento efetuado ao subscritor à sociedade de capitalização para aquisição do título de capitalização, podendo ser única, periódica ou mensal.
    /// </summary>
    public enum EnumCapitalizationBondsProductPaymentFrequency
    {
        /// <summary>
        /// Pagamento Único.
        /// </summary>
        [Description("Pagamento Único")]
        PAGAMENTO_UNICO = 1,

        /// <summary>
        /// Pagamento Mensal
        /// </summary>
        [Description("Pagamento Mensal")]
        PAGAMENTO_MENSAL = 2,

        /// <summary>
        /// Pagamento Periódico
        /// </summary>
        [Description("Pagamento Periódico")]
        PAGAMENTO_PERIODICO = 3,
    }
}
