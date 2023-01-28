using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPersonalFinancingRequiredWarranty
    {
        /// <summary>
        /// Cessão de direitos creditórios.
        /// </summary>
        [Description("")]
        CESSAO_DIREITOS_CREDITORIOS = 1,

        /// <summary>
        /// Caução.
        /// </summary>
        [Description("")]
        CAUCAO = 2,

        /// <summary>
        /// Penhor.
        /// </summary>
        [Description("")]
        PENHOR = 3,

        /// <summary>
        /// Alienação fiduciária.
        /// </summary>
        [Description("")]
        ALIENACAO_FIDUCIARIA = 4,

        /// <summary>
        /// Hipoteca.
        /// </summary>
        [Description("")]
        HIPOTECA = 5,

        /// <summary>
        /// Operações garantidas pelo governo.
        /// </summary>
        [Description("")]
        OPERACOES_GARANTIDAS_PELO_GOVERNO = 6,

        /// <summary>
        /// Outras garantias não fidejussórias.
        /// </summary>
        [Description("")]
        OUTRAS_GARANTIAS_NAO_FIDEJUSSORIAS = 7,

        /// <summary>
        /// Seguros e assemelhados.
        /// </summary>
        [Description("")]
        SEGUROS_ASSEMELHADOS = 8,

        /// <summary>
        /// Garantia fidejussória.
        /// </summary>
        [Description("")]
        GARANTIA_FIDEJUSSORIA = 9,

        /// <summary>
        /// Bens arrendados.
        /// </summary>
        [Description("")]
        BENS_ARRENDADOS = 10,

        /// <summary>
        /// Garantias internacionais.
        /// </summary>
        [Description("")]
        GARANTIAS_INTERNACIONAIS = 11,

        /// <summary>
        /// Operações garantidas por outras entidades.
        /// </summary>
        [Description("")]
        OPERACOES_GARANTIDAS_OUTRAS_ENTIDADES = 12,

        /// <summary>
        /// Acordos de compensação.
        /// </summary>
        [Description("")]
        ACORDOS_COMPENSACAO = 13,

        /// <summary>
        /// Não aplicável.
        /// </summary>
        [Description("")]
        NAO_APLICAVEL = 14,
    }
}
