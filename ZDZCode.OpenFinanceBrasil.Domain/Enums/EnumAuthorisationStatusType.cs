using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Retorna o estado do consentimento, o qual no momento de sua criação será AWAITING_AUTHORISATION. Este estado será alterado depois da autorização do consentimento na detentora da conta do pagador(Debtor) para AUTHORISED, REJECTED ou REVOKED.  O consentimento fica no estado CONSUMED após ocorrer a iniciação do pagamento referente ao consentimento. Em caso de consentimento expirado a detentora deverá retornar o status REJECTED. Em caso de revogação do consentimento a detentora deverá retornar o status REVOKED.
    /// Estados possíveis:
    /// AWAITING_AUTHORISATION - Aguardando autorização
    /// AUTHORISED - Autorizado
    /// REJECTED - Rejeitado
    /// CONSUMED - Consumido
    /// REVOKED - Revogado
    /// </summary>
    public enum EnumAuthorisationStatusType
    {
        /// <summary>
        /// Aguardando autorização
        /// </summary>
        [Description("Aguardando autorização")]
        AWAITING_AUTHORISATION = 1,

        /// <summary>
        /// Autorizado
        /// </summary>
        [Description("Autorizado")]
        AUTHORISED = 2,

        /// <summary>
        /// Rejeitado
        /// </summary>
        [Description("Rejeitado")]
        REJECTED = 3,

        /// <summary>
        /// Consumido
        /// </summary>
        [Description("Consumido")]
        CONSUMED = 4,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Revogado")]
        REVOKED = 5,
    }
}
