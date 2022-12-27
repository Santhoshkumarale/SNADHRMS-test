using System;
using System.Collections.Generic;

#nullable disable

namespace SNADHRMS.Repository.Models
{
    public partial class EmpDatum
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal EmpSalary { get; set; }
        public byte[] Files { get; set; }
    }
}
