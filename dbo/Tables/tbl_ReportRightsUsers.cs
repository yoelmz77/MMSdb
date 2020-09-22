using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_ReportRightsUsers")]
    public class tbl_ReportRightsUsers
    {
        [Key]
        [Column(Order = 1)]
        public long rpt_ID { get; set; }
        [Key]
        [Column(Order = 2)]
        public long usr_ID { get; set; }
        public Boolean rpt_CanAccess { get; set; }
    }
}
