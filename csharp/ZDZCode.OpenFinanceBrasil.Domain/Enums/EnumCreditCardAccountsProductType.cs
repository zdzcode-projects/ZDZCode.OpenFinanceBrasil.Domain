using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Categoria atribuída a um cartão de pagamento, sob uma certa denominação, que lhe agrega um conjunto de vantagens, diferenciando-o de acordo com o perfil do portador.
    /// </summary>
    public enum EnumCreditCardAccountsProductType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CLASSIC_NACIONAL = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CLASSIC_INTERNACIONAL = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GOLD = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PLATINUM = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INFINITE = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ELECTRON = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        STANDARD_NACIONAL = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        STANDARD_INTERNACIONAL = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ELETRONIC = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BLACK = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        REDESHOP = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MAESTRO_MASTERCARD_MAESTRO = 12,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GREEN = 13,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BLUE = 14,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BLUEBOX = 15,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PROFISSIONAL_LIBERAL = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CHEQUE_ELETRONICO = 17,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CORPORATIVO = 18,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EMPRESARIAL = 19,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        COMPRAS = 20,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BASICO_NACIONAL = 21,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BASICO_INTERNACIONAL = 22,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        NANQUIM = 23,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GRAFITE = 24,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MAIS  = 25,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 26,
    }
}
