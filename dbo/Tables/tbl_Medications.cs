using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Medications")]
    public class tbl_Medications
    {
        [Key]
        public long med_ID { get; set; }
        public long dmg_ID { get; set; }
        public String? med_Name { get; set; }
        public String? med_Dosage { get; set; }
        public String? med_PrescribingPhysician { get; set; }
        public String? med_Reason { get; set; }
        public String? med_SideEffect { get; set; }
        public Boolean? deleted { get; set; }

    }
}
