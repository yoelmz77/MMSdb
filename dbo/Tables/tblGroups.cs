using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Groups")]
    public class tblGroups
    {
        [Key]
        public long grp_ID { get; set; }
        public string grp_Name { get; set; }
        public DateTime grp_Created { get; set; }
        public DateTime grp_Modified { get; set; }
    }
}
