using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoansContract
    {
        /// <summary>
        /// Número do contrato dado pela instituição contratante.
        /// </summary>
        [Required]
        public string ContractNumber { get; set; }

        /// <summary>
        /// Número padronizado do contrato - IPOC (Identificação Padronizada da Operação de Crédito). Segundo DOC 3040, composta por: - CNPJ da instituição: 8 (oito) posições iniciais; - Modalidade da operação: 4 (quatro) posições; 
        /// - Tipo do cliente: 1 (uma) posição( 1 = pessoa natural - CPF, 2= pessoa jurídica – CNPJ, 3 = pessoa física no exterior, 4 = pessoa jurídica no exterior, 5 = pessoa natural sem CPF e 6 = pessoa jurídica sem CNPJ);
        /// - Código do cliente: O número de posições varia conforme o tipo do cliente:
        /// 1. Para clientes pessoa física com CPF(tipo de cliente = 1), informar as 11 (onze) posições do CPF;
        /// 2. Para clientes pessoa jurídica com CNPJ(tipo de cliente = 2), informar as 8 (oito) posições iniciais do CNPJ;
        /// 3. Para os demais clientes(tipos de cliente 3, 4, 5 e 6), informar 14 (catorze) posições com complemento de zeros à esquerda se a identificação tiver tamanho inferior;
        /// - Código do contrato: 1 (uma) até 40 (quarenta) posições, sem complemento de caracteres.
        /// </summary>
        [Required]
        public string IpocCode { get; set; }

        /// <summary>
        /// Denominação/Identificação do nome da Modalidade da Operação de Crédito divulgado ao cliente.
        /// </summary>
        [Required]
        public string ProductName { get; set; }

        /// <summary>
        /// Tipo da modalidade de crédito contratada, conforme circular 4.015 e descrição do DOC3040 do SCR).
        /// </summary>
        [Required]
        public EnumContractProductTypeLoans ProductType { get; set; }

        /// <summary>
        /// Sub tipo da modalidades de crédito Empréstimos contratadas, conforme circular 4.015 e descrição do DOC3040 do SCR).
        /// </summary>
        [Required]
        public EnumContractProductSubTypeLoans ProductSubType { get; set; }

        /// <summary>
        /// Data de contratação da operação de crédito. Especificação RFC-3339
        /// </summary>
        [Required]
        public string ContractDate { get; set; }

        /// <summary>
        /// Data do Desembolso do valor contratado. Especificação RFC-3339
        /// </summary>
        public string DisbursementDate { get; set; }

        /// <summary>
        /// Data de liquidação da operação. [Restrição] Deve aceitar NA caso não seja retornado pela instituição.
        /// </summary>
        [Required]
        public string SettlementDate { get; set; }

        /// <summary>
        /// Valor contratado da operação. Expresso em valor monetário com até 4 casas decimais
        /// </summary>
        [Required]
        public double ContractAmount { get; set; }

        /// <summary>
        /// Moeda referente ao valor da garantia, segundo modelo ISO-4217. p.ex. 'BRL' Todos os valores monetários informados estão representados com a moeda vigente do Brasil
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Data de vencimento Final da operação. Especificação RFC-3339
        /// </summary>
        [Required]
        public string DueDate { get; set; }

        /// <summary>
        /// "Informação relativa à periodicidade regular das parcelas. (Vide Enum) sem periodicidade regular, semanal, quinzenal, mensal, bimestral, trimestral, semestral, anual"
        /// </summary>
        [Required]
        public EnumContractInstalmentPeriodicity InstalmentPeriodicity { get; set; }

        /// <summary>
        /// Campo obrigatório para complementar a informação relativa à periodicidade de pagamento regular quando tiver a opção OUTROS. [Restrição] Obrigatório para complementar a informação relativa da periodicidade de pagamento regular, quando selecionada o tipo ou subtipo OUTRO.
        /// </summary>
        [Required]
        public string InstalmentPeriodicityAdditionalInfo { get; set; }

        /// <summary>
        /// Data de vencimento primeira parcela do principal.
        /// </summary>
        [Required]
        public string FirstInstalmentDueDate { get; set; }

        /// <summary>
        /// CET – Custo Efetivo Total deve ser expresso na forma de taxa percentual anual e incorpora todos os encargos e despesas incidentes nas operações de crédito (taxa de juro, mas também tarifas, tributos, seguros e outras despesas cobradas). O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%)
        /// </summary>
        [Required]
        public double CET { get; set; }

        /// <summary>
        /// Sistema de amortização (Vide Enum):
        /// - SAC(Sistema de Amortização Constante) - É aquele em que o valor da amortização permanece igual até o final.Os juros cobrados sobre o parcelamento não entram nesta conta.
        /// - PRICE (Sistema Francês de Amortização) - As parcelas são fixas do início ao fim do contrato.Ou seja, todas as parcelas terão o mesmo valor, desde a primeira até a última.Nos primeiros pagamentos, a maior parte do valor da prestação corresponde aos juros. Ao longo do tempo, a taxa de juros vai decrescendo. Como o valor da prestação é fixo, com o passar das parcelas, o valor de amortização vai aumentando.
        /// - SAM (Sistema de Amortização Misto) - Cada prestação(pagamento) é a média aritmética das prestações respectivas no Sistemas Price e no Sistema de Amortização Constante(SAC).
        /// - SEM SISTEMA DE AMORTIZAÇÃO
        /// </summary>
        [Required]
        public EnumContractAmortizationScheduled AmortizationScheduled { get; set; }

        /// <summary>
        /// Campo obrigatório para complementar a informação relativa à amortização quando selecionada a opção OUTROS. [Restrição] Obrigatório para complementar a informação relativa à amortização quando selecionada a opção OUTROS, para os demais casos informar "NA".
        /// </summary>
        [Required]
        public string AmortizationScheduledAdditionalInfo { get; set; }

        /// <summary>
        /// CNPJ do consignante (CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica). Deve-se ter apenas os números do CNPJ, sem máscara. Informação adicional específica para Modalidade de Crédito: Empréstimo-Crédito Pessoal Consignado.
        /// </summary>
        [Required]
        public string CnpjConsignee { get; set; }

        /// <summary>
        /// [Objeto que traz o conjunto de informações necessárias para demonstrar a composição das taxas de juros remuneratórios da Modalidade de crédito]
        /// </summary>
        [Required]
        public List<LoansContractInterestRate> InterestRates { get; set; }

        /// <summary>
        /// [Objeto que traz o conjunto de informações necessárias para demonstrar a composição das taxas de juros remuneratórios da Modalidade de crédito]
        /// </summary>
        [Required]
        public List<LoansContractedFee> ContractedFees { get; set; }

        /// <summary>
        /// Lista que traz os encargos pactuados no contrato.
        /// </summary>
        [Required]
        public List<LoansFinanceCharge> ContractedFinanceCharges { get; set; }
    }
}
