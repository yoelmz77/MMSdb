using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Facilities")]
    public class tbl_Facilities
    {
        [Key]
        public long fac_ID { get; set; }
        public String? fac_Name { get; set; }
        public String? fac_Address { get; set; }
        public String? fac_City { get; set; }
        public String? fac_State { get; set; }
        public String? fac_Zip { get; set; }
        public String? fac_Phone { get; set; }
        public String? fac_Fax { get; set; }
        public Double? fac_Perdiem { get; set; }
        public Double? fac_Percent { get; set; }
        public Boolean? fac_Active { get; set; }
        public Boolean? deleted { get; set; }
    }
}
