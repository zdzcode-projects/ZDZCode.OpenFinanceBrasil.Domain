using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumSharedAutomatedTellerMachinesServicesCodes
    {
        /// <summary>
        /// abre conta deposito ou pre paga
        /// </summary>
        [Description("abre conta deposito ou pre paga")]
        ABRE_CONTA_DEPOSITO_OU_PRE_PAGA = 1,


        /// <summary>
        /// saque moeda em especie
        /// </summary>
        [Description("saque moeda em especie")]
        SAQUE_MOEDA_ESPECIE = 2,


        /// <summary>
        /// recebe e paga de qualquer natureza
        /// </summary>
        [Description("recebe paga de qualquer natureza")]
        RECEBE_PAGA_QUALQUER_NATUREZA = 3,


        /// <summary>
        ///  transaferencia eletronica , movimenta conta deposito ou paga titulares e clientes
        /// </summary>
        [Description("transferencia eletronica ")]
        TRANSFERENCIAS_ELETRONICAS_MOVIMENTA_CONTAS_DEPOSITOS_OU_PAGA_TITULARES_CLIENTES = 4,


        /// <summary>
        /// consulta saldo e extrato de contas depositos
        /// </summary>
        [Description("consulta saldo e extrato de contas depositos")]
        CONSULTA_SALDOS_EXTRATOS_CONTAS_DEPOSITOS = 5,


        /// <summary>
        /// PAGAMENTOS
        /// </summary>
        [Description("pagamentos")]
        PAGAMENTOS = 6,


        /// <summary>
        /// aplica e resgata investimentos
        /// </summary>
        [Description("aplica e resgata investimentos")]
        APLICA_RESGATA_INVESTIMENTOS = 7,


        /// <summary>
        /// executa ativa passiva ordens de pagamento
        /// </summary>
        [Description("executa ativa passiva ordens de pagamento")]
        EXECUTA_ATIVA_PASSIVA_ORDENS_PAGAMENTO = 8,


        /// <summary>
        /// deposita moeda em especie e cheque
        /// </summary>
        [Description("deposita moeda em especie e cheque")]
        DEPOSITA_MOEDA_ESPECIE_CHEQUE = 9,


        /// <summary>
        /// opera credito de outros serviços acampanha operação"
        /// </summary>
        [Description("opera credito de outros serviços acampanha operação")]
        OPERA_CREDITO_OUTROS_SERVICOS_ACOMPANHA_OPERACAO = 10,


        /// <summary>
        /// cartão de credito
        /// </summary>
        [Description("cartão de credito")]
        CARTAO_CREDITO = 11,


        /// <summary>
        /// seguros
        /// </summary>
        [Description("seguros")]
        SEGUROS = 12,


        /// <summary>
        /// opera arrendamento mercantil
        ///  </summary>
        [Description("opera arrendamento mercantil")]
        OPERA_ARRENDAMENTO_MERCANTIL = 13,


        /// <summary>
        /// abertura de conta de ppagamento pos paga
        /// </summary>
        [Description("abertura de conta de ppagamento pos paga")]
        ABERTURA_CONTA_PAGAMENTO_POS_PAGA = 14,

        /// <summary>
        /// compra e venda de moeda estrangeira em especie
        /// </summary>
        [Description("compra e venda de moeda estrangeira em especie")]
        COMPRA_VENDE_MOEDA_ESTRANGEIRA_ESPECIE = 15,


        /// <summary>
        /// compra e vende cheque cheque viagem carga moeda estrangeira cartao pre pago
        /// </summary>
        [Description("compra e vende cheque cheque viagem carga moeda estrangeira cartao pre pago")]
        COMPRA_VENDE_CHEQUE_CHEQUE_VIAGEM_CARGA_MOEDA_ESTRANGEIRA_CARTAO_PRE_PAGO = 16,

        /// <summary>
        /// compra e venda de ouro
        /// </summary>
        [Description("compra e venda de ouro")]
        COMPRA_VENDE_OURO = 17,


        /// <summary>
        /// outros produtos e serviços
        /// </summary>
        [Description("outros produtos e serviços ")]
        OUTROS_PRODUTOS_SERVICOS = 18,


        /// <summary>
        /// cancelamento
        /// </summary>
        [Description("cancelamento")]
        CANCELAMENTO = 19,


        /// <summary>
        /// informações
        /// </summary>
        [Description("informações")]
        INFLRMACOES = 20,

        /// <summary>
        /// reclamações
        /// </summary>
        [Description("reclamações")]
        RECLAMACOES = 21,

    }
}
