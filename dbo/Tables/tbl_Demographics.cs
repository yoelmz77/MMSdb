using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Demographics")]
    public class tbl_Demographics
    {
        [Key]

        public long dmg_ID { get; set; }
        public long case_ID { get; set; }
        public Boolean? dmg_OtherNameOpt { get; set; }
        public String? dmg_OtherName { get; set; }
        public String? dmg_Race { get; set; }
        public String? dmg_LastSchoolGrade { get; set; }
        public String? dmg_LastSchoolYear { get; set; }
        public Boolean? dmg_PrefLangEn { get; set; }
        public Boolean? dmg_PrefLangSP { get; set; }
        public Boolean? dmg_PrefLangCR { get; set; }
        public String? dmg_PlaceBorn { get; set; }
        public Boolean? dmg_Homeless { get; set; }
        public String dmg_FirstName { get; set; }
        public String dmg_LastName { get; set; }
        public String? dmg_MiddleName { get; set; }
        public String? dmg_Address { get; set; }
        public String? dmg_Address2 { get; set; }
        public String? dmg_City { get; set; }
        public String? dmg_State { get; set; }
        public String? dmg_Zip { get; set; }
        public String? dmg_ResidentAddress { get; set; }
        public String? dmg_ResidentCity { get; set; }
        public String? dmg_ResidentState { get; set; }
        public String? dmg_ResidentZip { get; set; }
        public String? dmg_HomePhone { get; set; }
        public String? dmg_CellPhone { get; set; }
        public DateTime dmg_DOB { get; set; }
        public int? dmg_Age { get; set; }
        public String dmg_SSN { get; set; }
        public String? dmg_Height { get; set; }
        public Double? dmg_Weight { get; set; }
        public String? dmg_Gender { get; set; }
        public Boolean? deleted { get; set; }
    }
}
