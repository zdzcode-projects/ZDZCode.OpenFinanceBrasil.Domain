using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo da modalidade de crédito contratada, conforme circular 4.015 e descrição do DOC3040 do SCR).
    /// </summary>
    public enum EnumUnarrangedAccountOverdraftSubProductType
    {
        /// <summary>
        /// Adiantamento a depositantes, Direitos creditórios descontados Empréstimos, Financiamentos, Financiamentos rurais e Financiamentos imobiliários"
        /// </summary>
        [Description("Adiantamento a depositantes")]
        ADIANTAMENTO_A_DEPOSITANTES = 1,      
    }
}
