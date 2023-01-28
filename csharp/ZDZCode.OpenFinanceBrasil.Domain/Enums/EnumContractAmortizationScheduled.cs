using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Sistema de amortização (Vide Enum)
    /// </summary>
    public enum EnumContractAmortizationScheduled
    {
        /// <summary>
        /// (Sistema de Amortização Constante) - É aquele em que o valor da amortização permanece igual até o final. Os juros cobrados sobre o parcelamento não entram nesta conta.
        /// </summary>
        [Description("Sistema de Amortização Constante")]
        SAC = 1,

        /// <summary>
        /// (Sistema Francês de Amortização) - As parcelas são fixas do início ao fim do contrato. Ou seja, todas as parcelas terão o mesmo valor, desde a primeira até a última. Nos primeiros pagamentos, a maior parte do valor da prestação corresponde aos juros. Ao longo do tempo, a taxa de juros vai decrescendo. Como o valor da prestação é fixo, com o passar das parcelas, o valor de amortização vai aumentando.
        /// </summary>
        [Description("Sistema Francês de Amortização")]
        PRICE = 2,

        /// <summary>
        /// (Sistema de Amortização Misto) - Cada prestação (pagamento) é a média aritmética das prestações respectivas no Sistemas Price e no Sistema de Amortização Constante (SAC).
        /// </summary>
        [Description("Sistema de Amortização Misto")]
        SAM = 3,

        /// <summary>
        /// SEM SISTEMA DE AMORTIZAÇÃO
        /// </summary>
        [Description("SEM SISTEMA DE AMORTIZAÇÃO")]
        SEM_SISTEMA_AMORTIZACAO = 4,

        /// <summary>
        /// Outros.
        /// </summary>
        [Description("Outros")]
        OUTROS = 5,
    }
}
