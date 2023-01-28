using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Objeto que reúne as informações relativas ao relacionamento do cliente junto à Instituição. Considera-se relacionamento as informações que permitam conhecer desde quando a pessoa consultada é cliente da instituição, bem como um indicador dos produtos e serviços que ela consome atualmente e seus representantes
    /// </summary>
    public class PersonalFinancialRelationData
    {
        /// <summary>
        /// Data e hora da atualização do bloco de Relacionamento, conforme especificação RFC-3339, formato UTC.
        /// </summary>
        [Required]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Data de início de relacionamento com a Instituição Financeira. Deve trazer o menor valor entre a informação reportada ao BACEN pelo DOC 3040 e CCS.
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// [Lista com a relação dos produtos e serviços com contrato vigente.]
        /// </summary>
        [Required]
        public List<EnumProductServiceType> ProductsServicesType { get; set; }

        /// <summary>
        /// Informações adicionais do tipo de serviço. [Restrição] Campo obrigatório quando productsServicesType for 'OUTROS'.
        /// </summary>
        public string ProductsServicesTypeAdditionalInfo { get; set; }

        /// <summary>
        /// Lista dos representantes. De preenchimento obrigatório se houver representante.
        /// </summary>
        [Required]
        public List<PersonalProcurator> Procurators { get; set; }

        /// <summary>
        /// Lista de contas depósito à vista, poupança e pagamento pré-pagas mantidas pelo cliente na instituição transmissora.
        /// </summary>
        [Required]
        public List<Account> Accounts { get; set; }
    }
}
