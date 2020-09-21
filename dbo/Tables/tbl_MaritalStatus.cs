using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_MaritalStatus")]
    public class tbl_MaritalStatus
    {
        [Key]
        public long mrs_ID { get; set; }
        public long dmg_ID { get; set; }
        public Boolean? mrs_Married { get; set; }
        public String? mrs_SpouseName { get; set; }
        public String? mrs_SpouseDOB { get; set; }
        public int? mrs_SpouseAge { get; set; }
        public String? mrs_SpouseSSN { get; set; }
        public String? mrs_MarriagePlace { get; set; }
        public Boolean? mrs_Proof { get; set; }
        public int? mrs_Status { get; set; }
        public DateTime? mrs_StatusDate { get; set; }
        public Double? mrs_SpouseWages { get; set; }
        public String? mrs_SpouseWageType { get; set; }
        public Boolean? mrs_SpouseEmployed { get; set; }
        public String? mrs_SpouseEmployer { get; set; }
        public String? mrs_SpouseEmployerAddress { get; set; }
        public String? mrs_SpouseEmployerCity { get; set; }
        public String? mrs_SpouseEmployerState { get; set; }
        public String? mrs_SpouseEmployerZip { get; set; }
        public String? mrs_SpouseEmployerPhone { get; set; }
        public String? mrs_Notes { get; set; }
        public String? mrs_SpouseUnpStart { get; set; }
        public String? mrs_SpouseUnpEnd { get; set; }
        public Double? mrs_SpouseUnpAmt { get; set; }
        public String? mrs_SpouseDisabilityStart { get; set; }
        public String? mrs_SpouseDisabilityEnd { get; set; }
        public Double? mrs_SpouseDisabilityAmt { get; set; }
        public Boolean? deleted { get; set; }
    }
}
