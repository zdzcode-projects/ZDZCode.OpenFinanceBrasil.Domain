using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AccountTransactionsData
    {
        /// <summary>
        /// Código ou identificador único prestado pela instituição que mantém a conta para representar a transação individual.
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// Indicador da transação:
        /// - Transação efetivada
        /// - Lançamento futuro
        /// </summary>
        [Required]
        public EnumCompletedAuthorisedPaymentIndicator CompletedAuthorisedPaymentType { get; set; }

        /// <summary>
        /// Indicador do tipo de lançamento:
        /// Débito(no extrato) Em um extrato bancário, os débitos, marcados com a letra “D” ao lado do valor registrado, informam as saídas de dinheiro na conta-corrente.
        /// Crédito(no extrato) Em um extrato bancário, os créditos, marcados com a letra “C” ao lado do valor registrado, informam as entradas de dinheiro na conta-corrente.
        /// </summary>
        [Required]
        public EnumCreditDebitIndicator CreditDebitType { get; set; }

        /// <summary>
        /// Campo livre que corresponde ao identificador da transação na instituição financeira
        /// </summary>
        [Required]
        public string TransactionName { get; set; }

        /// <summary>
        /// Tipo de Transação
        /// </summary>
        [Required]
        public EnumTransactionTypes Type { get; set; }

        /// <summary>
        /// Valor da transação. Expressa em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor da transação, segundo modelo ISO-4217. p.ex. 'BRL'.
        /// </summary>
        [Required]
        public string TransactionCurrency { get; set; }

        /// <summary>
        /// Se indicador de transação:
        /// TRANSACAO_EFETIVADA - corresponde a data de lançamento da transação
        /// LANCAMENTO_FUTURO - corresponde a data prevista de efetivação da transação
        /// </summary>
        [Required]
        public string TransactionDate { get; set; }

        /// <summary>
        /// Identificação da pessoa envolvida na transação: pagador ou recebedor (Preencher com o CPF ou CNPJ, sem formatação)
        /// </summary>
        [Required]
        public string PartieCnpjCpf { get; set; }

        /// <summary>
        /// Identificação do Tipo de Pessoa da pessoa envolvida na transação.
        /// Pessoa Natural - Informar CPF no campo “payerCnpjCpf”
        /// Pessoa Jurídica - Informar CNPJ no campo “payerCnpjCpf”
        /// </summary>
        [Required]
        public EnumPartiePersonType PartiePersonType { get; set; }

        /// <summary>
        /// Código identificador atribuído pelo Banco Central do Brasil às instituições participantes do STR (Sistema de Transferência de reservas) referente à pessoa envolvida na transação. O número-código substituiu o antigo código COMPE. Todos os participantes do STR, exceto as Infraestruturas do Mercado Financeiro (IMF) e a Secretaria do Tesouro Nacional, possuem um número-código independentemente de participarem da Centralizadora da Compensação de Cheques (Compe). O campo tem a anotação “n/a” (“não se aplica”) para os participantes do STR aos quais não é atribuído um número-código
        /// </summary>
        [Required]
        public string PartieCompeCode { get; set; }

        /// <summary>
        /// Código da Agência detentora da conta da pessoa envolvida na transação. (Agência é a dependência destinada ao atendimento aos clientes, ao público em geral e aos associados de cooperativas de crédito, no exercício de atividades da instituição, não podendo ser móvel ou transitória)
        /// </summary>
        [Required]
        public string PartieBranchCode { get; set; }

        /// <summary>
        /// Número da conta da pessoa envolvida na transação
        /// </summary>
        [Required]
        public string PartieNumber { get; set; }

        /// <summary>
        /// Dígito da conta da pessoa envolvida na transação
        /// </summary>
        [Required]
        public string PartieCheckDigit { get; set; }
    }
}
