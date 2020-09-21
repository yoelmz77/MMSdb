using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Membersof")]
    public class tbl_Membersof
    {
        [Key]
        [Column(Order = 1)]
        public long grp_ID { get; set; }
        [Key]
        [Column(Order = 2)]
        public long usr_ID { get; set; }
    }
}
