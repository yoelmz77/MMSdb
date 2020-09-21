using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Immigration")]
    public class tbl_Immigration
    {
        [Key]
        public long imm_ID { get; set; }
        public long dmg_ID { get; set; }
        public int? imm_Status { get; set; }
        public DateTime? imm_DateArrivedinUS { get; set; }
        public Boolean? imm_Proof { get; set; }
        public String? imm_AlienNo { get; set; }
        public DateTime? imm_ResidencyDate { get; set; }
        public String? imm_ResidentCategory { get; set; }
        public DateTime? imm_NaturalizationDate { get; set; }
        public String? imm_NaturalizationCert { get; set; }
        public DateTime? imm_CitizenshipDate { get; set; }
        public String? imm_Passport { get; set; }
        public Boolean? deleted { get; set; }
    }
}
