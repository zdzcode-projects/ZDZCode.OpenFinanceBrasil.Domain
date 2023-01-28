using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPersonalInsuranceOtherGuaranteedValues
    {
        /// <summary>
        /// Saldamento.
        /// </summary>
        [Description("Saldamento")]
        SALDAMENTO = 1,

        /// <summary>
        /// Benefício Prolongado.
        /// </summary>
        [Description("Benefício Prolongado")]
        BENEFICIO_PROLONGADO = 2,

        /// <summary>
        /// Não se aplica
        /// </summary>
        [Description("Não se aplica")]
        NAO_APLICA = 3,
    }
}
