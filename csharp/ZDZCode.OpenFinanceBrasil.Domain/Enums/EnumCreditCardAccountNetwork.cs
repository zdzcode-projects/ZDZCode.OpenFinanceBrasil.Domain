using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Categoria de Bandeiras de Cartões de Crédito (Instituidor do arranjo de pagamento). Bandeira é a detentora de todos os direitos e deveres da utilização da marca estampada no cartão, inclusive as bandeiras pertencentes aos emissores.
    /// </summary>
    public enum EnumCreditCardAccountNetwork
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        VISA = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MASTERCARD = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        AMERICAN_EXPRESS = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DINERS_CLUB = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        HIPERCARD = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BANDEIRA_PROPRIA = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CHEQUE_ELETRONICO = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ELO = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRAS = 9,
    }
}
