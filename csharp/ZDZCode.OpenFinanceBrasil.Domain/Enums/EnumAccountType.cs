using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumAccountType
    {
        /// <summary>
        ///Conta de depósito à vista ou Conta corrente - é o tipo mais comum. Nela, o dinheiro fica à sua disposição para ser sacado a qualquer momento. Essa conta não gera rendimentos para o depositante
        /// </summary>
        [Description("Conta de depósito à vista ou Conta corrente")]
        CONTA_DEPOSITO_A_VISTA = 1,

        /// <summary>
        ///Conta poupança - foi criada para estimular as pessoas a pouparem. O dinheiro que ficar na conta por trinta dias passa a gerar rendimentos, com isenção de imposto de renda para quem declara. Ou seja, o dinheiro “cresce” (rende) enquanto ficar guardado na conta. Cada depósito terá rendimentos de mês em mês, sempre no dia do mês em que o dinheiro tiver sido depositado
        /// </summary>
        [Description("Conta poupança ")]
        CONTA_POUPANCA = 2,

        /// <summary>
        ///Conta de pagamento pré-paga: segundo CIRCULAR Nº 3.680, BCB de 2013, é a 'destinada à execução de transações de pagamento em moeda eletrônica realizadas com base em fundos denominados em reais previamente aportados.'
        /// </summary>
        [Description("Conta poupança ")]
        CONTA_PAGAMENTO = 3,
    }
}
