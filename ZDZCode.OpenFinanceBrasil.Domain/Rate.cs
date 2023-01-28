using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Rate
    {
        /// <summary>
        /// Faixas para cobrança da taxa efetiva aplicada pela contratação do do crédito rotativo, no intervalo informado: 1ª faixa, 2ª faixa, 3ª faixa e 4ª faixa. Segundo Normativa nº32 de 2020: 'Distribuição de frequência relativa dos valores de tarifas e taxas de juros cobrados dos clientes, de que trata o § 2º do art. 3º da Circular nº 4.015, de 2020, deve dar-se com base em quatro faixas de igual tamanho, com explicitação dos valores sobre a mediana e o percentual de clientes em cada uma dessas faixas.
        /// </summary>
        [Required]
        public EnumPriceInterval interval { get; set; }

        /// <summary>
        /// Percentual que corresponde a mediana (taxa efetiva) cobrada do cliente pela utilização do crédito rotativo, no intervalo informado.
        /// </summary>
        [Required]
        public Indexer indexer { get; set; }

        /// <summary>
        /// Percentual de clientes em cada faixa.
        /// </summary>
        [Required]
        public Customer customers { get; set; }
    }
}
