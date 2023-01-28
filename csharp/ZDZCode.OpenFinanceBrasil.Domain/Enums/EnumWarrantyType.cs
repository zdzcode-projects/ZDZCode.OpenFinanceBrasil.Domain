using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Denominação/Identificação do tipo da garantia que avaliza a Modalidade da Operação de Crédito contratada (Doc 3040, Anexo 12)
    /// </summary>
    public enum EnumWarrantyType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEM_TIPO_GARANTIA = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CESSAO_DIREITOS_CREDITORIOS = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CAUCAO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PENHOR = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ALIENACAO_FIDUCIARIA = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        HIPOTECA = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OPERACOES_GARANTIDAS_PELO_GOVERNO = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRAS_GARANTIAS_NAO_FIDEJUSSORIAS = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEGUROS_ASSEMELHADOS = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GARANTIA_FIDEJUSSORIA = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BENS_ARRENDADOS = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GARANTIAS_INTERNACIONAIS = 12,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OPERACOES_GARANTIDAS_OUTRAS_ENTIDADES = 13,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ACORDOS_COMPENSACAO = 14,
    }
}
