using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações referentes às informações de credenciamento
    /// </summary>
    public class AcquiringServicesContractData
    {
        /// <summary>
        /// Conjunto de informações relativas ao participante do produto de open banking.
        /// </summary>
        [Required]
        public Participant Participant { get; set; }

        /// <summary>
        /// Nome da tarifa cobrada sobre o serviço de credenciamento, para pessoa física/jurídica. 1. Taxa de Desconto na Modalidade Crédito 2. Taxa de Desconto na Modalidade Débito
        /// </summary>
        [Required]
        public EnumAcquiringServicesFeeName FeeName { get; set; }

        /// <summary>
        /// Sigla da Tarifa cobrada sobre o Serviço de Credenciamento informado.
        /// </summary>
        [Required]
        public EnumAcquiringServicesCode Code { get; set; }

        /// <summary>
        /// [4 Faixas de igual tamanho, com suas respectivas medianas e percentuais de clientes.]
        /// </summary>
        [Required]
        public List<Price> Prices { get; set; }

        /// <summary>
        /// Recebimento através de transação de cartão.
        /// </summary>
        [Required]
        public string ChargingTriggerInfo { get; set; }

        /// <summary>
        /// Valor mínimo
        /// </summary>
        [Required]
        public string Minimum { get; set; }

        /// <summary>
        /// Valor máximo
        /// </summary>
        [Required]
        public string Maximum { get; set; }
    }
}
