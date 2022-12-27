using System;
using System.Collections.Generic;

#nullable disable

namespace SNADHRMS.Repository.Models
{
    public partial class Clientdatum
    {
        public int Clientcode { get; set; }
        public string Clientname { get; set; }
        public int? Taxfedral { get; set; }
        public string Clientlocation { get; set; }
        public DateTime? Agreementstartdate { get; set; }
        public string Serviceagreementonboarded { get; set; }
        public DateTime? Agreementendate { get; set; }
        public int Id { get; set; }
    }
}
