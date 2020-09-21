using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Contacts")]
    public class tbl_Contacts
    {
        [Key]
        public long cnt_ID { get; set; }
        public long dmg_ID { get; set; }
        public String? cnt_Relationship { get; set; }
        public String? cnt_FName { get; set; }
        public String? cnt_LName { get; set; }
        public String? cnt_Address { get; set; }
        public String? cnt_City { get; set; }
        public String? cnt_State { get; set; }
        public String? cnt_Zip { get; set; }
        public String? cnt_Phone { get; set; }
        public Boolean? deleted { get; set; }
    }
}
