using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo de Taxa
    /// </summary>
    public enum EnumContractTaxType
    {
        /// <summary>
        /// Taxa nominal é uma taxa de juros em que a unidade referencial não coincide com a unidade de tempo da capitalização. Ela é sempre fornecida em termos anuais, e seus períodos de capitalização podem ser diários, mensais, trimestrais ou semestrais. p.ex. Uma taxa de 12% ao ano com capitalização mensal
        /// </summary>
        [Description("Taxa nominal")]
        NOMINAL = 1,

        /// <summary>
        /// Taxa efetiva, é a taxa de juros em que a unidade referencial coincide com a unidade de tempo da capitalização. Como as unidades de medida de tempo da taxa de juros e dos períodos de capitalização são iguais, usa-se exemplos simples como 1% ao mês, 60% ao ano
        /// </summary>
        [Description("Taxa efetiva")]
        EFETIVA = 2,
    }
}
