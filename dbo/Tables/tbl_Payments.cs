using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Payments")]
    public class tbl_Payments
    {
        [Key]
        public long pmt_ID { get; set; }
        public long? pmt_ReceivableID { get; set; }
        public int? pmt_Type { get; set; }
        public DateTime? pmt_Date { get; set; }
        public Boolean? pmt_PaidinFull { get; set; }
        public Double? pmt_NoRetroAmt { get; set; }
        public String? pmt_Method { get; set; }
        public String? pmt_Info { get; set; }
        public Double? pmt_Amount { get; set; }
        public Boolean? deleted { get; set; }
    }
}
