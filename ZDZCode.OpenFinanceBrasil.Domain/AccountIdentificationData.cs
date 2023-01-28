using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AccountIdentificationData
    {
        /// <summary>
        /// Código identificador atribuído pelo Banco Central do Brasil às instituições participantes do STR (Sistema de Transferência de reservas). O número-código substituiu o antigo código COMPE. Todos os participantes do STR, exceto as Infraestruturas do Mercado Financeiro (IMF) e a Secretaria do Tesouro Nacional, possuem um número-código independentemente de participarem da Centralizadora da Compensação de Cheques (Compe). O campo tem a anotação “n/a” (“não se aplica”) para os participantes do STR aos quais não é atribuído um número-código
        /// </summary>
        [Required]
        public string CompeCode { get; set; }

        /// <summary>
        /// Código da Agência detentora da conta. (Agência é a dependência destinada ao atendimento aos clientes, ao público em geral e aos associados de cooperativas de crédito, no exercício de atividades da instituição, não podendo ser móvel ou transitória)
        /// </summary>
        [Required]
        public string BranchCode { get; set; }

        /// <summary>
        /// Número da conta
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Dígito da conta
        /// </summary>
        [Required]
        public string CheckDigit { get; set; }

        /// <summary>
        /// Tipos de contas. Modalidades tradicionais previstas pela Resolução 4.753, não contemplando contas vinculadas, conta de domiciliados no exterior, contas em moedas estrangeiras e conta correspondente moeda eletrônica. Vide Enum
        /// Conta de depósito à vista ou Conta corrente - é o tipo mais comum.Nela, o dinheiro fica à sua disposição para ser sacado a qualquer momento.Essa conta não gera rendimentos para o depositante
        /// Conta poupança - foi criada para estimular as pessoas a pouparem.O dinheiro que ficar na conta por trinta dias passa a gerar rendimentos, com isenção de imposto de renda para quem declara.Ou seja, o dinheiro “cresce” (rende) enquanto ficar guardado na conta. Cada depósito terá rendimentos de mês em mês, sempre no dia do mês em que o dinheiro tiver sido depositado
        /// Conta de pagamento pré-paga: segundo CIRCULAR Nº 3.680, BCB de 2013, é a 'destinada à execução de transações de pagamento em moeda eletrônica realizadas com base em fundos denominados em reais previamente aportados'
        /// </summary>
        [Required]
        public EnumAccountType Type { get; set; }

        /// <summary>
        /// Subtipo de conta (vide Enum): Conta individual - possui um único titular
        /// Conta conjunta simples - onde as movimentações financeiras só podem serem realizadas mediante autorização de TODOS os correntistas da conta.
        /// Conta conjunta solidária - é a modalidade cujos titulares podem realizar movimentações de forma isolada, isto é, sem que seja necessária a autorização dos demais titulares
        /// </summary>
        [Required]
        public EnumAccountSubType Subtype { get; set; }

        /// <summary>
        /// Moeda referente ao valor da transação, segundo modelo ISO-4217. p.ex. 'BRL' Todos os saldos informados estão representados com a moeda vigente do Brasil
        /// </summary>
        [Required]
        public string Currency { get; set; }
    }
}
