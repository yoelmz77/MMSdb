using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Comments")]
    public class tbl_Comments
    {
        [Key]
        public long cmt_ID { get; set; }
        public long dmg_ID { get; set; }
        public DateTime? cmt_Date { get; set; }
        public String? cmt_Notes { get; set; }
        public Boolean? deleted { get; set; }
    }
}
