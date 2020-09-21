using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Users")]
    public class tbl_Users
    {
        [Key]

        public long usr_ID { get; set; }
        public String? usr_LoginName { get; set; }
        public String? usr_Password { get; set; }
        public String? usr_FullName { get; set; }
        public Boolean? usr_Active { get; set; }
        public DateTime? usr_Created { get; set; }
        public DateTime? usr_Modified { get; set; }
        public Boolean? deleted { get; set; }

    }
}
