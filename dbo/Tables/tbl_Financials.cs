using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Financials")]
    public class tbl_Financials
    {
        [Key]
        public long fin_ID { get; set; }
        public long dmg_ID { get; set; }
        public String? fin_BankName { get; set; }
        public String? fin_Address { get; set; }
        public String? fin_City { get; set; }
        public String? fin_State { get; set; }
        public String? fin_Zip { get; set; }
        public String? fin_AccountType { get; set; }
        public String? fin_RoutingNo { get; set; }
        public String? fin_AccountNo { get; set; }
        public String? fin_JointPerson { get; set; }
        public Double? fin_Balance { get; set; }
        public DateTime? fin_ClosedDate { get; set; }
        public Boolean? deleted { get; set; }
    }
}
