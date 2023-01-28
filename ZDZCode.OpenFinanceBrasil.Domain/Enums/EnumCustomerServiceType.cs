using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Rede de atendimento do seguro contratado. A considerar os domínios: 1. Rede Referenciada 2. Livre Escolha 3. Rede Referenciada e Livre Escolha
    /// </summary>
    public enum EnumCustomerServiceType
    {
        /// <summary>
        /// Rede Referenciada.
        /// </summary>
        [Description("Rede Referenciada")]
        REDE_REFERENCIADA = 1,

        /// <summary>
        /// Livre Escolha.
        /// </summary>
        [Description("Livre Escolha")]
        LIVRE_ESCOLHA = 2,

        /// <summary>
        /// Rede Referenciada e Livre Escolha.
        /// </summary>
        [Description("Rede Referenciada e Livre Escolha")]
        REDE_REFERENCIADA_LIVRE_ESCOLHA = 3,
    }
}
