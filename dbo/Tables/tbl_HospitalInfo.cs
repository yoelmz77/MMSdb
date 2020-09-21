using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_HospitalInfo")]
    public class tbl_HospitalInfo
    {
        [Key]
        public long hosp_ID { get; set; }
        public long dmg_ID { get; set; }
        public long? hosp_FacilityID { get; set; }
        public int? hosp_StatusID { get; set; }
        public String? hosp_ChartNo { get; set; }
        public String? hosp_Admission { get; set; }
        public String? hosp_Discharge { get; set; }
        public String? hosp_Reason { get; set; }
        public String? hosp_Notes { get; set; }
        public String? hosp_Recipients { get; set; }
        public Double? hosp_AnticipatedRecovery { get; set; }
        public String? hosp_Referred { get; set; }
        public Double? hosp_Balance { get; set; }
        public String? hosp_Account { get; set; }
        public DateTime? hosp_ApplyDate { get; set; }
        public String? hosp_CaseType { get; set; }
        public DateTime? hosp_DateInvoiced { get; set; }
        public DateTime? hosp_DateMMSPaid { get; set; }
        public DateTime? hosp_StatusDate { get; set; }
        public Double? hosp_MMSAntRecv { get; set; }
        public String? hosp_StatusList { get; set; }
        public String? hosp_Name { get; set; }
        public Boolean? deleted { get; set; }
    }
}
