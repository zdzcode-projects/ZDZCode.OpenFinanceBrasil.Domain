using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPhoneChannelsType
    {
        /// <summary>
        /// Central telefônica banking.
        /// </summary>
        [Description("")]
        CENTRAL_TELEFONICA = 1,

        /// <summary>
        /// SAC.
        /// </summary>
        [Description("")]
        SAC = 2,

        /// <summary>
        /// Ouvidoria.
        /// </summary>
        [Description("")]
        OUVIDORIA = 3,

        /// <summary>
        /// Outros.
        /// </summary>
        [Description("")]
        OUTROS = 4,
    }
}
