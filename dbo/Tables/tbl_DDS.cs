using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_DDS")]
    public class tbl_DDS
    {
        [Key]
        public long dds_ID { get; set; }
        public long dmg_ID { get; set; }
        public String? dds_AdjudicatorName { get; set; }
        public String? dds_AdjudicatorPhone { get; set; }
        public String? dds_AdjudicatorPhoneExt { get; set; }
        public String? dds_Address { get; set; }
        public Boolean? dds_WorkHistory { get; set; }
        public DateTime? dds_WorkHistoryDate { get; set; }
        public Boolean? dds_ADL { get; set; }
        public DateTime? dds_ADLDate { get; set; }
        public Boolean? dds_ThirdPartyADL { get; set; }
        public DateTime? dds_ThirdPartyADLDate { get; set; }
        public Boolean? dds_ContactList { get; set; }
        public DateTime? dds_ContactListDate { get; set; }
        public Boolean? dds_Physician { get; set; }
        public DateTime? dds_PhysicianDate { get; set; }
        public Boolean? dds_PainQuestionaire { get; set; }
        public DateTime? dds_PainQuestionaireDate { get; set; }
        public Boolean? dds_Anxiety { get; set; }
        public DateTime? dds_AnxietyDate { get; set; }
        public Boolean? dds_PanicAttack { get; set; }
        public DateTime? dds_PanicAttackDate { get; set; }
        public Boolean? dds_Cardiac { get; set; }
        public DateTime? dds_CardiacDate { get; set; }
        public Boolean? dds_Neuropathy { get; set; }
        public DateTime? dds_NeuropathyDate { get; set; }
        public Boolean? dds_NeuropathyRpt { get; set; }
        public DateTime? dds_NeuropathyRptDate { get; set; }
        public Boolean? dds_IQ { get; set; }
        public DateTime? dds_IQDate { get; set; }
        public Boolean? dds_Eye { get; set; }
        public DateTime? dds_EyeDate { get; set; }
        public Boolean? dds_Teacher { get; set; }
        public DateTime? dds_TeacherDate { get; set; }
        public Boolean? dds_SSA3820 { get; set; }
        public DateTime? dds_SSA3820Date { get; set; }
        public Boolean? dds_ReportCard { get; set; }
        public DateTime? dds_ReportCardDate { get; set; }
        public Boolean? dds_SchoolWorksheet { get; set; }
        public DateTime? dds_SchoolWorksheetDate { get; set; }
        public Boolean? dds_Counselor { get; set; }
        public DateTime? dds_CounselorDate { get; set; }
        public String? dds_MedRecSentFrom { get; set; }
        public DateTime? dds_MedRecDate { get; set; }
        public DateTime? dds_OnsetDate { get; set; }
        public DateTime? dds_ApprovalDate { get; set; }
        public String? dds_Notes { get; set; }
        public DateTime? dds_ReleaseFormDueDate { get; set; }
        public DateTime? dds_SeizureRptDate { get; set; }
        public Boolean? dds_SeizureRpt { get; set; }
        public Boolean? dds_HeadacheRpt { get; set; }
        public DateTime? dds_HeadacheRptDate { get; set; }
        public Boolean? dds_MSRFCRpt { get; set; }
        public DateTime? dds_MSRFCRptDate { get; set; }
        public Boolean? deleted { get; set; }
    }
}
