using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class TermsAndConditionsItem //propriedades vazias, mas possui código do lado. Confirmar com o Zids.
    {
        public string SusepProcessNumber { get; set; }
        public string Detail { get; set; }
    }
}
