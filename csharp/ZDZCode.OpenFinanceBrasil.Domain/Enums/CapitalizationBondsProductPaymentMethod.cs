using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Meio de Pagamento utilizado para pagamento da contribuição.
    /// </summary>
    public enum CapitalizationBondsProductPaymentMethod
    {
        /// <summary>
        /// Cartão de Crédito
        /// </summary>
        [Description("Cartão de Crédito")]
        CARTAO_CREDITO = 1,

        /// <summary>
        /// Cartão de Débito
        /// </summary>
        [Description("Cartão de Débito")]
        CARTAO_DEBITO = 2,

        /// <summary>
        /// Débito em conta corrente
        /// </summary>
        [Description("Débito em conta corrente")]
        DEBITO_CONTA_CORRENTE = 3,

        /// <summary>
        /// Débito em conta poupança
        /// </summary>
        [Description("Débito em conta poupança")]
        DEBITO_CONTA_POUPANCA = 4,

        /// <summary>
        /// Boleto bancário
        /// </summary>
        [Description("Boleto bancário")]
        BOLETO_BANCARIO = 5,

        /// <summary>
        /// PIX
        /// </summary>
        [Description("PIX")]
        PIX = 6,

        /// <summary>
        /// Consignação em Folha de Pagamento
        /// </summary>
        [Description("Consignação em Folha de Pagamento")]
        CONSIGNACAO_FOLHA_PAGAMENTO = 7,

        /// <summary>
        /// Pontos de Programas de Benefício
        /// </summary>
        [Description("Pontos de Programas de Benefício")]
        PAGAMENTO_PONTOS = 8,

        /// <summary>
        /// Outros
        /// </summary>
        [Description("Outros")]
        OUTROS = 9,

        

}
}
