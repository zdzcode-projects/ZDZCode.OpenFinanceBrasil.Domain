using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CoverageItemAttributesMaxLMI
    {
        /// <summary>
        /// Valor máximo de LMI/IS aceito pela sociedade para cada cobertura. Em reais (R$) Importante: Campo de valor numérico relacionado à cobertura que possui o campo. Quando não houver o campo, enviar o valor zerado.
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
