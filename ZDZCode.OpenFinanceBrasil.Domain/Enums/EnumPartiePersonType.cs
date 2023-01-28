using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Identificação do Tipo de Pessoa da pessoa envolvida na transação.
    /// </summary>
    public enum EnumPartiePersonType
    {
        /// <summary>
        /// Pessoa Natural - Informar CPF no campo “payerCnpjCpf”
        /// </summary>
        [Description("Pessoa Natural")]
        PESSOA_NATURAL = 1,

        /// <summary>
        /// Pessoa Jurídica - Informar CNPJ no campo “payerCnpjCpf”.
        /// </summary>
        [Description("Pessoa Jurídica")]
        PESSOA_JURIDICA = 2,
    }
}
