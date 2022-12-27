using System;
using System.Collections.Generic;

#nullable disable

namespace SNADHRMS.Repository.Models
{
    public partial class Expense
    {
        public Expense()
        {
            Empexpenses = new HashSet<Empexpense>();
            Imgexpenses = new HashSet<Imgexpense>();
        }

        public string Expensecode { get; set; }
        public string Expenses { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Empexpense> Empexpenses { get; set; }
        public virtual ICollection<Imgexpense> Imgexpenses { get; set; }
    }
}
