using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Códigos de erros previstos na criação de consentimento para a iniciação de pagamentos:
    /// • FORMA_PGTO_INVALIDA: Forma de pagamento inválida.
    /// • DATA_PGTO_INVALIDA: Data de pagamento inválida.
    /// • DETALHE_PGTO_INVALIDO: Detalhe do pagamento inválido.
    /// • NAO_INFORMADO: Não informado.
    /// </summary>
    public enum EnumErrorsCreateConsent
    {
        /// <summary>
        /// Forma de pagamento inválida.
        /// </summary>
        [Description("Forma de pagamento inválida")]
        FORMA_PGTO_INVALIDA = 1,

        /// <summary>
        /// Data de pagamento inválida.
        /// </summary>
        [Description("Data de pagamento inválida")]
        DATA_PGTO_INVALIDA = 2,

        /// <summary>
        /// Detalhe do pagamento inválido.
        /// </summary>
        [Description("Detalhe do pagamento inválido")]
        DETALHE_PGTO_INVALIDO = 3,

        /// <summary>
        /// Não informado.
        /// </summary>
        [Description("Não informado")]
        NAO_INFORMADO = 4,
    }
}
