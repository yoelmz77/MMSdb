using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_DCF")]
    public class tbl_DCF
    {
        [Key]
        public long dcf_ID { get; set; }
        public long dmg_ID { get; set; }
        public Boolean? dcf_EmaForm { get; set; }
        public Boolean? dcf_BillTracking { get; set; }
        public Boolean? dcf_Medicaid { get; set; }
        public Boolean? dcf_MedicallyNeeded { get; set; }
        public Boolean? dcf_QMB { get; set; }
        public Boolean? dcf_SLMB { get; set; }
        public Boolean? dcf_MedicareSecondary { get; set; }
        public Boolean? dcf_Posthumous { get; set; }
        public Boolean? dcf_MedicalRecords { get; set; }
        public Boolean? dcf_IncomeforEveryone { get; set; }
        public Boolean? dcf_IncomeforClient { get; set; }
        public Boolean? dcf_IDforPatient { get; set; }
        public Boolean? dcf_ImmigrationDocs { get; set; }
        public Boolean? dcf_2514Form { get; set; }
        public Boolean? dcf_2613Form { get; set; }
        public Boolean? dcf_FinancialRelease { get; set; }
        public Boolean? dcf_CarStatement { get; set; }
        public Boolean? dcf_ChildSupportProof { get; set; }
        public Boolean? dcf_LongTermCareInfo { get; set; }
        public String? dcf_OnlineAccessNo { get; set; }
        public DateTime? dcf_OnlineAccessDate { get; set; }
        public String? dcf_CaseNo { get; set; }
        public DateTime? dcf_DateOfMedicaidApplication { get; set; }
        public String? dcf_PinNo { get; set; }
        public String? dcf_CaseWorkerName { get; set; }
        public String? dcf_CaseWorkerPhone { get; set; }
        public DateTime? dcf_DateApplicationDenial { get; set; }
        public DateTime? dcf_DateApplicationreSubmitted { get; set; }
        public String? dcf_Notes { get; set; }
        public String? dcf_SOC { get; set; }
        public String? dcf_FSValue { get; set; }
        public Boolean? dcf_FS { get; set; }
        public Boolean? dcf_2039Form { get; set; }
        public Boolean? dcf_IBForm { get; set; }
        public Boolean? dcf_DisabilityReport { get; set; }
        public Boolean? dcf_Passport { get; set; }
        public Boolean? dcf_PayStubs { get; set; }
        public Boolean? dcf_SocialSecurityCard { get; set; }
        public Boolean? dcf_BankStatement { get; set; }
        public Boolean? dcf_HouseExpenses { get; set; }
        public Boolean? deleted { get; set; }
    }
}
