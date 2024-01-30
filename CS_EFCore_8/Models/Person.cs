using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EFCore_8.Models
{

    public class Address
    {
        public required string FlatOrBungloNo { get; set; }
        public required string Street { get; init; }
        public required string City { get; init; }
        public required string PinCode { get; init; }
    }
    [Table("Person")]
    public class Person
    {
        public int PersonId { get; set; }
        public required string PersonName { get; set; }
        public required Address Address { get; set; }
    }
}
