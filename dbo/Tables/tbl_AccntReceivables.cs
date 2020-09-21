using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_AccntReceivables")]
    public class tbl_AccntReceivables
    {
        [Key]
        public long recv_ID { get; set; }
        public long dmg_ID { get; set; }
        public Double? recv_SSIMonthlyAmt { get; set; }
        public Double? recv_SSIRetroAmt { get; set; }
        public Double? recv_SSIMMS25 { get; set; }
        public Double? recv_SSIMedicalConference { get; set; }
        public String? recv_SSIPhysician { get; set; }
        public Double? recv_SSICopyExpense { get; set; }
        public Double? recv_SSICertifiedMail { get; set; }
        public Double? recv_SSIRegStamps { get; set; }
        public Double? recv_SSITravel { get; set; }
        public Double? recv_SSIOfficeSupplies { get; set; }
        public Double? recv_SSIMedicaid { get; set; }
        public String? recv_SSIOther { get; set; }
        public Double? recv_SSIOtherAmt { get; set; }
        public Double? recv_SSDIMonthlyAmt { get; set; }
        public Double? recv_SSDIRetroAmt { get; set; }
        public Double? recv_SSDIMMS25 { get; set; }
        public Double? recv_SSDIMedicalConference { get; set; }
        public String? recv_SSDIPhysician { get; set; }
        public Double? recv_SSDICopyExpense { get; set; }
        public Double? recv_SSDICertifiedMail { get; set; }
        public Double? recv_SSDIRegStamps { get; set; }
        public Double? recv_SSDITravel { get; set; }
        public Double? recv_SSDIOfficeSupplies { get; set; }
        public Double? recv_SSDIMedicaid { get; set; }
        public String? recv_SSDIOther { get; set; }
        public Double? recv_SSDIOtherAmt { get; set; }
        public Boolean? deleted { get; set; }
    }
}
