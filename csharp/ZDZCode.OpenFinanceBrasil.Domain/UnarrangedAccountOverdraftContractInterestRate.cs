using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class UnarrangedAccountOverdraftContractInterestRate
    {
        /// <summary>
        /// "Tipo de Taxa (vide Enum)
        /// - NOMINAL(taxa nominal é uma taxa de juros em que a unidade referencial não coincide com a unidade de tempo da capitalização.Ela é sempre fornecida em termos anuais, e seus períodos de capitalização podem ser diários, mensais, trimestrais ou semestrais.p.ex.Uma taxa de 12% ao ano com capitalização mensal)
        /// - EFETIVA(É a taxa de juros em que a unidade referencial coincide com a unidade de tempo da capitalização. Como as unidades de medida de tempo da taxa de juros e dos períodos de capitalização são iguais, usa-se exemplos simples como 1% ao mês, 60% ao ano)"
        /// </summary>
        [Required]
        public EnumContractTaxType TaxType { get; set; }

        /// <summary>
        /// "Tipo de Juros (vide Enum)
        /// - SIMPLES(aplicada/cobrada sempre sobre o capital inicial, que é o valor emprestado/investido.Não há cobrança de juros sobre juros acumulados no(s) período(s) anterior(es). Exemplo: em um empréstimo de R$1.000, com taxa de juros simples de 8% a.a., com duração de 2 anos, o total de juros será R$80 no primeiro ano e R$ 80 no segundo ano.Ao final do contrato, o tomador irá devolver o principal e os juros simples de cada ano: R$1.000+R$80+R$80=R$1.160)
        /// - COMPOSTO(para cada período do contrato (diário, mensal, anual etc.), há um “novo capital” para a cobrança da taxa de juros contratada.Esse “novo capital” é a soma do capital e do juro cobrado no período anterior.Exemplo: em um empréstimo de R$1.000, com taxa de juros composta de 8% a.a., com duração de 2 anos, o total de juros será R$80 no primeiro ano.No segundo ano, os juros vão ser somados ao capital (R$1.000 + R$ 80 = R$ 1.080), resultando em juros de R$ 86 (8%de R$ 1.080))"
        /// </summary>
        [Required]
        public EnumContractInterestRateType InterestRateType { get; set; }

        /// <summary>
        /// "Periodicidade da taxa . (Vide Enum) a.m - ao mês / a.a. - ao ano"
        /// </summary>
        [Required]
        public EnumContractTaxPeriodicity TaxPeriodicity { get; set; }

        /// <summary>
        /// Base de cálculo
        /// </summary>
        [Required]
        public EnumContractCalculation Calculation { get; set; }

        /// <summary>
        /// "Tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040"
        /// </summary>
        [Required]
        public EnumContractReferentialRateIndexerType ReferentialRateIndexerType { get; set; }

        /// <summary>
        /// "Sub tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040"
        /// </summary>
        public EnumContractReferentialRateIndexerSubType ReferentialRateIndexerSubType { get; set; }

        /// <summary>
        /// Campo livre para complementar a informação relativa ao Tipo de taxa referencial ou indexador. [Restrição] Obrigatório para complementar a informação relativa ao Tipo de taxa referencial ou indexador, quando selecionada o tipo ou subtipo OUTRO.
        /// </summary>
        public string ReferentialRateIndexerAdditionalInfo { get; set; }

        /// <summary>
        /// "Taxa pré fixada aplicada sob o contrato da modalidade crédito. p.ex. 0.0045. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%)"
        /// </summary>
        [Required]
        public double PreFixedRate { get; set; }

        /// <summary>
        /// "Taxa pós fixada aplicada sob o contrato da modalidade crédito. p.ex. 0.0045 .O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%)"
        /// </summary>
        [Required]
        public double PostFixedRate { get; set; }

        /// <summary>
        /// Texto com informações adicionais sobre a composição das taxas de juros pactuadas
        /// </summary>
        [Required]
        public string AdditionalInfo { get; set; }
    }
}
