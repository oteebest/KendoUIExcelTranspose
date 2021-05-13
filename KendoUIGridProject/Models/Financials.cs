using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIGridProject.Models
{
    public class Financials
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Year { get; set; }
        public decimal ? Sales { get; set; }
        public decimal ? Costs { get; set; }
        public decimal ? Profit { get; set; }
    }
}