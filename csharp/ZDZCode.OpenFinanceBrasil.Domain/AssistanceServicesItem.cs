using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AssistanceServicesItem
    {
        /// <summary>
        /// 1. Até 10 serviços
        /// 2. Até 20 serviços
        /// 3. Acima de 20 serviços
        /// 4. Customizável
        /// </summary>
        public EnumAssistanceServicesPackageType Package { get; set; }

        /// <summary>
        /// Campo livre para descrição dos serviços ofertados por cada sociedade participante (incluindo indicação se o serviço é Gratuito ou Pago)
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Sinalização em campo exclusivo se o pacote de Assistência é gratuita ou contratada/paga. A considerar os domínios abaixo:
        /// 1. Gratuita
        /// 2. Pago
        /// </summary>
        public EnumChargeTypeSignalingType ChargeType { get; set; }
    }
}
