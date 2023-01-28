﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Listagem do valor mínimo de cobertura (Capital Segurado), diária ou parcela aceito pela sociedade para cada combinação de modalidade/cobertura do produto. Conforme moeda.
    /// </summary>
    public class InsurancePensionMinValue
    {
        /// <summary>
        ///
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
