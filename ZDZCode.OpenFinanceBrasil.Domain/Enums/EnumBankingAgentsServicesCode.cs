using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumBankingAgentsServicesCode
    {
        /// <summary>
        /// Recepção e encaminhamento de propostas de abertura de contas.
        /// </summary>
        [Description("")]
        RECEBE_ENCAMINHA_PROPOSTAS_ABERTURA_CONTAS = 1,

        /// <summary>
        /// Realização de recebimentos, pagamentos e transferências eletrônicas.
        /// </summary>
        [Description("")]
        REALIZA_RECEBIMENTOS_PAGAMENTOS_TRANSFERENCIAS_ELETRONICAS = 2,

        /// <summary>
        /// Recebimentos e pagamentos de qualquer natureza.
        /// </summary>
        [Description("")]
        RECEBIMENTOS_PAGAMENTOS_QUALQUER_NATUREZA_EXECUCAO_CONTRATOS_CONVENIO = 3,

        /// <summary>
        /// Execução ativa e passiva de ordens de pagamento.
        /// </summary>
        [Description("")]
        EXECUCAO_ATIVA_PASSIVA_ORDENS_PAGAMENTO = 4,

        /// <summary>
        /// Recepção e encaminhamento de propostas de operações de crédito e de arrendamento mercantil.
        /// </summary>
        [Description("")]
        RECEBE_ENCAMINHA_PROPOSTAS_CREDITO_ARRENDAMENTO_MERCANTIL = 5,

        /// <summary>
        /// Recebimento e pagamentos relacionados a letras de câmbio de aceite da instituição.
        /// </summary>
        [Description("")]
        RECEBE_PAGAMENTOS_RELACIONADOS_LETRAS_CAMBIO_ACEITE_INSTITUICAO = 6,

        /// <summary>
        /// Recepção e encaminhamento de propostas de fornecimento de cartões de crédito.
        /// </summary>
        [Description("")]
        RECEBE_ENCAMINHA_PROPOSTAS_FORNECIMENTO_CARTAO_CREDITO = 7,

        /// <summary>
        /// Realização de operações de câmbio.
        /// </summary>
        [Description("")]
        REALIZA_OPERACOES_CAMBIO = 8,

        /// <summary>
        /// Outros.
        /// </summary>
        [Description("")]
        OUTROS = 9,
    }
}
