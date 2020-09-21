using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Cars")]
    public class tbl_Cars
    {
        [Key]
        public long car_ID { get; set; }
        public long cars_ID { get; set; }
        public String? car_Type { get; set; }
        public String? car_Year { get; set; }
        public String? car_Make { get; set; }
        public String? car_Model { get; set; }
        public Double? car_Marketvalue { get; set; }
        public String? car_Color { get; set; }
        public String? car_LicensePlate { get; set; }
        public Boolean? deleted { get; set; }
    }
}
