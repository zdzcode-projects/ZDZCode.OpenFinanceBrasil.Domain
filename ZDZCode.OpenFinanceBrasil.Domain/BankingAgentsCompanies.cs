using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgentsCompanies
    {
        /// <summary>
        /// Nome da Instituição, pertencente à marca, responsável pelo Correspondente Bancário no país. p.ex.'Empresa da Organização A'
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Número completo do CNPJ da instituição responsável pelo Correspondente Bancário no país - o CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara.
        /// </summary>
        [Required]
        public string CnpjNumber { get; set; }

        /// <summary>
        /// Relação de informações de um contratante do serviço de correspondente.
        /// </summary>
        [Required]
        public List<BankingAgentsContractor> Contractors { get; set; }
    }
}
