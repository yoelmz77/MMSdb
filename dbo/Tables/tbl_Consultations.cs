using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Consultations")]
    public class tbl_Consultations
    {
        [Key]
        public long cnl_ID { get; set; }
        public Double? cnl_Amount { get; set; }
        public Boolean? cnl_Charity { get; set; }
        public Boolean? cnl_AdminApproved { get; set; }
        public DateTime? cnl_Date { get; set; }
        public String? cnl_FirstName { get; set; }
        public String? cnl_LastName { get; set; }
        public String? cnl_MiddleName { get; set; }
        public String? cnl_Address1 { get; set; }
        public String? cnl_Address2 { get; set; }
        public String? cnl_City { get; set; }
        public String? cnl_State { get; set; }
        public String? cnl_Zip { get; set; }
        public String? cnl_ResidentAddress { get; set; }
        public String? cnl_ResidentCity { get; set; }
        public String? cnl_ResidentState { get; set; }
        public String? cnl_ResidentZip { get; set; }
        public String? cnl_Phone { get; set; }
        public String? cnl_Cell { get; set; }
        public DateTime? cnl_DOB { get; set; }
        public int? cnl_Age { get; set; }
        public String? cnl_SSN { get; set; }
        public String? cnl_Height { get; set; }
        public Double? cnl_Weight { get; set; }
        public String? cnl_Gender { get; set; }
        public Boolean? deleted { get; set; }
    }
}