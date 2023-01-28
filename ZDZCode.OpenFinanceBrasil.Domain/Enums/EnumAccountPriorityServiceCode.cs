using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumAccountPriorityServiceCode
    {
        // Se encontra no opem banking a baixo de EndpointUptime

        /// <summary>
        /// 	Cadastro
        /// </summary>
        [Description("	Cadastro")]
        CADASTRO = 1,

        /// <summary>
        /// 2ª via cartão de débito
        /// </summary>
        [Description("2ª via cartão de débito")]
        SEGUNDA_VIA_CARTAO_DEBITO = 2,

        /// <summary>
        ///2ª via cartão poupança
        /// </summary>
        [Description("2ª via cartão poupança")]
        SEGUNDA_VIA_CARTAO_POUPANCA = 3,

        /// <summary>
        ///Exclusão CCF
        /// </summary>
        [Description("Exclusão CCF")]
        EXCLUSAO_CCF = 4,

        /// <summary>
        ///Sustação / Revogação
        /// </summary>
        [Description("Sustação / Revogação")]
        SUSTACAO_REVOGACAO =5,

        /// <summary>
        ///Fornecimento Folha de cheque
        /// </summary>
        [Description("Fornecimento Folhas Cheque")]
        FOLHAS_CHEQUE =6,

        /// <summary>
        ///Cheque Administrativo
        /// </summary>
        [Description("Cheque Administrativo")]
        CHEQUE_ADMINISTRATIVO =7,

        /// <summary>
        ///Cheque Visado
        /// </summary>
        [Description("Cheque Visado")]
        CHEQUE_VISADO =8,

        /// <summary>
        ///Saque Pessoal ou Presencial
        /// </summary>
        [Description("Saque Pessoal ou Presencial")]
        SAQUE_PESSOAL =9,


        /// <summary>
        ///Saque Terminal autoatendimento
        /// </summary>
        [Description("Saque Terminal autoatendimento")]
        SAQUE_TERMINAL =10,

        /// <summary>
        /// Saque Correspondente no Pais
        /// </summary>
        [Description("Saque Correspondente no Pais")]
        SAQUE_CORRESPONDENTE	 = 11,

         /// <summary>
        ///Depósito identificado
        /// </summary>
        [Description("Depósito identificado")]
        DEPOSITO_IDENTIFICADO = 12,

        /// <summary>
        ///	Extrato mensal presencial
        /// </summary>
        [Description("Extrato mensal presencial")]
        EXTRATO_MES_P = 13,

        /// <summary>
        ///Extrato mensal meios eletrônicos
        /// </summary>
        [Description("Extrato mensal meios eletrônicos")]
        EXTRATO_MES_E = 14,

        /// <summary>
        ///Extrato mensal Correspondente no Pais
        /// </summary>
        [Description("Extrato mensal Correspondente no Pais")]
        EXTRATO_MES_C = 15,

         /// <summary>
        ///Extrato por período presencial
        /// </summary>
        [Description("Extrato por período presencial")]
        EXTRATO_MOVIMENTO_P = 16,

         /// <summary>
        ///Extrato por período meio eletrônico
        /// </summary>
        [Description("Extrato por período meio eletrônico")]
        EXTRATO_MOVIMENTO_E = 17,

         /// <summary>
        ///Extrato por período Correspondente no Pais
        /// </summary>
        [Description("Extrato por período Correspondente no Pais")]
        EXTRATO_MOVIMENTO_C	= 18,

        /// <summary>
        ///Fornecimento de cópia de microfilme, microficha ou assemelhado
        /// </summary>
        [Description("Fornecimento de cópia de microfilme, microficha ou assemelhado")]
        MICROFILME = 19,

            /// <summary>
            ///Transferência por DOC meios eletrônicos
            /// </summary>
        [Description("Transferência por DOC meios eletrônicosl")]
        DOC_ELETRONICO = 21,

            /// <summary>
            ///Transferência por TED via Internet
            /// </summary>
        [Description("Transferência por TED via Internet")]
        DOC_INTERNET = 22,

            /// <summary>
            ///Transferência por TED pessoal ou presencial
            /// </summary>
        [Description("Transferência por TED pessoal ou presencial")]
        TED_PESSOAL = 23,

            /// <summary>
            ///Extrato por período Correspondente no Pais
            /// </summary>
        [Description("	Transferência por TED meio eletrônico")]
        TED_ELETRONICO = 24,

            /// <summary>
            ///Transferência por TED via Internet
            /// </summary>
        [Description("Transferência por TED via Internet")]
        TED_INTERNET = 25,

            /// <summary>
            ///Transferência agendada TED ou DOC presencial ou pessoal
            /// </summary>
        [Description("Transferência agendada TED ou DOC presencial ou pessoal")]
        DOC_TED_AGENDADO_P = 26,

            /// <summary>
            ///Transferência agendada TED ou DOC via Internet
            /// </summary>
        [Description("Transferência agendada TED ou DOC via Internet")]
        DOC_TED_AGENDADO_E = 27,

            /// <summary>
            ///Extrato por período Correspondente no Pais
            /// </summary>
        [Description("Extrato por período Correspondente no Pais")]
        DOC_TED_AGENDADO_I = 28,

            /// <summary>
            ///Transferência entre contas própria instituição presencial ou pessoal
            /// </summary>
        [Description("Transferência entre contas própria instituição presencial ou pessoal")]
        TRANSF_RECURSO_P = 29,

            /// <summary>
            ///Transferência entre contas própria instituição por meios eletrônicos ou Internet
            /// </summary>
        [Description("Transferência entre contas própria instituição por meios eletrônicos ou Internet")]
        TRANSF_RECURSO_E = 30,

            /// <summary>
            ///Ordem de Pagamento
            /// </summary>
        [Description("Ordem de Pagamento")]
        ORDEM_PAGAMENTO = 31,

            /// <summary>
            ///ANUIDADE NACIONAL
            /// </summary>
        [Description("ANUIDADE NACIONAL")]
        ANUIDADE_NACIONAL = 32,

            /// <summary>
            ///ANUIDADE INTERNACIONAL
            /// </summary>
        [Description("ANUIDADE INTERNACIONAL")]
        ANUIDADE_INTERNACIONAL = 33,

            /// <summary>
            ///ANUIDADE DIFERENCIADA
            /// </summary>
        [Description("ANUIDADE DIFERENCIADA")]
        ANUIDADE_DIFERENCIADA = 34,

              /// <summary>
              ///SAQUE CARTAO BRASIL
              /// </summary>
        [Description("SAQUE CARTAO BRASIL")]
        SAQUE_CARTAO_BRASIL = 35,

              /// <summary>
              ///SAQUE CARTAO EXTERIOR
              /// </summary>
        [Description("SAQUE CARTAO EXTERIOR")]
        SAQUE_CARTAO_EXTERIOR = 36,

              /// <summary>
              ///AVALIACAO EMERGENCIAL CREDITO
              /// </summary>
        [Description("AVALIACAO EMERGENCIAL CREDITO")]
        AVALIACAO_EMERGENCIAL_CREDITO = 37,

              /// <summary>
              ///EMISSAO SEGUNDA VIA
              /// </summary>
        [Description("EMISSAO SEGUNDA VIA")]
        EMISSAO_SEGUNDA_VIA = 38,

              /// <summary>
              ///TARIFA PAGAMENTO CONTAS
              /// </summary>
        [Description("TARIFA PAGAMENTO CONTAS")]
        TARIFA_PAGAMENTO_CONTAS = 39,

              /// <summary>
              ///SMS
              /// </summary>
        [Description("SMS")]
        SMS = 40,





    }
}
