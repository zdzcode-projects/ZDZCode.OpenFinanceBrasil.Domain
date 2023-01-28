using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCreditCardService
    {
        /// <summary>
        /// Denominação de Serviços relacionados à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)
        /// </summary>
        [Required]
        public EnumPersonalCreditCardFeesServiceName name { get; set; }

        /// <summary>
        /// Códigos de Serviços relacionados à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)
        /// </summary>
        [Required]
        public EnumPersonalCreditCardFeesServiceCode code { get; set; }

        /// <summary>
        /// Fatos geradores de cobrança que incidem sobre as Modalidades informadas de Contas de Pagamento Pós-Pagas para pessoa jurídica
        /// </summary>
        [Required]
        public string chargingTriggerInfo { get; set; }

        /// <summary>
        /// Lista distribuição preços tarifas de serviços
        /// </summary>
        [Required]
        public Price prices { get; set; }

        /// <summary>
        /// Valor mínimo cobrado para a taxa de remuneração relativa ao serviço ofertado sobre a base de clientes no mês de referência. Este campo deve estar obrigatoriamente preenchido se não houver conteúdo para os itens: value, currency e type
        /// </summary>
        [Required]
        public MinimumPrice minimum { get; set; }

        /// <summary>
        /// Valor máximo cobrado para a taxa de remuneração relativa ao serviço ofertado sobre a base de clientes no mês de referência. Este campo deve estar obrigatoriamente preenchido se não houver conteúdo para os itens: value, currency e type
        /// </summary>
        [Required]
        public MaximumPrice maximum { get; set; }

    }
}
