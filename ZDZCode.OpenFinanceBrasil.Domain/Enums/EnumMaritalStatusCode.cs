using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Estado marital do cliente.
    /// </summary>
    public enum EnumMaritalStatusCode
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SOLTEIRO = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CASADO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        VIUVO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEPARADO_JUDICIALMENTE = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DIVORCIADO = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        UNIAO_ESTAVEL = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRO = 7,

    }
}
