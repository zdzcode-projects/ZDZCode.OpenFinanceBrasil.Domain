using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AccountData
    {
        /// <summary>
        /// Nome da Marca reportada pelo participante do Open Banking. O conceito a que se refere a 'marca' é em essência uma promessa da empresa em fornecer uma série específica de atributos, benefícios e serviços uniformes aos clientes.
        /// </summary>
        [Required]
        public string BrandName { get; set; }

        /// <summary>
        /// Número completo do CNPJ da instituição responsável pelo Cadastro - o CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara.
        /// </summary>
        [Required]
        public string CompanyCnpj { get; set; }

        /// <summary>
        /// Tipos de contas. Modalidades tradicionais previstas pela Resolução 4.753, não contemplando contas vinculadas, conta de domiciliados no exterior, contas em moedas estrangeiras e conta correspondente moeda eletrônica. Vide Enum
        /// Conta de depósito à vista ou Conta corrente - é o tipo mais comum.Nela, o dinheiro fica à sua disposição para ser sacado a qualquer momento.Essa conta não gera rendimentos para o depositante
        /// Conta poupança - foi criada para estimular as pessoas a pouparem.O dinheiro que ficar na conta por trinta dias passa a gerar rendimentos, com isenção de imposto de renda para quem declara.Ou seja, o dinheiro “cresce” (rende) enquanto ficar guardado na conta. Cada depósito terá rendimentos de mês em mês, sempre no dia do mês em que o dinheiro tiver sido depositado
        /// Conta de pagamento pré-paga: segundo CIRCULAR Nº 3.680, BCB de 2013, é a 'destinada à execução de transações de pagamento em moeda eletrônica realizadas com base em fundos denominados em reais previamente aportados'
        /// </summary>
        [Required]
        public EnumAccountType Type { get; set; }

        /// <summary>
        /// Código identificador atribuído pelo Banco Central do Brasil às instituições participantes do STR (Sistema de Transferência de reservas).O Compe (Sistema de Compensação de Cheques e Outros Papéis) é um sistema que identifica e processa as compensações bancárias. Ele é representado por um código de três dígitos que serve como identificador de bancos, sendo assim, cada instituição bancária possui um número exclusivo.
        /// </summary>
        [Required]
        public string CompeCode { get; set; }

        /// <summary>
        /// Código da Agência detentora da conta. (Agência é a dependência destinada ao atendimento aos clientes, ao público em geral e aos associados de cooperativas de crédito, no exercício de atividades da instituição, não podendo ser móvel ou transitória).
        /// </summary>
        [Required]
        public string BranchCode { get; set; }

        /// <summary>
        /// Número da conta.
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Dígito da conta.
        /// </summary>
        [Required]
        public string CheckDigit { get; set; }

        /// <summary>
        /// Identifica de forma única a conta do cliente, mantendo as regras de imutabilidade dentro da instituição transmissora.
        /// </summary>
        [Required]
        public string AccountId { get; set; }
    }
}
