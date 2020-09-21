using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Employment")]
    public class tbl_Employment
    {
        [Key]
        public long emp_ID { get; set; }
        public long wh_ID { get; set; }
        public String? emp_Employer { get; set; }
        public String? emp_BusinessType { get; set; }
        public String? emp_Address { get; set; }
        public String? emp_Began { get; set; }
        public String? emp_End { get; set; }
        public String? emp_Contact { get; set; }
        public String? emp_Phone { get; set; }
        public String? emp_Hours { get; set; }
        public String? emp_Days { get; set; }
        public String? emp_PayRate { get; set; }
        public Double? emp_MonthlyEarnings { get; set; }
        public String? emp_JobTitle { get; set; }
        public Boolean? deleted { get; set; }
    }
}
