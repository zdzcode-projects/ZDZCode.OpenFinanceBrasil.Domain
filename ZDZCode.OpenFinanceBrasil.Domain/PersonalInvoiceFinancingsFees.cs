﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalInvoiceFinancingsFees
    {
        /// <summary>
        /// Lista das Tarifas cobradas sobre Serviços
        /// </summary>
        [Required]
        public InvoiceFinancingsService Services { get; set; }
    }
}
