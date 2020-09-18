using System;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MMSdb.Models
{
    [Table("clsCase")]
    public class clsCase
    {
        [Key]

        public long case_ID { get; set; }
        public int usr_ID { get; set; }
        public int sts_id { get; set; }
        public int fac_id { get; set; }
        public DateTime case_date { get; set; }
        public bool case_Reminder { get; set; }
        public DateTime case_ReminderDate { get; set; }
        public bool case_Elgible { get; set; }
        public char case_type { get; set; }
        public DateTime case_StatusDate { get; set; }
        public bool case_FirstInitial { get; set; }
        public bool case_SSIOnly { get; set; }
        public bool case_Concurrent { get; set; }
        public bool case_ByAge { get; set; }
        public bool case_Medicare { get; set; }
        public bool case_Medicaid { get; set; }
        public bool case_EmergencyMedicaid { get; set; }
        public bool case_SSDI { get; set; }
        public bool case_Consultation { get; set; }
        public bool case_MedicallyNeedy { get; set; }
        public bool case_DDD { get; set; }
        public bool case_Phostomous { get; set; }
        public bool case_Appeal { get; set; }
        public DateTime case_AppealDate { get; set; }
        public string case_AppealDeadline { get; set; }
        public bool case_Hearing { get; set; }
        public DateTime case_HearingDate { get; set; }
        public string case_HearingDeadline { get; set; }
        public string case_Referral { get; set; }
        public string case_DCFOnlineAccessNo { get; set; }
        public DateTime case_DCFOnlineAccessDate { get; set; }
        public bool case_case_DCF_PR_MedRecords { get; set; }
        public bool case_DCF_PR_IncomeEveryone { get; set; }
        public bool case_DCF_PR_IncomeClient { get; set; }
        public bool case_DCF_PR_PatientID { get; set; }
        public bool case_DCF_PR_ImmigrationDocs { get; set; }
        public bool case_DCF_PR_EMAForm { get; set; }
        public bool case_DCF_PR_2514Form { get; set; }
        public bool case_DCF_PR_2613Form { get; set; }
        public bool case_DCF_PR_FinancialRelease { get; set; }
        public bool case_DCF_PR_CarStatement { get; set; }
        public bool case_DCF_PR_ChildSuppProof { get; set; }
        public bool case_DCF_PR_LongTermCareInfo { get; set; }
        public bool case_Disability_TaxThisYear { get; set; }
        public bool case_Disability_TaxLastYear { get; set; }
        public bool case_Disability_PictureID { get; set; }
        public bool case_Disability_SSNCard { get; set; }
        public bool case_Disability_BirthCert { get; set; }
        public bool case_Disability_UtilitiesExp { get; set; }
        public bool case_Disability_MortgageReceipt { get; set; }
        public bool case_Disability_PropertyTaxes { get; set; }
        public bool case_Disability_HomeIns { get; set; }
        public bool case_Disability_Association { get; set; }
        public bool case_Disability_DivorceCert { get; set; }
        public bool case_Disability_MarriageCert { get; set; }
        public bool case_Disability_RentLtr { get; set; }
        public bool case_Disability_MedRecs { get; set; }
        public bool case_Disability_MentalEval { get; set; }
        public bool case_Disability_FoodStamps { get; set; }
        public bool case_Disability_ChildSupp { get; set; }
    }
}