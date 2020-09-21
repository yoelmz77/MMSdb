using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Physicians")]
    public class tbl_Physicians
    {
        [Key]
        public long phy_ID { get; set; }
        public long dmg_ID { get; set; }
        public String? phy_Name { get; set; }
        public String? phy_Specialty { get; set; }
        public String? phy_Address { get; set; }
        public String? phy_Phone { get; set; }
        public String? phy_Fax { get; set; }
        public String? phy_FirstVisit { get; set; }
        public String? phy_LastVisit { get; set; }
        public String? phy_NextVisit { get; set; }
        public String? phy_MedRecRequested { get; set; }
        public String? phy_MedRecReceived { get; set; }
        public String? phy_MedRecPaid { get; set; }
        public String? phy_Treatment { get; set; }
        public Boolean? deleted { get; set; }
    }
}
