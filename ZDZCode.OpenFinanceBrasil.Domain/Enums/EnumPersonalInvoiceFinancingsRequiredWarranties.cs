
using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPersonalInvoiceFinancingsRequiredWarranties
    {
        /// <summary>
        /// Cessão de direitos creditórios.
        /// </summary>
        [Description("Cessão de direitos creditórios")]
        CESSAO_DIREITOS_CREDITORIOS = 1,

        /// <summary>
        /// Caução.
        /// </summary>
        [Description("Caução")]
        CAUCAO = 2,

        /// <summary>
        /// Penhor.
        /// </summary>
        [Description("Penhor")]
        PENHOR = 3,

        /// <summary>
        /// Alienação fiduciária.
        /// </summary>
        [Description("Alienação fiduciária")]
        ALIENACAO_FIDUCIARIA = 4,

        /// <summary>
        /// Hipoteca.
        /// </summary>
        [Description("Hipoteca")]
        HIPOTECA = 5,

        /// <summary>
        /// Operações garantidas pelo governo.
        /// </summary>
        [Description("Operações garantidas pelo governo")]
        OPERACOES_GARANTIDAS_GOVERNO = 6,

        /// <summary>
        /// Outras garantias não fidejussórias.
        /// </summary>
        [Description("Outras garantias não fidejussórias")]
        OUTRAS_GARANTIAS_NAO_FIDEJUSSORIAS = 7,

        /// <summary>
        /// Seguros e assemelhados.
        /// </summary>
        [Description("Seguros e assemelhados")]
        SEGUROS_ASSEMELHADOS = 8,

        /// <summary>
        /// Garantia fidejussória.
        /// </summary>
        [Description("Garantia fidejussória")]
        GARANTIA_FIDEJUSSORIA = 9,

        /// <summary>
        /// Bens arrendados.
        /// </summary>
        [Description("Bens arrendados")]
        BENS_ARRENDADOS = 10,

        /// <summary>
        /// Garantias internacionais.
        /// </summary>
        [Description("Garantias internacionais")]
        GARANTIAS_INTERNACIONAIS = 11,

        /// <summary>
        /// Operações garantidas por outras entidades.
        /// </summary>
        [Description("Operações garantidas por outras entidades")]
        OPERACOES_GARANTIDAS_OUTRAS_ENTIDADE = 12,

        /// <summary>
        /// Acordos de compensação.
        /// </summary>
        [Description("Acordos de compensação")]
        ACORDOS_COMPENSACAO = 13,

        /// <summary>
        /// Não aplicável.
        /// </summary>
        [Description("Não aplicável")]
        NAO_APLICAVEL = 14,
    }
}
