using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumBranchServicesCodes 
    {
        /// <summary>
        /// Abertura de Contas, depósitos ou Pagamento Pré Paga
        /// </summary>
        [Description("Abertura de Contas, depósitos ou Pagamento Pré Paga")]
        ABRE_CONTA_DEPOSITO_OU_PRE_PAGA = 1,

        /// <summary>
        /// Saques de Moedas em Espécie
        /// </summary>
        [Description("Saques de Moedas em Espécie")]
        SAQUE_MOEDA_EM_ESPECIE = 2,

        /// <summary>
        /// Recebimentos e pagamentos de qualquer natureza
        /// </summary>
        [Description("Recebimentos e pagamentos de qualquer natureza")]
        RECEBE_PAGA_QUALQUER_NATUREZA = 3,

        /// <summary>
        /// Transferências Eletrônicas
        /// </summary>
        [Description("Transferências Eletrônicas")]
        TRANSFERENCIAS_ELETRONICAS_MOVIMENTA_CONTAS_DEPOSITOS_OU_PAGTO_TITULARES_CLIENTES = 4,

        /// <summary>
        /// Consulta de Saldos e Extratos
        /// </summary>
        [Description("Consulta de Saldos e Extratos")]
        CONSULTA_SALDOS_EXTRATOS_CONTAS_DEPOSITOS_PAGTOS = 5,

        /// <summary>
        /// Aplicações, Resgates e Investimentos.
        /// </summary>
        [Description("Aplicações, Resgates e Investimentos")]
        APLICACOES_RESGATES_INVESTIMENTOS = 6,

        /// <summary>
        /// Execução Ativa e Passiva, Ordens de Pagamento e Solicitações de Clientes e Usuários.
        /// </summary>
        [Description("Execução Ativa e Passiva, Ordens de Pagamento e Solicitações de Clientes e Usuários.")]
        EXECUCAO_ATIVA_PASSIVA_ORDENS_PAGTO  = 7,


        /// <summary>
        ///Depósitos de Moeda em Espécie ou Cheque
        /// </summary>
        [Description("Depósitos de Moeda em Espécie ou Cheque")]
        DEPOSITO_MOEDA_ESPECIE_CHEQUE = 8,

        /// <summary>
        ///Operações de Crédito
        /// </summary>
        [Description("Operações de Crédito")]
        OPERA_CREDITO_OUTROS_SERVICOS_ACOMPANHA_OPERACAO = 9,

        /// <summary>
        /// Cartão de Crédito
        /// </summary>
        [Description("Cartão de Crédito")]
        CARTAO_CREDITO = 10,

        /// <summary>
        /// Seguros
        /// </summary>
        [Description("Seguros")]
        SEGUROS = 11,

        /// <summary>
        /// Operações de Arrendamento Mercantil
        /// </summary>
        [Description("Operações de Arrendamento Mercantil")]
        OPERA_ARRENDAMENTO_MERCANTIL = 12,

        /// <summary>
        /// Abertura de Conta Pagamento Pós Paga
        /// </summary>
        [Description("Abertura de Conta Pagamento Pós Paga")]
        ABERTURA_CONTA_PAGAMENTO_POS_PAGA = 13,

        /// <summary>
        /// Compra e Venda de Moeda Estrangeira em Espécie
        /// </summary>
        [Description("Compra e Venda de Moeda Estrangeira em Espécie")]
        COMPRA_VENDA_MOEDA_ESTRANGEIRA_ESPECIE = 14,

        /// <summary>
        /// Compra e Venda em Cheque, Cheque Viagem, Cartão Pré-Pago e Carga em Moeda Entrangeira
        /// </summary>
        [Description("Compra e Venda em Cheque, Cheque Viagem, Cartão Pré-Pago e Carga em Moeda Entrangeira")]
        COMPRA_VENDA_CHEQUE_CHEQUE_VIAGEM_CARGA_MOEDA_ESTRANGEIRA_CARTAO_PRE_PAGO = 15,

        /// <summary>
        /// Compra e Venda de Ouro 
        /// </summary>
        [Description("Compra e Venda de Ouro ")]
        COMPRA_VENDA_OURO = 16,

        /// <summary>
        /// Outros Produtos e Serviços
        /// </summary>
        [Description("Outros Produtos e Serviços")]
        OUTROS_PRODUTOS_SERVICOS = 17,

        /// <summary>
        /// Cancelamento
        /// </summary>
        [Description("Cancelamento")]
        CANCELAMENTO = 18,

        /// <summary>
        /// Informações
        /// </summary>
        [Description("Informações")]
        INFORMACOES = 19,

        /// <summary>
        /// Reclamações
        /// </summary>
        [Description("Reclamações")]
        RECLAMACOES = 20,

    }
}
