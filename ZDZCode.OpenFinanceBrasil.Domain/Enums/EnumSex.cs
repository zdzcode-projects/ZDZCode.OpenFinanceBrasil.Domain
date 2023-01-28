using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    ///  "Conjunto de características anatomofisiológicas que distinguem o homem e a mulher: Sexo masculino; sexo feminino". No caso de não ser feminino nem masculino é classificado como 'OUTRO'
    /// </summary>
    public enum EnumSex
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FEMININO = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MASCULINO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        NAO_DISPONIVEL = 4,
    }
}
