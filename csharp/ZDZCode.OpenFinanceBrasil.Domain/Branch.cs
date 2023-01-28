using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Branch
    {
        /// <summary>
        /// Dados de identificação na dependência.
        /// </summary>
        [Required]
        public BranchIdentification Identification { get; set; }

        /// <summary>
        /// Endereço na dependência.
        /// </summary>
        [Required]
        public BranchPostalAddress PostalAddress { get; set; }

        /// <summary>
        /// Dias e horários de funcionamento na dependência.
        /// </summary>
        [Required]
        public BranchAvailability Availability { get; set; }

        /// <summary>
        /// Lista de telefones da Dependência.
        /// </summary>
        [Required]
        public List<BranchPhone> Phones { get; set; }

        /// <summary>
        /// Traz a relação de serviços disponbilizados pelo Canal de Atendimento.
        /// </summary>
        [Required]
        public List<BranchService> Services { get; set; }
    }
}
