using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class MonthlyPrice
    {
        /// <summary>
        /// Segundo Normativa nº 32, BCB, de 2020: Distribuição de frequência relativa dos valores de tarifas cobradas dos clientes, de que trata o § 2º do art. 3º da Circular nº 4.015, de 2020, deve dar-se com base em quatro faixas de igual tamanho, com explicitação dos valores sobre a mediana em cada uma dessas faixas. Informando: 1ª faixa , 2ª faixa, 3ª faixa e 4ª faixa
        /// </summary>
        [Required]
        public EnumPriceInterval Interval { get; set; }

        /// <summary>
        /// Valor da mediana da tarifa, relativa ao serviço ofertado,informado no período, conforme Res nº32 BCB, 2020. p.ex. '45.00' (representa um valor monetário. p.ex: 1547368.92. Este valor, considerando que a moeda seja BRL, significa R$ 1.547.368,92. O único separador presente deve ser o '.' (ponto) para indicar a casa decimal. Não deve haver separador de milhar)
        /// </summary>
        [Required]
        public string MonthlyFee { get; set; }

        /// <summary>
        /// Moeda referente ao valor do Pacote de serviços, segundo modelo ISO-4217.
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public Customer Customers { get; set; }
    }
}
