using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Status")]
    public class tbl_Status
    {
        [Key]

        public long sts_ID { get; set; }
        public String? sts_Description { get; set; }
    }
}
