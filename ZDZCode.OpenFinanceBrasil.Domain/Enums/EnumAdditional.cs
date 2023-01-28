using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Identificação do Tipo de telefone da dependência. p.ex.FIXO, MOVEL
    /// </summary>
    public enum EnumAdditional
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SORTEIO = 1,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SERVICOS_ASSISTENCIAS_COMPLEMENTARES_PAGO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SERVICOS_ASSISTENCIA_COMPLEMENTARES_GRATUITO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        NAO_HA = 5,
    }
}
