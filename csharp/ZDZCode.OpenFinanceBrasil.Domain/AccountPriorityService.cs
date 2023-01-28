using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
   public class AccountPriorityService
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Customers
        {
            public string rate { get; set; }
        }

        public class Maximum
        {
            public string value { get; set; }
            public string currency { get; set; }
        }

        public class Minimum
        {
            public string value { get; set; }
            public string currency { get; set; }
        }

        public class Price
        {
            public string interval { get; set; }
            public string value { get; set; }
            public string currency { get; set; }
            public Customers customers { get; set; }
        }

        public class Root
        {
            public string name { get; set; }
            public string code { get; set; }
            public string chargingTriggerInfo { get; set; }
            public List<Price> prices { get; set; }
            public Minimum minimum { get; set; }
            public Maximum maximum { get; set; }
        }

    }
}
