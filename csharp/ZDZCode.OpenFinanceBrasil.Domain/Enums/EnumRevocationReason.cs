using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Define o código da razão pela qual o consentimento foi revogado. Valores possíveis:  FRAUD - Indica suspeita de fraude  ACCOUNT_CLOSURE - Indica que a conta do usuário foi encerrada  OTHER - Indica que motivo do cancelamento está fora dos motivos pré-estabelecidos.
    /// </summary>
    public enum EnumRevocationReason
    {
        /// <summary>
        /// Indica suspeita de fraude.
        /// </summary>
        [Description("Indica suspeita de fraude")]
        FRAUD = 1,
        /// <summary>
        /// Indica que a conta do usuário foi encerrada.
        /// </summary>
        [Description("Indica que a conta do usuário foi encerrada")]
        ACCOUNT_CLOSURE = 2,
        /// <summary>
        /// Indica que motivo do cancelamento está fora dos motivos pré-estabelecidos.
        /// </summary>
        [Description("Indica que motivo do cancelamento está fora dos motivos pré-estabelecidos")]
        OTHER = 3,
    }
}
