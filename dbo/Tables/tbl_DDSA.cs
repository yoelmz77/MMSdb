using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_DDSA")]
    public class tbl_DDSA
    {
        [Key]
        public long ddsa_ID { get; set; }
        public long dmg_ID { get; set; }
        public String? ddsa_AdjudicatorName { get; set; }
        public String? ddsa_AdjudicatorPhone { get; set; }
        public String? ddsa_AdjudicatorPhoneExt { get; set; }
        public String? ddsa_Address { get; set; }
        public Boolean? ddsa_WorkHistory { get; set; }
        public DateTime? ddsa_WorkHistoryDate { get; set; }
        public Boolean? ddsa_ADL { get; set; }
        public DateTime? ddsa_ADLDate { get; set; }
        public Boolean? ddsa_ThirdPartyADL { get; set; }
        public DateTime? ddsa_ThirdPartyADLDate { get; set; }
        public Boolean? ddsa_ContactList { get; set; }
        public DateTime? ddsa_ContactListDate { get; set; }
        public Boolean? ddsa_Physician { get; set; }
        public DateTime? ddsa_PhysicianDate { get; set; }
        public Boolean? ddsa_PainQuestionaire { get; set; }
        public DateTime? ddsa_PainQuestionaireDate { get; set; }
        public Boolean? ddsa_Anxiety { get; set; }
        public DateTime? ddsa_AnxietyDate { get; set; }
        public Boolean? ddsa_PanicAttack { get; set; }
        public DateTime? ddsa_PanicAttackDate { get; set; }
        public Boolean? ddsa_Cardiac { get; set; }
        public DateTime? ddsa_CardiacDate { get; set; }
        public Boolean? ddsa_Neuropathy { get; set; }
        public DateTime? ddsa_NeuropathyDate { get; set; }
        public Boolean? ddsa_NeuropathyRpt { get; set; }
        public DateTime? ddsa_NeuropathyRptDate { get; set; }
        public Boolean? ddsa_IQ { get; set; }
        public DateTime? ddsa_IQDate { get; set; }
        public Boolean? ddsa_Eye { get; set; }
        public DateTime? ddsa_EyeDate { get; set; }
        public Boolean? ddsa_Teacher { get; set; }
        public DateTime? ddsa_TeacherDate { get; set; }
        public Boolean? ddsa_SSA3820 { get; set; }
        public DateTime? ddsa_SSA3820Date { get; set; }
        public Boolean? ddsa_ReportCard { get; set; }
        public DateTime? ddsa_ReportCardDate { get; set; }
        public Boolean? ddsa_SchoolWorksheet { get; set; }
        public DateTime? ddsa_SchoolWorksheetDate { get; set; }
        public Boolean? ddsa_Counselor { get; set; }
        public DateTime? ddsa_CounselorDate { get; set; }
        public String? ddsa_MedRecSentFrom { get; set; }
        public DateTime? ddsa_MedRecDate { get; set; }
        public DateTime? ddsa_OnsetDate { get; set; }
        public DateTime? ddsa_ApprovalDate { get; set; }
        public String? ddsa_Notes { get; set; }
        public DateTime? ddsa_ReleaseFormDueDate { get; set; }
        public DateTime? ddsa_SeizureRptDate { get; set; }
        public Boolean? ddsa_SeizureRpt { get; set; }
        public Boolean? ddsa_HeadacheRpt { get; set; }
        public DateTime? ddsa_HeadacheRptDate { get; set; }
        public Boolean? ddsa_MSRFCRpt { get; set; }
        public DateTime? ddsa_MSRFCRptDate { get; set; }
        public Boolean? deleted { get; set; }
    }
}
