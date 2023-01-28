using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Nome da tarifa cobrada sobre o serviço de credenciamento, para pessoa física/jurídica.  
    /// </summary>
    public enum EnumAcquiringServicesFeeName
    {
        /// <summary>
        /// Taxa de Desconto na Modalidade Crédito
        /// </summary>
        [Description("Taxa de Desconto na Modalidade Crédito")]
        TAXA_DESCONTO_MODALIDADE_CREDITO = 1,

        /// <summary>
        /// Taxa de Desconto na Modalidade Débito
        /// </summary>
        [Description("Taxa de Desconto na Modalidade Débito")]
        TAXA_DESCONTO_MODALIDADE_DEBITO = 2,
    }
}
