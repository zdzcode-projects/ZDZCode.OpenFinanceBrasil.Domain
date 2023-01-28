using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class NationalityOther
    {
        /// <summary>
        /// Campo de preenchimento obrigatório caso o cliente não possua nacionalidade brasileira. Preencher indicando todas suas demais nacionalidades utilizando o código de pais de acordo com o código “alpha3” do ISO-3166.p.ex.'CAN'
        /// </summary>
        public string OtherNationalitiesInfo { get; set; }

        /// <summary>
        /// Lista que traz relação de documentos complementares de pessoas com nacionalidade diferente de brasileira.
        /// </summary>
        public List<NationalityOtherDocument> Documents { get; set; }
    }
}
