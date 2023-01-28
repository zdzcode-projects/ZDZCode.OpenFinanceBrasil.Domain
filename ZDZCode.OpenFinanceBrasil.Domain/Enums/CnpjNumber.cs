using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// O CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara.
    /// </summary>
    public enum CnpjNumber //confirmar com o Zids, se realmente é um enum.
    {
        /// <summary>
        /// CNPJ
        /// </summary>
        [Description("CNPJ")]
        CNPJ = 1,
    }
}
