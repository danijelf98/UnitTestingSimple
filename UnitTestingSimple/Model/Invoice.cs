using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSimple.Model
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string ClientName { get; set; }
        public string ClientLastName { get; set; }
    }
}
