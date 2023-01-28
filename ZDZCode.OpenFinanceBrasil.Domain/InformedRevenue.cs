using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InformedRevenue
    {
        /// <summary>
        /// Traz a frequência ou período do faturamento informado.
        /// "O faturamento é calculado a partir de todos os benefícios que a empresa conseguiu com sua atividade econômica em um determinado período. Esses benefícios são os rendimentos ou ganhos da organização através de suas vendas ou serviços prestados".
        /// </summary>
        [Required]
        public EnumInformedRevenueFrequency Frequency { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao patrimonio. [Restrição] Preencher quando frequency for igual OUTROS.
        /// </summary>
        public string FrequencyAdditionalInfo { get; set; }

        /// <summary>
        /// Valor do patrimônio informado. Expresso em valor monetário com 4 casas decimais. Patrimônio é o conjunto de bens vinculado a uma pessoa ou a uma entidade.
        /// </summary>
        [Required]
        public double Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor do patrimônio, segundo modelo ISO-4217.
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Ano de referência do Patrimônio, conforme especificação RFC-3339.
        /// </summary>
        public int Year { get; set; }
    }
}
