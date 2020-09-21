using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Reports")]
    public class tbl_Reports
    {
        [Key]
        public long rpt_ID { get; set; }
        public String? rpt_Name { get; set; }
        public String? rpt_Description { get; set; }
        public String? rpt_Path { get; set; }
        public Boolean? rpt_Enabled { get; set; }
        public Boolean? rpt_CanAccess { get; set; }
        public Boolean? deleted { get; set; }
    }
}
