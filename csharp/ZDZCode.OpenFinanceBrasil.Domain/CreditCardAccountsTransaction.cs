using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardAccountsTransaction
    {
        /// <summary>
        /// Código ou identificador único prestado pela instituição que mantém a conta para representar a transação individual.
        /// </summary>
        [Required]
        public string TransactionId { get; set; }

        /// <summary>
        /// Número de identificação do cartão: corresponde aos 4 últimos dígitos do cartão para PF, ou então, preencher com um identificador para PJ, com as caracteristicas definidas para os IDs no Open Banking.
        /// </summary>
        [Required]
        public string IdentificationNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        public EnumCreditCardAccountsLineName LineName { get; set; }

        /// <summary>
        /// Campo de livre preenchimento. Literal usada na instituição financeira para identificar a transação.
        /// </summary>
        [Required]
        public string TransactionName { get; set; }

        /// <summary>
        /// Informação que identifica a fatura onde consta a transação informada.
        /// </summary>
        public string BillId { get; set; }

        /// <summary>
        /// Indicador do tipo de lançamento:
        /// Débito(no extrato) Em um extrato bancário, os débitos, marcados com a letra “D” ao lado do valor registrado, informam as saídas de dinheiro na conta-corrente.
        /// Crédito(no extrato) Em um extrato bancário, os créditos, marcados com a letra “C” ao lado do valor registrado, informam as entradas de dinheiro na conta-corrente.
        /// </summary>
        [Required]
        public EnumCreditDebitIndicator CreditDebitType { get; set; }

        /// <summary>
        /// Traz os tipos de Transação.
        /// </summary>
        [Required]
        public EnumCreditCardTransactionType TransactionType { get; set; }

        /// <summary>
        /// Campo livre, de preenchimento obrigatório quando selecionado tipo de transação "OUTROS".
        /// </summary>
        [Required]
        public string TransactionalAdditionalInfo { get; set; }

        /// <summary>
        /// Traz os tipos de pagamento. Preenchimento obrigatório se selecionado tipo de transação PAGAMENTO.
        /// </summary>
        [Required]
        public EnumCreditCardAccountsPaymentType PaymentType { get; set; }

        /// <summary>
        /// Traz os tipos de Tarifas: (Vide Enum) Anuidade, Saque com cartão no Brasil, Saque com cartão no exterior, Avaliação emergencial de crédito, Emissão segunda via, Tarifa pagamento de contas, SMS, OUTRA. [Restrição] Preenchimento obrigatório se Tipo de Transação selecionada for 'TARIFA'.
        /// </summary>
        [Required]
        public EnumCreditCardAccountFee FeeType { get; set; }

        /// <summary>
        /// Campo livre, de preenchimento obrigatório quando selecionada tipo de tarifa "OUTRA".
        /// </summary>
        [Required]
        public string FeeTypeAdditionalInfo { get; set; }

        /// <summary>
        /// raz outros tipos de crédito contratados no cartão. [Restrição] Preenchimento obrigatório se o tipo transação selecionado for 'OPERACOES_CREDITO_CONTRATADAS_CARTAO'
        /// </summary>
        [Required]
        public EnumCreditCardAccountsOtherCreditType OtherCreditsType { get; set; }

        /// <summary>
        /// Campo livre, de preenchimento obrigatório quando selecionado tipo de crédito "OUTROS".
        /// </summary>
        [Required]
        public string OtherCreditsAdditionalInfo { get; set; }

        /// <summary>
        /// Identificador da parcela que está sendo informada. Campo de livre preenchimento.
        /// </summary>
        [Required]
        public string ChargeIdentificator { get; set; }

        /// <summary>
        /// Quantidade de parcelas.
        /// </summary>
        [Required]
        public int ChargeNumber { get; set; }

        /// <summary>
        /// Valor da transação expresso em valor monetário com 4 casas decimais, em moeda corrente do Brasil.
        /// </summary>
        [Required]
        public double BrazilianAmount { get; set; }

        /// <summary>
        /// Valor da transação efetuada no exterior e convertida em moeda nacional com 4 casas decimais. Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor da transação, se a operação foi efetuada em moeda estrangeira, segundo modelo ISO-4217. Todos os valores informados estão representados com a moeda vigente do Brasil
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Data original da transação.
        /// </summary>
        [Required]
        public string TransactionDate { get; set; }

        /// <summary>
        /// Data em que a transação foi inserida na fatura.
        /// </summary>
        [Required]
        public string BillPostDate { get; set; }

        /// <summary>
        /// O MCC ou o código da categoria do estabelecimento comercial. Os MCCs são agrupados segundo suas similaridades. O MCC é usado para classificar o negócio pelo tipo fornecido de bens ou serviços. Os MCCs são atribuídos por tipo de comerciante (por exemplo, um para hotéis, um para lojas de materiais de escritório, etc.) ou por nome de comerciante (por exemplo, 3000 para a United Airlines).
        /// </summary>
        [Required]
        public int PayeeMCC { get; set; }
    }
}
