using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Códigos de erros previstos na revogação do consentimento de pagamento
    /// </summary>
    public enum EnumErrorsPatchConsent
    {
        /// <summary>
        /// O campo data.revocation.loggedUser deve ser preenchido quando a revogação for feita pelo usuário final, ou seja, se o campo data.revocation.revokedBy estiver com o valor USER.
        /// </summary>
        [Description("Telefone fixo")]
        INFORMACAO_USUARIO_REQUERIDA = 1,
        /// <summary>
        /// O consentimento só pode ser revogado nos status CONSUMED.
        /// </summary>
        [Description("Telefone móvel")]
        OPERACAO_NAO_PERMITIDA_STATUS = 2,
        /// <summary>
        /// Somente consentimentos para pagamentos agendados podem ser revogados, ou seja, que possuam o campo data.payment.schedule preenchido.
        /// </summary>
        [Description("Telefone móvel")]
        OPERACAO_NAO_SUPORTADA_TIPO_CONSENTIMENTO = 3,
        /// <summary>
        /// O consentimento só pode ser revogado até o dia anterior, ou seja, a meia noite no fuso horário de Brasília do dia imediatamente anterior a data alvo da liquidação do pagamento.
        /// </summary>
        [Description("Telefone móvel")]
        TEMPO_LIMITE_REVOGACAO_EXCEDIDO = 4,
        /// <summary>
        /// Os motivos de revogação do consentimento: FRAUD e ACCOUNT_CLOSURE só podem ser usados caso o campo: data.revocation.revokedBy tenha o valor TPP ou ASPSP, ou seja, somente no caso de revogação unilateral pela iniciadora ou detentora.
        /// </summary>
        [Description("Telefone móvel")]
        MOTIVO_REVOGACAO_NAO_PERMITIDO = 5,
        /// <summary>
        /// O campo data.revocation.reason.additionalInformation é obrigatório quando a revogação for feita pela iniciadora ou pela detentora unilateralmente, ou seja, o campo revokedBy igual a TPP ou ASPSP e o motivo de revogação for OTHER.
        /// </summary>
        [Description("Telefone móvel")]
        INFORMACAO_ADICIONAL_REVOGACAO_REQUERIDA = 6,
    }
}
