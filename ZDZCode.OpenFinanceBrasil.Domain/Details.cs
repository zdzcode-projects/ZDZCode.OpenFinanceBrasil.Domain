using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Details
    {
        /// <summary>
        /// Especifica a forma de iniciação do pagamento:
        /// - MANU - Inserção manual de dados da conta transacional
        /// - DICT - Inserção manual de chave Pix
        /// - QRDN - QR code dinâmico
        /// - QRES - QR code estático
        /// - INIC - Indica que o recebedor(creditor) contratou o Iniciador de Pagamentos especificamente para realizar iniciações de pagamento em que o beneficiário é previamente conhecido.
        /// </summary>
        [Required]
        public EnumLocalInstrument LocalInstrument { get; set; }

        /// <summary>
        /// Sequência de caracteres que corresponde ao QR Code disponibilizado para o pagador.
        /// É a sequência de caracteres que seria lida pelo leitor de QR Code, e deve propiciar o retorno dos dados do pagador após consulta na DICT.
        /// Essa funcionalidade é possível tanto para QR Code estático quanto para QR Code dinâmico.
        /// No arranjo do Pix esta é a mesma sequência gerada e/ou lida pela funcionalidade Pix Copia e Cola.
        /// Este campo deverá ser no formato UTF-8.
        /// [Restrição] Preenchimento obrigatório para pagamentos por QR Code, observado o tamanho máximo de 512 bytes.
        /// </summary>
        public string QrCode { get; set; }

        /// <summary>
        /// Chave cadastrada no DICT pertencente ao recebedor. Os tipos de chaves podem ser: telefone, e-mail, cpf/cnpj ou chave aleatória.
        /// No caso de telefone celular deve ser informado no padrão E.1641.
        /// Para e-mail deve ter o formato xxxxxxxx@xxxxxxx.xxx(.xx) e no máximo 77 caracteres.
        /// No caso de CPF deverá ser informado com 11 números, sem pontos ou traços.
        /// Para o caso de CNPJ deverá ser informado com 14 números, sem pontos ou traços.
        /// No caso de chave aleatória deve ser informado o UUID gerado pelo DICT, conforme formato especificado na RFC41223.
        /// Se informado, a detentora da conta deve validar o proxy no DICT quando localInstrument for igual a DICT, QRDN ou QRES e validar o campo creditorAccount.
        /// Esta validação é opcional caso o localInstrument for igual a INIC.
        /// [Restrição]
        /// Se localInstrument for igual a MANU, o campo proxy não deve ser preenchido.
        /// Se localInstrument for igual INIC, DICT, QRDN ou QRES, o campo proxy deve ser sempre preenchido com a chave Pix.
        /// </summary>
        public string Proxy { get; set; }

        /// <summary>
        /// Objeto que contém a identificação da conta de destino do beneficiário/recebedor.
        /// </summary>
        [Required]
        public CreditorAccount CreditorAccount { get; set; }
    }
}
