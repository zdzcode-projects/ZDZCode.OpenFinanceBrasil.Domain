using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InformedIncome
    {
        /// <summary>
        /// Traz a frequência ou período da renda informada.
        /// </summary>
        [Required]
        public EnumInformedIncomeFrequency Frequency { get; set; }

        /// <summary>
        /// Valor total da renda informada. Expresso em valor monetário com 4 casas decimais.
        /// Renda primária indica os montantes a pagar ou a receber em troca do uso temporário de recursos financeiros, trabalho ou ativos não financeiros não produzidos, a saber, remuneração de trabalhadores, renda de investimentos e demais rendas primárias.
        /// Fazem parte da primeira a remuneração do trabalho assalariado (salários e ordenados); da segunda, renda de investimento direto, renda de investimento em carteira, renda de outros investimentos e renda de ativos de reserva; e da terceira, tributos sobre a produção e importação, subsídios e aluguéis.
        /// Fonte: Banco Central do Brasil – Departamento Econômico
        /// </summary>
        [Required]
        public double Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor da renda, segundo modelo ISO-4217.
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Data da renda, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public string Date { get; set; }
    }
}
