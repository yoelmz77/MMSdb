using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_ConsultationPmts")]
    public class tbl_ConsultationPmts
    {
        [Key]
        public long cpmt_ID { get; set; }
        public long cnl_ID { get; set; }
        public DateTime? cpmt_Date { get; set; }
        public String? cpmt_Type { get; set; }
        public String? cpmt_Info { get; set; }
        public Double? cpmt_Amount { get; set; }
        public Double? cpmt_WriteOff { get; set; }
        public Boolean? deleted { get; set; }
    }
}
