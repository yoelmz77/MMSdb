using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Householdresidents")]
    public class tbl_Householdresidents
    {
        [Key]
        public long hour_ID { get; set; }
        public long hou_ID { get; set; }
        public String? hour_Name { get; set; }
        public String? hour_Relationship { get; set; }
        public DateTime? hour_DOB { get; set; }
        public Boolean? hour_Disabled { get; set; }
        public Boolean? hour_Married { get; set; }
        public Boolean? hour_Student { get; set; }
        public Boolean? hour_Minor { get; set; }
        public Boolean? deleted { get; set; }
    }
}
