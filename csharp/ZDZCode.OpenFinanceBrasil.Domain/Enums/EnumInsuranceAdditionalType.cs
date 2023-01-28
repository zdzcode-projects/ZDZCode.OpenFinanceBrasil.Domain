using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Identificação do Tipo de telefone da dependência. p.ex.FIXO, MOVEL
    /// </summary>
    public enum EnumInsuranceAdditionalType
    {
        /// <summary>
        /// Sorteio Gratuito.
        /// </summary>
        [Description("Telefone fixo")]
        SORTEIO_GRATUITO = 1,

        /// <summary>
        /// Clube de Benefícios
        /// </summary>
        [Description("Clube de Benefícios")]
        CLUBE_BENEFICIOS = 2,

        /// <summary>
        /// Cashback
        /// </summary>
        [Description("Cashback")]
        CASHBACK = 3,

        /// <summary>
        /// Descontos
        /// </summary>
        [Description("Descontos")]
        DESCONTOS = 4,

        /// <summary>
        /// Outros
        /// </summary>
        [Description("Outros")]
        OUTROS = 5, 
    }
}
