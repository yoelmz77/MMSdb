using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_ClinicalConditions")]
    public class tbl_ClinicalConditions
    {
        [Key]
        public long clc_ID { get; set; }
        public long dmg_ID { get; set; }
        public Boolean? clc_Cancer { get; set; }
        public Boolean? clc_Metastasi { get; set; }
        public DateTime? clc_OnsetDate { get; set; }
        public String? clc_Condition { get; set; }
        public Boolean? clc_MentalEval { get; set; }
        public String? clc_MentalEvalGiven { get; set; }
        public String? clc_MentalEvalReturned { get; set; }
        public String? clc_Diagnosis { get; set; }
        public Boolean? deleted { get; set; }
    }
}
