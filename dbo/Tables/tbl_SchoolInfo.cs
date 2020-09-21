using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_SchoolInfo")]
    public class tbl_SchoolInfo
    {
        [Key]
        public long sch_ID { get; set; }
        public long dmg_ID { get; set; }
        public String? sch_ParentMakingPmt { get; set; }
        public String? sch_SchoolName { get; set; }
        public String? sch_Address { get; set; }
        public String? sch_City { get; set; }
        public String? sch_State { get; set; }
        public String? sch_Zip { get; set; }
        public String? sch_Phone { get; set; }
        public String? sch_Grade { get; set; }
        public String? sch_Teacher { get; set; }
        public String? sch_MotherName { get; set; }
        public String? sch_MotherDOB { get; set; }
        public String? sch_MotherSSN { get; set; }
        public Boolean? sch_MotherUnemployment { get; set; }
        public Double? sch_MotherUnpAmt { get; set; }
        public DateTime? sch_MotherUnpStartDate { get; set; }
        public DateTime? sch_MotherUnpEndDate { get; set; }
        public Boolean? sch_MotherEmployed { get; set; }
        public String? sch_MotherEmployername { get; set; }
        public String? sch_MotherEmployerAddress { get; set; }
        public String? sch_MotherEmployerCity { get; set; }
        public String? sch_MotherEmployerState { get; set; }
        public String? sch_MotherEmployerZip { get; set; }
        public DateTime? sch_MotherEmploymentStartDate { get; set; }
        public DateTime? sch_MotherEmploymentEndDate { get; set; }
        public DateTime? sch_MotherDateLastPaid { get; set; }
        public Double? sch_MotherSalary { get; set; }
        public String? sch_MotherSalaryRate { get; set; }
        public Boolean? sch_MotherMedicaid { get; set; }
        public String? sch_MotherHealthIns { get; set; }
        public String? sch_MotherPolicy { get; set; }
        public String? sch_FatherName { get; set; }
        public String? sch_FatherDOB { get; set; }
        public String? sch_FatherSSN { get; set; }
        public Boolean? sch_FatherUnemployment { get; set; }
        public Double? sch_FatherUnpAmt { get; set; }
        public DateTime? sch_FatherUnpStartDate { get; set; }
        public DateTime? sch_FatherUnpEndDate { get; set; }
        public Boolean? sch_FatherEmployed { get; set; }
        public String? sch_FatherEmployername { get; set; }
        public String? sch_FatherEmployerAddress { get; set; }
        public String? sch_FatherEmployerCity { get; set; }
        public String? sch_FatherEmployerState { get; set; }
        public String? sch_FatherEmployerZip { get; set; }
        public DateTime? sch_FatherEmploymentStartDate { get; set; }
        public DateTime? sch_FatherEmploymentEndDate { get; set; }
        public DateTime? sch_FatherDateLastPaid { get; set; }
        public Double? sch_FatherSalary { get; set; }
        public String? sch_FatherSalaryRate { get; set; }
        public String? sch_FatherMedicaid { get; set; }
        public String? sch_FatherHealthIns { get; set; }
        public String? sch_FatherPolicy { get; set; }
        public Boolean? sch_ParentsLivingTogether { get; set; }
        public Boolean? sch_ParentsMarried { get; set; }
        public DateTime? sch_SeparatedDate { get; set; }
        public DateTime? sch_DivorcedDate { get; set; }
        public Boolean? deleted { get; set; }
    }
}
