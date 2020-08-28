using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
    public partial class AccAccount
    {
        [Display(Name ="رقم الحساب")]
        public int AccountId { get; set; }
        [Display(Name ="اسم العميل")]
        public string AcNameAr { get; set; }
        public string AcNameEn { get; set; }
        public int? ParentActId { get; set; }
        public bool? AcType { get; set; }
        [Display(Name ="الرصيد")]
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
