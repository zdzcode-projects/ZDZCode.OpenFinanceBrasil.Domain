using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPersonalCreditCardProductType
    {
        /// <summary>
        /// Classic Nacional.
        /// </summary>
        [Description("Classic Nacional")]
        CLASSIC_NACIONAL = 1 ,

        /// <summary>
        /// Classic Internacional.
        /// </summary>
        [Description("Classic Internacional")]
        CLASSIC_INTERNACIONAL = 2 ,

        /// <summary>
        /// Gold.
        /// </summary>
        [Description("Gold")]
        GOLD  = 3 ,

        /// <summary>
        /// Platinum.
        /// </summary>
        [Description("Platinum")]
        PLATINUM  = 4 ,

        /// <summary>
        /// Infinite.
        /// </summary>
        [Description("Infinite")]
        INFINITE  = 5 ,

        /// <summary>
        /// Electron.
        /// </summary>
        [Description("Electron")]
        ELECTRON  = 6 ,

        /// <summary>
        /// Standard Nacional.
        /// </summary>
        [Description("Standard Nacional")]
        STANDARD_NACIONAL = 7 ,

        /// <summary>
        /// Standard Internacional.
        /// </summary>
        [Description("Standard Internacional")]
        STANDARD_INTERNACIONAL = 8 ,

        /// <summary>
        /// Classic Nacional.
        /// </summary>
        [Description("Classic Nacional")]
        ELETRONIC = 9 ,

        /// <summary>
        /// Classic Internacional.
        /// </summary>
        [Description("Classic Internacional")]
        BLACK = 10,

        /// <summary>
        /// Gold.
        /// </summary>
        [Description("Gold")]
        REDESHOP = 11,

        /// <summary>
        /// Maestro Mastercard maestro.
        /// </summary>
        [Description("Maestro Mastercard maestro")]
        MAESTRO_MASTERCARD_MAESTRO = 12,

        /// <summary>
        /// Green.
        /// </summary>
        [Description("Green")]
        GREEN = 13,

        /// <summary>
        /// Blue.
        /// </summary>
        [Description("Blue")]
        BLUE = 14,

        /// <summary>
        /// Blue Box.
        /// </summary>
        [Description("Blue Box")]
        BLUEBOX = 15,

        /// <summary>
        /// Profissional liberal.
        /// </summary>
        [Description("Profissional liberal")]
        PROFISSIONAL_LIBERAL = 16,

        /// <summary>
        /// Cheque eletronico.
        /// </summary>
        [Description("Cheque eletronico")]
        CHEQUE_ELETRONICO = 17,

        /// <summary>
        /// Corporativo.
        /// </summary>
        [Description("Corporativo")]
        CORPORATIVO = 18,

        /// <summary>
        /// Empresarial.
        /// </summary>
        [Description("Empresarial")]
        EMPRESARIAL = 19,

        /// <summary>
        /// Compras.
        /// </summary>
        [Description("")]
        COMPRAS = 20,

        /// <summary>
        /// Outros
        /// </summary>
        [Description("Outros")]
        OUTROS = 21,
    }                             
}
