using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumPriorityServiceName
    {
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
        EXCLUSAO_CCF =4,

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
        ///Saque Conta Deposito a Vista Poupança PRESENCIAL OU PESSOAL
        /// </summary>
        [Description("Saque Conta Deposito a Vista Poupança PRESENCIAL OU PESSOAL")]
        SAQUE_CONTA_DEPOSITO_A_VISTA_POUPANCA_PRESENCIAL_OU_PESSOAL =9,


        /// <summary>
        ///Saque Conta Deposito a Vista Poupança TERMINAL AUTOATENDIMENTO
        /// </summary>
        [Description("Saque Conta Deposito a Vista Poupança TERMINAL AUTOATENDIMENTO")]
        SAQUE_CONTA_DEPOSITO_A_VISTA_POUPANCA_TERMINAL_AUTOATENDIMENTO = 10,

        /// <summary>
        ///Saque Conta Deposito a Vista Poupança CORRESPONDENTES PAIS
        /// </summary>
        [Description("Saque Conta Deposito a Vista Poupança CORRESPONDENTES PAIS")]
        SAQUE_CONTA_DEPOSITO_A_VISTA_POUPANCA_CORRESPONDENTES_PAIS =11,


        /// <summary>
        ///Deposito Identificado
        /// </summary>
        [Description("Deposito Identificado")]
        DEPOSITO_IDENTIFICADO =12,

        /// <summary>
        ///Fornecimento Extrato Mensal Conta Depositos a Vista e Poupança PRESENCIAL ou PESSOAL
        /// </summary>
        [Description("Fornecimento Extrato Mensal Conta Depositos a Vista e Poupança PRESENCIAL ou PESSOAL")]
        FORNECIMENTO_EXTRATO_MENSAL_CONTA_DEPOSITOS_A_VISTA_E_POUPANCA_PRESENCIAL_OU_PESSOAL =13,

        /// <summary>
        ///Fornecimento Extrato Mensal Conta Depositos a Vista e Poupança TERMINAL AUTOATENDIMENTO
        /// </summary>
        [Description("Fornecimento Extrato Mensal Conta Depositos a Vista e Poupança TERMINAL AUTOATENDIMENTO")]
        FORNECIMENTO_EXTRATO_MENSAL_CONTA_DEPOSITOS_A_VISTA_E_POUPANCA_TERMINAL_AUTOATENDIMENTO = 14,

        /// <summary>
        ///Fornecimento Extrato Mensal Conta Depositos a Vista e Poupança CORRESPONDENTES PAIS
        /// </summary>
        [Description("Fornecimento Extrato Mensal Conta Depositos a Vista e Poupança CORRESPONDENTES PAIS")]
        FORNECIMENTO_EXTRATO_MENSAL_CONTA_DEPOSITOS_A_VISTA_E_POUPANCA_CORRESPONDENTES_PAIS =15,

        /// <summary>
        ///Fornecimento Extrato de um Período Conta Depositos à Vista e Poupança PRESENCIAL OU PESSOAL
        /// </summary>
        [Description("Fornecimento Extrato de um Período Conta Depositos à Vista e Poupança PRESENCIAL OU PESSOAL")]
        FORNECIMENTO_EXTRATO_DE_UM_PERIODO_CONTA_DEPOSITOS_A_VISTA_E_POUPANCA_PRESENCIAL_OU_PESSOAL =16,

        /// <summary>
        ///Fornecimento Extrato de um Período Conta Depositos à Vista e Poupança TERMINAL AUTOATENDIMENTO
        /// </summary>
        [Description("Fornecimento Extrato de um Período Conta Depositos à Vista e Poupança TERMINAL AUTOATENDIMENTO")]
        FORNECIMENTO_EXTRATO_DE_UM_PERIODO_CONTA_DEPOSITOS_A_VISTA_E_POUPANCA_TERMINAL_AUTOATENDIMENTO =17,

        /// <summary>
        ///Fornecimento Extrato de um Período Conta Depositos à Vista e Poupança CORRESPONDENTES PAIS
        /// </summary>
        [Description("Fornecimento Extrato de um Período Conta Depositos à Vista e Poupança CORRESPONDENTES PAIS")]
        FORNECIMENTO_EXTRATO_DE_UM_PERIODO_CONTA_DEPOSITOS_A_VISTA_E_POUPANCA_CORRESPONDENTES_PAIS =18,


        /// <summary>
        ///Fornecimento Copia Microfilme Microficha Assemelhado
        /// </summary>
        [Description("Fornecimento Copia Microfilme Microficha Assemelhado")]
        FORNECIMENTO_COPIA_MICROFILME_MICROFICHA_ASSEMELHADO =19,

        /// <summary>
        ///Transferência DOC Pessoal ou Presencial
        /// </summary>
        [Description("Transferência DOC Pessoal ou Presencial")]
        TRANSFERENCIA_DOC_PESSOAL_OU_PRESENCIAL =20,

        /// <summary>
        ///Transferência DOC Terminal Autoatendimento outros meios eletrônicos
        /// </summary>
        [Description("Transferência DOC Terminal Autoatendimento outros meios eletrônicos")]
        TRANSFERENCIA_DOC_TERMINAL_AUTOATENDIMENTO_OUTROS_MEIOS_ELETRONICOS =21,

        /// <summary>
        ///Transferência DOC INTERNET
        /// </summary>
        [Description("Transferência DOC INTERNET")]
        TRANSFERENCIA_DOC_INTERNET =22,

        /// <summary>
        ///Transferência TED Pessoal ou Presencial
        /// </summary>
        [Description("Transferência TED Pessoal ou Presencial")]
        TRANSFERENCIA_TED_PESSOAL_OU_PRESENCIAL =23,

        /// <summary>
        ///Transferência TED Terminal Autoatendimento outros meios eletrônicos
        /// </summary>
        [Description("Transferência TED Terminal Autoatendimento outros meios eletrônicos")]
        TRANSFERENCIA_TED_TERMINAL_AUTOATENDIMENTO_OUTROS_MEIOS_ELETRONICOS =24,

        /// <summary>
        ///Transferência TED INTERNET
        /// </summary>
        [Description("Transferência TED INTERNET")]
        TRANSFERENCIA_TED_INTERNET =25,

        /// <summary>
        ///Transferência DOC e TED Pessoal ou Presencial
        /// </summary>
        [Description("Transferência DOC e TED Pessoal ou Presencial")]
        TRANSFERENCIA_DOC_TED_PESSOAL_OU_PRESENCIAL =27,

        /// <summary>
        ///Transferência DOC e TED Terminal Autoatendimento outros meios eletrônicos
        /// </summary>
        [Description("Transferência DOC e TED Terminal Autoatendimento outros meios eletrônicos")]
        TRANSFERENCIA_DOC_TED_TERMINAL_AUTOATENDIMENTO_OUTROS_MEIOS_ELETRONICOS =28,

        /// <summary>
        ///Transferência DOC e TED INTERNET
        /// </summary>
        [Description("Transferência DOC e TED INTERNET")]
        TRANSFERENCIA_DOC_TED_INTERNET =29,

        /// <summary>
        ///Transferências entre contas própria instituição pessoal ou presencial
        /// </summary>
        [Description("Transferências entre contas própria instituição pessoal ou presencial")]
        TRANSFERENCIA_ENTRE_CONTAS_PROPRIA_INSTITUICAO_PESSOAL_OU_PRESENCIAL =30,

        /// <summary>
        ///Transferências entre contas própria instituição Terminal autoatendimento outros meios eletronicos inclusive Internet
        /// </summary>
        [Description("Transferências entre contas própria instituição Terminal autoatendimento outros meios eletronicos inclusive Internet")]
        TRANSFERENCIA_ENTRE_CONTAS_PROPRIA_INSTITUICAO_TERMINAL_AUTOATENDIMENTO_OUTROS_MEIOS_ELETRONICOS_INCLUSIVE_INTERNET =31,

        /// <summary>
        ///ORDEM PAGAMENTO
        /// </summary>
        [Description("ORDEM PAGAMENTO")]
        ORDEM_PAGAMENTO = 32,

        /// <summary>
        ///ANUIDADE CARTAO BASICO NACIONAL
        /// </summary>
        [Description("ANUIDADE CARTAO BASICO NACIONAL")]
        ANUIDADE_CARTAO_BASICO_NACIONAL =33,

        /// <summary>
        ///ANUIDADE CARTAO BASICO INTERNACIONAL
        /// </summary>
        [Description("ANUIDADE CARTAO BASICO INTERNACIONAL")]
        ANUIDADE_CARTAO_BASICO_INTERNACIONAL =34,

        /// <summary>
        ///ANUIDADE DIFERENCIADA
        /// </summary>
        [Description("ANUIDADE DIFERENCIADA")]
        ANUIDADE_DIFERENCIADA =35,

        /// <summary>
        ///UTILIZACAO CANAIS ATENDIMENTO RETIRADA ESPECIE BRASIL
        /// </summary>
        [Description("UTILIZACAO CANAIS ATENDIMENTO RETIRADA ESPECIE BRASIL")]
        UTILIZACAO_CANAIS_ATENDIMENTO_RETIRADA_ESPECIE_BRASIL =36,

        /// <summary>
        ///UTILIZACAO CANAIS ATENDIMENTO RETIRADA ESPECIE EXTERIOR
        /// </summary>
        [Description("UTILIZACAO CANAIS ATENDIMENTO RETIRADA ESPECIE EXTERIOR")]
        UTILIZACAO_CANAIS_ATENDIMENTO_RETIRADA_ESPECIE_EXTERIOR =37,

        /// <summary>
        ///AVALIACAO EMERGENCIAL CREDITO
        /// </summary>
        [Description("AVALIACAO EMERGENCIAL CREDITO")]
        AVALIACAO_EMERGENCIAL_CREDITO = 38,

        /// <summary>
        ///FORNECIMENTO SEGUNDA VIA FUNCAO CREDITO
        /// </summary>
        [Description("FORNECIMENTO SEGUNDA VIA FUNCAO CREDITO")]
        FORNECIMENTO_SEGUNDA_VIA_FUNCAO_CREDITO = 39,

        /// <summary>
        ///PAGAMENTO CONTAS UTILIZANDO FUNCAO CREDITO
        /// </summary>
        [Description("PAGAMENTO CONTAS UTILIZANDO FUNCAO CREDITO")]
        PAGAMENTO_CONTAS_UTILIZANDO_FUNCAO_CREDITO =40,

        /// <summary>
        ///SMS
        /// </summary>
        [Description("SMS")]
        SMS =41,

    }
}
