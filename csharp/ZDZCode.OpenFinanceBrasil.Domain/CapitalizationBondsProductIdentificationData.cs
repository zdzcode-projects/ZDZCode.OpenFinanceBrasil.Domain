using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CapitalizationBondsProductIdentificationData
    {
        /// <summary>
        /// Conjunto de informações relativas ao participante do produto de open banking
        /// </summary>
        [Required]
        public Participant Participant { get; set; }

        /// <summary>
        /// Conjunto de informações relativas à seguradora do produto de open insurance
        /// </summary>
        [Required]
        public Society Society { get; set; }

        /// <summary>
        /// Nome comercial do produto, pelo qual é identificado nos canais de distribuição e atendimento da sociedade.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Código único a ser definido pela sociedade.
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// 1. Tradicional: A modalidade tradicional tem por objetivo restituir ao titular, ao final do prazo de vigência, no mínimo, o valor total das contribuições efetuadas pelo subscritor, desde que todas as contribuições previstas tenham sido realizadas nas datas programadas. (Res CNSP 384/20)
        /// 2. Instrumento de Garantia: A modalidade tem por objetivo propiciar que a provisão matemática para capitalização do título de capitalização seja utilizada para assegurar o cumprimento de obrigação assumida em contrato principal pelo titular perante terceiro. (Res CNSP 384/20)
        /// 3. Compra Programada: A modalidade compra programada garante o valor de resgate em moeda corrente nacional, sendo disponibilizada ao assim desejar e sem qualquer outro custo, pelo recebimento do bem e/ou serviço referenciado no subsidiado por acordos comerciais celebrados com indústrias, atacadistas, empresas comerciais ou prestadores de serviço. (Res CNSP 384/20)
        /// 4. Popular: A modalidade popular tem por objetivo propiciar a capitalização da contribuição e a participação do titular em sorteios, sem que haja devolução integral do valor pago. (Res CNSP 384/20)
        /// 5. Incentivo: A modalidade incentivo tem por objetivo a vinculação a um evento promocional de caráter comercial instituído pelo subscritor para alavancar a venda de seu(s) produto(s) ou serviços ou para fidelizar seus clientes. (Res CNSP 384/20)
        /// 6. Filantropia Premiável: A modalidade filantropia premiável é destinada ao subscritor interessado em contribuir com entidades beneficentes de assistências sociais, certificadas nos termos da legislação vigente, e participar de sorteio(s). (Res CNSP 384/20)
        /// </summary>
        [Required]
        public EnumCapitalizationBondsProductModality Modality { get; set; }

        /// <summary>
        /// Pagamento efetuado ao subscritor à sociedade de capitalização para aquisição do título de capitalização, podendo ser única, periódica ou mensal.
        /// 1. Pagamento Único
        /// 2. Pagamento Mensal
        /// 3. Pagamento Periódico
        /// </summary>
        [Required]
        public EnumCapitalizationBondsProductPaymentFrequency CostType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public TermsAndConditions TermsAndConditions { get; set; }

        /// <summary>
        /// Informações relativas às taxas da Quotas praticadas para cada Parcela
        /// </summary>
        [Required]
        public List<CapitalizationBondsProductQuota> Quotas { get; set; }

        /// <summary>
        /// Período entre a data de início e a data final para constituição do capital a ser pago ao(s) titular(es) do direito de resgate. Prazo de vigência do título de capitalização em meses (Resolução CNSP 384/20). Em meses.
        /// </summary>
        public int Validity { get; set; }

        /// <summary>
        /// Os títulos de capitalização que prevejam sorteio devem ser estruturados em séries, ou seja, em sequências ou em grupos de títulos submetidos às mesmas condições e características, à exceção do valor do pagamento.
        /// </summary>
        public int SerieSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public CapitalizationPeriod CapitalizationPeriod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public LatePayment LatePayment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public CapitalizationBondsProductContributionPayment ContributionPayment { get; set; }

        /// <summary>
        /// Percentual mínimo da soma das contribuições efetuadas que poderá ser resgatado ao final da vigência, tendo como condição os pagamentos das parcelas nos respectivos vencimentos.
        /// </summary>
        [Required]
        public string RedemptionPercentageEndTerm { get; set; }

        /// <summary>
        /// Valor percentual (%) de resgate final permitido.
        /// </summary>
        [Required]
        public string FinalRedemptionRate { get; set; }

        /// <summary>
        /// Informações relativas aos Sorteios
        /// </summary>
        [Required]
        public List<PrizeDraw> Draws { get; set; }

        /// <summary>
        /// Campo aberto (possibilidade de incluir URL) Observação: As URLs são limitadas a 2048 caracteres mas, para o contexto do Open Insurance , foi adotado a metade deste tamanho (1024). tamanho p.ex. ‘https://ACME.exemplo/capitalizacao/tradicional/pdf/condicoes_gerais.
        /// </summary>
        [Required]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Campo aberto (possibilidade de incluir URL). Observação: As URLs são limitadas a 2048 caracteres mas, para o contexto do Open Insurance, foi adotado a metade deste tamanho(1024). tamanho.p.ex. ‘https://ACME.exemplo/capitalizacao/tradicional/pdf/condicoes_gerais
        /// </summary>
        public string MinimumRequirementDetails { get; set; }

        /// <summary>
        /// 	A considerar os domínios abaixo:

        /// 1. Pessoa Natural
        /// 2. Pessoa Jurídica
        /// 3. Ambas(Pessoa Natural e Jurídica)
        /// </summary>
        [Required]
        public EnumTargetAudience TargetAudience { get; set; }
    }
}
