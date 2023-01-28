using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalAccount
    {
        /// <summary>
        /// Tipos de contas ofertadas para pessoa natural, p.ex. 'CONTA_DEPOSITO_A_VISTA'. Conta de depósito à vista ou Conta corrente - é o tipo mais comum. Nela, o dinheiro fica à sua disposição para ser sacado a qualquer momento. Essa conta não gera rendimentos para o depositante. Conta poupança - foi criada para estimular as pessoas a pouparem. O dinheiro que ficar na conta por trinta dias passa a gerar rendimentos, com isenção de imposto de renda para quem declara. Ou seja, o dinheiro “cresce” (rende) enquanto ficar guardado na conta. Cada depósito terá rendimentos de mês em mês, sempre no dia do mês em que o dinheiro tiver sido depositado. Conta de pagamento pré-paga: segundo CIRCULAR Nº 3.680, BCB de 2013, é a 'destinada à execução de transações de pagamento em moeda eletrônica realizadas com base em fundos denominados em reais previamente aportados'
        /// </summary>
        [Required]
        public EnumAccountType Type { get; set; }

        /// <summary>
        /// Objeto que reúne informações de tarifas de serviços
        /// </summary>
        [Required]
        public AccountFee Fees { get; set; }

        /// <summary>
        /// Lista dos Pacotes de serviços
        /// </summary>
        [Required]
        public ServiceBundle ServiceBundles { get; set; }

        /// <summary>
        /// Lista dos canais para aberturas e encerramento
        /// </summary>
        [Required]
        public EnumOpeningClosingChannels OpeningClosingChannels { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao Canal disponível, quando no campo ''openingClosingChannels'' estiver preenchida a opção ''Outros''. Restrição: Campo de preenchimento obrigatório se ''openingCloseChannels'' estiver preenchida a opção ''OUTROS''
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Lista de formas de movimentação
        /// </summary>
        [Required]
        public EnumTransactionMethods TransactionMethods { get; set; }

        /// <summary>
        /// Objeto que reúne informações relativas a Termos e Condições para as modalidades tratadas 
        /// </summary>
        [Required]
        public AccountsTermsConditions TermsConditions { get; set; }

        /// <summary>
        /// Valores dos percentuais de taxas.
        /// </summary>
        [Required]
        public AccountsIncomeRate IncomeRate { get; set; }

    }
}
