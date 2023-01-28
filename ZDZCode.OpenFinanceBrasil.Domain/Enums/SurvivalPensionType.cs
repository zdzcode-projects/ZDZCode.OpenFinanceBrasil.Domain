using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Identificação do Tipo de telefone da dependência. p.ex.FIXO, MOVEL
    /// </summary>
    public enum SurvivalPensionType
    {
        /// <summary>
        /// Telefone fixo.
        /// </summary>
        [Description("Telefone fixo")]
        PGBL = 1,
        
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        PRGP = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        PAGP = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        PRSA = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        PRI = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        PDR = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        VGBL = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        VRGP = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        VAGP = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        VRSA = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        VRI = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        VDR =12,

        /// <summary>
        /// Demais produtos de Previdência.
        /// </summary>
        [Description(" ")]
        DEMAIS_PRODUTOS_PREVIDENCIA = 13,
    }
}
