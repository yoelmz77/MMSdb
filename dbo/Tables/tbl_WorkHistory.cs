using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_WorkHistory")]
    public class tbl_WorkHistory
    {
        [Key]
        public long wh_ID { get; set; }
        public long dmg_ID { get; set; }
        public Boolean? wh_Employed { get; set; }
        public Double? wh_Unemployment { get; set; }
        public DateTime? wh_UnemploymentStartDate { get; set; }
        public DateTime? wh_UnemploymentEndDate { get; set; }
        public DateTime? wh_DateLastworked { get; set; }
        public Double? wh_TotalEarningsLastYear { get; set; }
        public Double? wh_TotalEarningsthisYear { get; set; }
        public int? wh_Type { get; set; }
        public Boolean? wh_SelfEmployed { get; set; }
        public Double? wh_SelfEmployedAmount { get; set; }
        public String? wh_Notes { get; set; }
        public Boolean? deleted { get; set; }
    }
}
