using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_CarsOwned")]
    public class tbl_CarsOwned
    {
        [Key]

        public long cars_ID { get; set; }
        public long dmg_ID { get; set; }
        public String? cars_Notes { get; set; }
        public Boolean? deleted { get; set; }
    }
}
