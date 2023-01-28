using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class UnarrangedAccountOverdraftChargeOverParcel
    {
        /// <summary>
        /// Tipo de encargo pactuado no contrato.
        /// </summary>
        [Required]
        public EnumContractFinanceChargeType ChargeType { get; set; }

        /// <summary>
        /// Campo livre para preenchimento das informações adicionais referente ao encargo. [Restrição] Obrigatório quando chargeType for igual OUTROS.
                /// </summary>
        [Required]
        public string ChargeAdditionalInfo { get; set; }

        /// <summary>
        /// Valor do pagamento do encargo pago fora da parcela. Expresso em valor monetário com até 4 casas decimais.
        /// </summary>
        [Required]
        public double ChargeAmount { get; set; }
    }
}
