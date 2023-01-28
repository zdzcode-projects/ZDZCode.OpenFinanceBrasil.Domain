using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ServiceBundleServiceDetail
    {
        /// <summary>
        /// Código que identifica o Serviço que compõe o Pacote de Serviços, podendo ser da lista de Serviços Prioritários ou Outros Serviços. p.ex. segundo Resolução 3.919 do Bacen: 'SAQUE_TERMINAL'.
        /// </summary>
        [Required]
        public string code { get; set; }

        /// <summary>
        /// Fatos geradores de cobrança que incidem sobre serviço que compõe o Pacote de Serviços.
        /// </summary>
        [Required]
        public string chargingTriggerInfo { get; set; }

        /// <summary>
        /// Segundo Resolução 4196, BCB, de 2013: Quantidade de eventos previstos no Pacote de Serviços (Número de eventos incluídos no mês) p.ex.'2'. No caso de quantidade ilimitada, reportar 999999
        /// </summary>
        [Required]
        public string eventLimitQuantity { get; set; }

        /// <summary>
        /// Segundo Resolução 4196, BCB, de 2013: Quantidade de eventos previstos no Pacote de Serviços com isenção de Tarifa.p.ex.'1' No caso de quantidade ilimitada, reportar 999999
        /// </summary>
        [Required]
        public string freeEventQuantity { get; set; }
    }
}
