using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Appointments")]
    public class tbl_Appointments
    {
        [Key]

        public long app_ID { get; set; }
        public long case_ID { get; set; }
        public long usr_ID { get; set; }
        public String? app_Subject { get; set; }
        public String? app_Location { get; set; }
        public DateTime? app_StartDate { get; set; }
        public DateTime? app_StartTime { get; set; }
        public DateTime? app_EndDate { get; set; }
        public DateTime? app_EndTime { get; set; }
        public String? app_Body { get; set; }
        public Boolean? deleted { get; set; }
    }
}
