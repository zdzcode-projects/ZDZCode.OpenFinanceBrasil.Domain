using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// dentificação do Tipo de telefone do cliente.
    /// </summary>
    public enum EnumCustomerPhoneType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FIXO = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MOVEL = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRO = 3,
    }
}
