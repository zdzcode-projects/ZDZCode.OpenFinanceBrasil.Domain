﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class UnarrangedAccountOverdraftRate
    {
        /// <summary>
        /// Tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040
        /// </summary>
        [Required]
        public ReferentialRateIndexer referentialRateIndexer { get; set; }

        /// <summary>
        /// Percentual que incide sobre a composição das taxas de juros remuneratórios.
        /// </summary>
        [Required]
        public decimal rate { get; set; }

        /// <summary>
        /// Lista das faixas de cobrança da taxa efetiva de remuneração.
        /// </summary>
        [Required]
        public Application applications { get; set; }

        /// <summary>
        /// Percentual mínimo cobrado (taxa efetiva) no mês de referência, para os Direitos Creditórios Descontados contratado A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.15. Este valor representa 15%. O valor 1 representa 100%)
        /// </summary>
        [Required]
        public string minimumRate { get; set; }

        /// <summary>
        /// Percentual máximo cobrado (taxa efetiva) no mês de referência, para os Direitos Creditórios Descontados contratado A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.15. Este valor representa 15%. O valor 1 representa 100%)
        /// </summary>
        [Required]
        public string maximumRate { get; set; }
    }
}
