using System;
using System.Collections.Generic;

#nullable disable

namespace SNADHRMS.Repository.Models
{
    public partial class Mgmtexpense
    {
        public int Employeeid { get; set; }
        public string Entity { get; set; }
        public string Expensecode { get; set; }
        public DateTime Expensedate { get; set; }
        public decimal Amount { get; set; }
        public int Approvedby { get; set; }
        public DateTime Approvaldate { get; set; }
        public string Modeofpayment { get; set; }
        public DateTime Paymentdate { get; set; }
        public DateTime Creationdate { get; set; }
        public int Createdby { get; set; }
        public int Id { get; set; }
        public int Clientcode { get; set; }
        public string Employeename { get; set; }
        public decimal Totalmgmtexpenses { get; set; }

        public virtual Employeedatum ApprovedbyNavigation { get; set; }
        public virtual Employeedatum CreatedbyNavigation { get; set; }
    }
}
