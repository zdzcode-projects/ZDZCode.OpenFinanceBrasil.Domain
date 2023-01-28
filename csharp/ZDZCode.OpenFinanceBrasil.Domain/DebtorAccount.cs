using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class DebtorAccount
    {
        /// <summary>
        /// Deve ser preenchido com o ISPB (Identificador do Sistema de Pagamentos Brasileiros) do participante do SPI (Sistema de pagamentos instantâneos) somente com números.
        /// </summary>
        [Required]
        public string Ispb { get; set; }

        /// <summary>
        /// Código da Agência emissora da conta sem dígito. (Agência é a dependência destinada ao atendimento aos clientes, ao público em geral e aos associados de cooperativas de crédito, no exercício de atividades da instituição, não podendo ser móvel ou transitória). Restrição] Preenchimento obrigatório para os seguintes tipos de conta: CACC(CONTA_DEPOSITO_A_VISTA), SVGS(CONTA_POUPANCA) e SLRY(CONTA_SALARIO).
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Deve ser preenchido com o número da conta transacional do usuário pagador, com dígito verificador (se este existir), se houver valor alfanumérico, este deve ser convertido para 0.
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Tipos de contas usadas para pagamento via Pix.
        /// Modalidades tradicionais previstas pela Resolução 4.753, não contemplando contas vinculadas, conta de domiciliados no exterior, contas em moedas estrangeiras e conta correspondente moeda eletrônica.
        /// Segue descrição de cada valor do ENUM para o escopo do Pix.
        /// CACC - Current - Conta Corrente.
        /// SLRY - Salary - Conta-Salário.
        /// SVGS - Savings - Conta de Poupança.
        /// TRAN - TransactingAccount - Conta de Pagamento pré-paga.
        /// </summary>
        [Required]
        public EnumAccountPaymentsType AccountType { get; set; }
    }
}
