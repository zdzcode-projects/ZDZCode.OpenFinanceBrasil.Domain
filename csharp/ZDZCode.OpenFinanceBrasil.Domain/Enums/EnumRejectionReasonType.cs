using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Motivo da rejeição do pagamento. Informações complementares sobre o motivo do status.
    /// </summary>
    public enum EnumRejectionReasonType
    {
        /// <summary>
        /// Liquidação da transação interrompida devido a timeout no SPI (AB03).
        /// </summary>
        [Description("Liquidação da transação interrompida devido a timeout no SPI (AB03)")]
        ABORTED_SETTLEMENT_TIMEOUT = 1,

        /// <summary>
        /// Transação interrompida devido a erro no participante do usuário recebedor (AB09).
        /// </summary>
        [Description("Transação interrompida devido a erro no participante do usuário recebedor (AB09)")]
        ERROR_CREDITOR_AGENT = 2,

        /// <summary>
        /// Timeout do participante emissor da ordem de pagamento (AB11).
        /// </summary>
        [Description("Timeout do participante emissor da ordem de pagamento (AB11)")]
        TIMEOUT_DEBTOR_AGENT = 3,

        /// <summary>
        /// Número da conta transacional do usuário recebedor inexistente ou inválido (AC03).
        /// </summary>
        [Description("Número da conta transacional do usuário recebedor inexistente ou inválido (AC03).")]
        INVALID_CREDITOR_ACCOUNT_NUMBER = 4,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        BLOCKED_ACCOUNT = 5,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        CLOSED_CREDITOR_ACCOUNT_NUMBER = 6,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_CREDITOR_ACCOUNTTYPE = 7,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        TRANSACTION_NOT_SUPPORTED = 8,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        NOT_ALLOWED_BOOK_TRANSFER = 9,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        FORBIDDEN_RETURN_PAYMENT = 10,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INCORRECT_AGENT = 11,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        ZERO_AMOUNT = 12,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        NOT_ALLOWED_AMOUNT = 13,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INSUFFICIENT_FUNDS = 14,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        WRONG_AMOUNT = 15,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_AMOUNT = 16,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_NUMBER_OF_TRANSACTIONS = 17,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INCONSISTENT_WITH_END_CUSTOMER = 18,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_IDENTIFICATION_CODE = 19,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_CREDITOR_IDENTIFICATION_CODE = 20,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        CREDITOR_IDENTIFIER_INCORRECT = 21,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        ELEMENT_CONTENT_FORMALLY_INCORRECT = 22,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        ORDER_REJECTED = 23,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        NOT_ALLOWED_PAYMENT = 24,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        NOT_ALLOWED_ACCOUNT = 25,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        USER_NOT_YET_ACTIVATED = 26,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_CREATION_DATE = 27,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_CUT_OFF_DATE = 28,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        SETTLEMENT_FAILED = 29,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_PURPOSE = 30,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_END_TO_END_ID = 31,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_DEBTOR_CLEARING_SYSTEM_MEMBER_IDENTIFIER = 32,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_CREDITOR_CLEARING_SYSTEM_MEMBER_IDENTIFIER = 33,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        REGULATORY_REASON = 34,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        SPECIFIC_SERVICE_OFFERED_BY_CREDITOR_AGENT = 35,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_BILL = 36,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        OPERATION_WINDOW = 37,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INCOMPATIBLE_DATE = 38,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        MISMATCH_AMOUNT = 39,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        OVER_LIMIT = 40,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        INVALID_CONSENT = 41,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        DENIED_MULTIPLE_AUTHORISATIONS = 42,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        EXPIRED_MULTIPLE_AUTHORISATIONS = 43,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        EXPIRED_BILL = 44,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        CONSENT_REVOKED = 45,

    }
}
