using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseAccountList
    {
        /// <summary>
        /// Lista de contas depósito à vista, poupança e pagamento pré-pagas mantidas pelo cliente na instituição transmissora e para as quais ele tenha fornecido consentimento
        /// </summary>
        [Required]
        public List<AccountData> Data { get; set; }

        /// <summary>
        /// Referências para outros recusos da API requisitada.
        /// </summary>
        [Required]
        public Links Links { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Required]
        public Meta Meta { get; set; }
    }
}
