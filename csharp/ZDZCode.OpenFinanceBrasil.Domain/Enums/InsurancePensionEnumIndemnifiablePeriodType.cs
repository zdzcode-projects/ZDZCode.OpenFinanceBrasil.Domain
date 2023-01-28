using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Listagem do pagamento para cada benefício: 1. Quantidade determinada de parcelas; 2. Até o fim de ciclo determinado. Se for pagamento único, esse campo não se aplica (retorna vazio).
    /// </summary>
    public enum InsurancePensionEnumIndemnifiablePeriodType
    {
        /// <summary>
        /// Quantidade determinada de parcelas.
        /// </summary>
        [Description("Quantidade determinada de parcelas")]
        QUANTIDADE_DETERMINADA_PARCELAS = 1,

        /// <summary>
        /// Até o fim de ciclo determinado.
        /// </summary>
        [Description("Até o fim de ciclo determinado")]
        FIM_CICLO_DETERMINADO = 2,
    }
}
