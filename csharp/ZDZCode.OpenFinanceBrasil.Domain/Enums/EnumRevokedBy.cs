using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Define qual das partes envolvidas na transação está realizando a revogação. Valores possíveis: - USER (Revogado pelo usuário) - ASPSP (Provedor de serviços de pagamento para serviços de conta - Detentora de conta) - TPP (Instituições Provedoras - iniciadora de pagamentos)
    /// </summary>
    public enum EnumRevokedBy
    {
        /// <summary>
        /// USER (Revogado pelo usuário)
        /// </summary>
        [Description("USER (Revogado pelo usuário)")]
        USER = 1,
        /// <summary>
        /// ASPSP (Provedor de serviços de pagamento para serviços de conta - Detentora de conta)
        /// </summary>
        [Description("ASPSP (Provedor de serviços de pagamento para serviços de conta - Detentora de conta)")]
        ASPSP = 2,
        /// <summary>
        /// TPP (Instituições Provedoras - iniciadora de pagamentos)
        /// </summary>
        [Description("TPP (Instituições Provedoras - iniciadora de pagamentos)")]
        TPP = 3,
    }
}
