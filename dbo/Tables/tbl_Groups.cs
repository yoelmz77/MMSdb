using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Groups")]
    public class tbl_Groups
    {
        [Key]
        public long grp_ID { get; set; }
        public String? grp_Name { get; set; }
        public DateTime? grp_Created { get; set; }
        public DateTime? grp_Modified { get; set; }
        public Boolean? deleted { get; set; }
    }
}
