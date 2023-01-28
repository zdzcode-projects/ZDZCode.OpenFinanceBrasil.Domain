using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumAssistanceServicesPackageType
    {
        /// <summary>
        /// Até 10 serviços.
        /// </summary>
        [Description("Até 10 serviços")]
        ATE_10_SERVICOS = 1,

        /// <summary>
        /// Até 20 serviços.
        /// </summary>
        [Description("Até 20 serviços")]
        ATE_20_SERVICOS = 2,

        /// <summary>
        /// Acima de 20 serviços.
        /// </summary>
        [Description("Acima de 20 serviços")]
        ACIMA_20_SERVICOS = 3,

        /// <summary>
        /// Customizável.
        /// </summary>
        [Description("Customizável")]
        CUSTOMIZAVEL = 4,
    }
}
