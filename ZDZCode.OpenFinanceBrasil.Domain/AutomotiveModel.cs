using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AutomotiveModel
    {
        /// <summary>
        /// Chamada via código FIPE – retorna os veículos (Modelo) que são cobertos no produto
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Chamada via código FIPE – retorna os veículos (Ano) que são cobertos no produto
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Chamada via código FIPE – retorna os veículos (Marca) que são cobertos no produto
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Chamada via código FIPE – retorna os veículos (código fipe) que são cobertos no produto
        /// </summary>
        public string FipeCode { get; set; }
    }
}
