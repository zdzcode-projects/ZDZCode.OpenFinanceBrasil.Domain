﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseUnarrangedAccountOverdraftContractList
    {
        /// <summary>
        /// Conjunto de informações de contratos de adiantamento a depositantes mantidos pelo cliente na instituição transmissora e para os quais ele tenha fornecido consentimento
        /// </summary>
        [Required]
        public List<UnarrangedAccountOverdraftContractListData> Data { get; set; }

        /// <summary>
        /// Referências para outros recusos da API requisitada.
        /// </summary>
        [Required]
        public Links Links { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Required]
        public Meta Meta { get; set; }
    }
}
