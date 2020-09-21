using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Cases")]
    public class tbl_Cases
    {
        [Key]
        public long case_ID { get; set; }
        public int usr_ID { get; set; }
        public int? sts_id { get; set; }
        public int? fac_id { get; set; }
        public DateTime case_date { get; set; }
        public Boolean? case_Reminder { get; set; }
        public DateTime? case_ReminderDate { get; set; }
        public Boolean? case_Elgible { get; set; }
        [MaxLength(1), Column(TypeName = "varchar")]
        public String case_type { get; set; }
        public DateTime? case_StatusDate { get; set; }
        public Boolean? case_FirstInitial { get; set; }
        public Boolean? case_SSIOnly { get; set; }
        public Boolean? case_Concurrent { get; set; }
        public Boolean? case_ByAge { get; set; }
        public Boolean? case_Medicare { get; set; }
        public Boolean? case_Medicaid { get; set; }
        public Boolean? case_EmergencyMedicaid { get; set; }
        public Boolean? case_SSDI { get; set; }
        public Boolean? case_Consultation { get; set; }
        public Boolean? case_MedicallyNeedy { get; set; }
        public Boolean? case_DDD { get; set; }
        public Boolean? case_Phostomous { get; set; }
        public Boolean? case_Appeal { get; set; }
        public DateTime? case_AppealDate { get; set; }
        public String? case_AppealDeadline { get; set; }
        public Boolean? case_Hearing { get; set; }
        public DateTime? case_HearingDate { get; set; }
        public String? case_HearingDeadline { get; set; }
        public String? case_Referral { get; set; }
        public String? case_DCFOnlineAccessNo { get; set; }
        public DateTime? case_DCFOnlineAccessDate { get; set; }
        public Boolean? case_DCF_PR_MedRecords { get; set; }
        public Boolean? case_DCF_PR_IncomeEveryone { get; set; }
        public Boolean? case_DCF_PR_IncomeClient { get; set; }
        public Boolean? case_DCF_PR_PatientID { get; set; }
        public Boolean? case_DCF_PR_ImmigrationDocs { get; set; }
        public Boolean? case_DCF_PR_EMAForm { get; set; }
        public Boolean? case_DCF_PR_2514Form { get; set; }
        public Boolean? case_DCF_PR_2613Form { get; set; }
        public Boolean? case_DCF_PR_FinancialRelease { get; set; }
        public Boolean? case_DCF_PR_CarStatement { get; set; }
        public Boolean? case_DCF_PR_ChildSuppProof { get; set; }
        public Boolean? case_DCF_PR_LongTermCareInfo { get; set; }
        public Boolean? case_Disability_TaxThisYear { get; set; }
        public Boolean? case_Disability_TaxLastYear { get; set; }
        public Boolean? case_Disability_PictureID { get; set; }
        public Boolean? case_Disability_SSNCard { get; set; }
        public Boolean? case_Disability_BirthCert { get; set; }
        public Boolean? case_Disability_UtilitiesExp { get; set; }
        public Boolean? case_Disability_MortgageReceipt { get; set; }
        public Boolean? case_Disability_PropertyTaxes { get; set; }
        public Boolean? case_Disability_HomeIns { get; set; }
        public Boolean? case_Disability_Association { get; set; }
        public Boolean? case_Disability_DivorceCert { get; set; }
        public Boolean? case_Disability_MarriageCert { get; set; }
        public Boolean? case_Disability_RentLtr { get; set; }
        public Boolean? case_Disability_MedRecs { get; set; }
        public Boolean? case_Disability_MentalEval { get; set; }
        public Boolean? case_Disability_FoodStamps { get; set; }
        public Boolean? case_Disability_ChildSuppLtr { get; set; }
        public Boolean? deleted { get; set; }
    }
}
