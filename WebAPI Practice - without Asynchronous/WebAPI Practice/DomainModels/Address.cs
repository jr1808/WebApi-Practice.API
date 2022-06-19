using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Practice.DomainModels
{
    public class Address
    {
        public Guid ID { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
        // Navigation Property
        public Guid StudentID { get; set; }
    }
}
