using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_SocialSecurity")]
    public class tbl_SocialSecurity
    {
        [Key]
        public long ss_ID { get; set; }
        public long dmg_ID { get; set; }
        public String? ss_OnlineReentry { get; set; }
        public String? ss_AppealReentry { get; set; }
        public DateTime? ss_DateProcessOnlineReentry { get; set; }
        public String? ss_ApplicationNo { get; set; }
        public DateTime? ss_DateProcessApplication { get; set; }
        public String? ss_NameExaminer16 { get; set; }
        public String? ss_PhoneExaminer16 { get; set; }
        public String? ss_PhoneExtExaminer16 { get; set; }
        public String? ss_NameExaminer2 { get; set; }
        public String? ss_Phoneexaminer2 { get; set; }
        public String? ss_PhoneExtExaminer2 { get; set; }
        public DateTime? ss_PerkDate { get; set; }
        public DateTime? ss_SSAAppointmentDate { get; set; }
        public DateTime? ss_ApprovalDate { get; set; }
        public String? ss_Notes { get; set; }
        public String? ss_ClaimAddress { get; set; }
        public String? ss_ClaimCity { get; set; }
        public String? ss_ClaimState { get; set; }
        public String? ss_ClaimZip { get; set; }
        public String? ss_SSAPhone { get; set; }
        public Boolean? ss_FirstInitial { get; set; }
        public Boolean? ss_Appeal { get; set; }
        public Boolean? ss_Hearing { get; set; }
        public Boolean? ss_SSIClaim { get; set; }
        public Boolean? ss_SSDIClaim { get; set; }
        public Boolean? ss_Concurrent { get; set; }
        public Boolean? ss_ByAge { get; set; }
        public DateTime? ss_OnsetDate { get; set; }
        public Boolean? deleted { get; set; }
    }
}
