using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Identificação do Tipo de telefone da dependência. p.ex.FIXO, MOVEL
    /// </summary>
    public enum EnumBranchPhoneType
    {
        /// <summary>
        /// Telefone fixo.
        /// </summary>
        [Description("Telefone fixo")]
        FIXO = 1,
        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        MOVEL = 2,
    }
}
