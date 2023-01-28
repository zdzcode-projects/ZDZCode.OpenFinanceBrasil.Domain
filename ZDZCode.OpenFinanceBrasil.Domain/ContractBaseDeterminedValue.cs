using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ContractBaseDeterminedValue
    {
        /// <summary>
        /// Valor Determinado - Valor Mínimo (R$).Observação: Campo condicional quando houver a seleção do domínio ‘Valor Determinado’ no campo ‘Base de Contratação’
        /// </summary>
        [Required]
        public string Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor monetário, seguindo o modelo ISO-4217.
        /// </summary>
        [Required]
        public CurrencyCode Currency { get; set; }
    }
}
