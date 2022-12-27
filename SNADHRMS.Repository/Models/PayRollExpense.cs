using System;
using System.Collections.Generic;

#nullable disable

namespace SNADHRMS.Repository.Models
{
    public partial class PayRollExpense
    {
        public int Employeeid { get; set; }
        public string Employeename { get; set; }
        public decimal Totalpayrollexpenses { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public int Noofhours { get; set; }
        public int Payrate { get; set; }
        public int Grosspay { get; set; }
        public int Payrollexpense1 { get; set; }
        public int Insurancebycompany { get; set; }
        public string Payperiodstartdate { get; set; }
        public string Payperiodenddate { get; set; }
        public string Paymentdate { get; set; }
        public string Creationdate { get; set; }
        public string Updateddate { get; set; }
        public int Id { get; set; }

        public virtual Employeedatum CreatedbyNavigation { get; set; }
        public virtual Employeedatum UpdatedbyNavigation { get; set; }
    }
}
