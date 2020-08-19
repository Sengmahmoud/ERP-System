using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class AccAccount
    {
        public int AccountId { get; set; }
        public string AcNameAr { get; set; }
        public string AcNameEn { get; set; }
        public int? ParentActId { get; set; }
        public bool? AcType { get; set; }
        public string Notes { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowChild { get; set; }
        public bool? CostCenter { get; set; }
        public string OldName { get; set; }
        public string AcNumber { get; set; }
        public int Level { get; set; }
        public decimal Budget { get; set; }
        public int AccSecurityLevel { get; set; }
    }
}
