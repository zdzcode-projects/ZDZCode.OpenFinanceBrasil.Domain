using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Identificação do Tipo de telefone da dependência. p.ex.FIXO, MOVEL
    /// </summary>
    public enum EnumPaymentStatusType
    {
        /// <summary>
        /// Iniciação de pagamento ou transação de pagamento está pendente. Checagens adicionais em realização.
        /// </summary>
        [Description("Iniciação de pagamento ou transação de pagamento está pendente. Checagens adicionais em realização")]
        PDNG = 1,

        /// <summary>
        /// Indica que o processo de agendamento está em processamento.
        /// </summary>
        [Description(" Indica que o processo de agendamento está em processamento")]
        SASP = 2,

        /// <summary>
        /// Indica que o processo de agendamento foi realizado.
        /// </summary>
        [Description("Indica que o processo de agendamento foi realizado")]
        SASC = 3,

        /// <summary>
        /// Aguardando autorização múltipla alçada.
        /// </summary>
        [Description("Aguardando autorização múltipla alçada")]
        PART = 4,

        /// <summary>
        /// Iniciação de pagamento aceita e processamento do pagamento foi iniciado.
        /// </summary>
        [Description("Iniciação de pagamento aceita e processamento do pagamento foi iniciado")]
        ACSP = 5,

        /// <summary>
        /// Débito realizado na conta do pagador.
        /// </summary>
        [Description("Débito realizado na conta do pagador")]
        ACSC = 6,

        /// <summary>
        ///  Crédito realizado na instituição de destino.
        /// </summary>
        [Description(" Crédito realizado na instituição de destino.")]
        ACCC = 7,

        /// <summary>
        /// Instrução de pagamento rejeitada.
        /// </summary>
        [Description("Instrução de pagamento rejeitada.")]
        RJCT = 8,
    }
}
