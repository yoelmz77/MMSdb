using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Insurance")]
    public class tbl_Insurance
    {
        [Key]
        public long ins_ID { get; set; }
        public long dmg_ID { get; set; }
        public Boolean? ins_Medicare { get; set; }
        public Boolean? ins_PartA { get; set; }
        public Boolean? ins_PartB { get; set; }
        public Boolean? ins_Medicaid { get; set; }
        public Boolean? ins_MedicaidSharedCost { get; set; }
        public Double? ins_MedicaidSharedCostAmt { get; set; }
        public String? ins_MedicaidIDNo { get; set; }
        public Boolean? ins_Life { get; set; }
        public String? ins_LifeName { get; set; }
        public String? ins_LifePolicyNo { get; set; }
        public Boolean? ins_HMO { get; set; }
        public String? ins_HMOName { get; set; }
        public String? ins_HMOPolicyNo { get; set; }
        public Boolean? ins_PPO { get; set; }
        public String? ins_PPOName { get; set; }
        public String? ins_PPOPolicyNo { get; set; }
        public Boolean? ins_MedicalPlan { get; set; }
        public String? ins_MedicalPlanName { get; set; }
        public String? ins_MedicalPlanPolicyNo { get; set; }
        public Boolean? ins_Obamacare { get; set; }
        public String? ins_ObamacarePlanName { get; set; }
        public String? ins_ObamacarePolicyNo { get; set; }
        public Boolean? deleted { get; set; }
    }
}
