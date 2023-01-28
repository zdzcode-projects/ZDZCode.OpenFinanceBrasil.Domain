using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{   /// <summary>
    /// Usuário (pessoa natural) que encontra-se logado na instituição receptora e que iniciará o processo de consentimento para compartilhamento de dados.
    /// </summary>
    public class LoggedUser
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public Document Document { get; set; }
    }
}
