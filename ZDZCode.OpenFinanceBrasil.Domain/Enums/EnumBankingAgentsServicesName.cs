using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumBankingAgentsServicesName
    {
        /// <summary>
        /// Recepção e encaminhamento de propostas de abertura de contas.
        /// </summary>
        [Description("Recepção e encaminhamento de propostas de abertura de contas.")]
        MOVELRECEPCAO_ENCAMINHAMENTO_PROPOSTAS_ABERTURA_CONTAS_DEPOSITOS_VISTA_PRAZO_POUPANCA_MANTIDOS_INSTITUICAO_CONTRATANTE = 1,

        /// <summary>
        /// Realização de recebimentos, pagamentos e transferências eletrônicas.
        /// </summary>
        [Description("Realização de recebimentos, pagamentos e transferências eletrônicas.")]
        REALIZACAO_RECEBIMENTOS_PAGAMENTOS_TRANSFERENCIAS_ELETRONICAS_VISANDO_MOVIMENTACAO_CONTAS_DEPOSITOS_TITULARIDADE_CLIENTES_MANTIDAS_INSTITUICAO_CONTRATANTE = 2,

        /// <summary>
        /// Recebimentos e pagamentos de qualquer natureza.
        /// </summary>
        [Description("Recebimentos e pagamentos de qualquer natureza.")]
        RECEBIMENTOS_PAGAMENTOS_QUALQUER_NATUREZA_OUTRAS_ATIVIDADES_DECORRENTES_EXECUCAO_CONTRATOS_CONVENIOS_PRESTACAO_SERVICOS = 3,

        /// <summary>
        /// Execução ativa e passiva de ordens de pagamento.
        /// </summary>
        [Description("Execução ativa e passiva de ordens de pagamento.")]
        EXECUCAO_ATIVA_PASSIVA_ORDENS_PAGAMENTO_CURSADAS_INTERMEDIO_INSTITUICAO_CONTRATANTE_SOLICITACAO_CLIENTES_USUARIOS = 4,


        /// <summary>
        /// Recepção e encaminhamento de propostas de operações de crédito e de arrendamento mercantil.
        /// </summary>
        [Description("Recepção e encaminhamento de propostas de operações de crédito e de arrendamento mercantil.")]
        RECEPCAO_ENCAMINHAMENTO_PROPOSTAS_OPERACAO_CREDITO_ARRENDAMENTO_MERCANTIL_CONCESSAO_INSTITUICAO_CONTRATANTE = 5,

        /// <summary>
        /// Recebimento e pagamentos relacionados a letras de câmbio de aceite da instituição.
        /// </summary>
        [Description("Recebimento e pagamentos relacionados a letras de câmbio de aceite da instituição.")]
        RECEBIMENTOS_PAGAMENTOS_RELACIONADOS_LETRAS_CAMBIO_ACEITE_INSTITUICAO_CONTRATANTE = 6,

        /// <summary>
        /// Recepção e encaminhamento de propostas de fornecimento de cartões de crédito.
        /// </summary>
        [Description("Recepção e encaminhamento de propostas de fornecimento de cartões de crédito.")]
        RECEPCAO_ENCAMINHAMENTO_PROPOSTAS_FORNECIMENTO_CARTAO_CREDITO_RESPONSABILIDADE_INSTITUICAO_CONTRATANTE = 7,

        /// <summary>
        /// Realização de operações de câmbio.
        /// </summary>
        [Description("Realização de operações de câmbio.")]
        REALIZACAO_OPERACOES_CAMBIO_RESPONSABILIDADE_INSTITUICAO_CONTRATANTE = 8,

        /// <summary>
        /// Outros
        /// </summary>
        [Description("Outros")]
        OUTROS = 9,
    }
}
