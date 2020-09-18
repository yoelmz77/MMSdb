using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.Models
{
    [Table("clsAccntReceivable")]
    class clsAccntReceivable
    {
        [Key]

        public long ID { get; set; }
        public long DemographicID { get; set; }
        public Double SSIMonthlyAmt { get; set; }
        public Double SSIRetroAmt { get; set; }
        public Double SSIMMS25 { get; set; }
        public Double SSIMedicalConference { get; set; }
        public String SSIPhysician { get; set; }
        public Double SSICopyExpense { get; set; }
        public Double SSICertifiedMail { get; set; }
        public Double SSIRegStamps { get; set; }
        public Double SSITravel { get; set; }
        public Double SSIOfficeSupplies { get; set; }
        public Double SSIMedicaid { get; set; }
        public String SSIOther { get; set; }
        public Double SSIOtherAmt { get; set; }
        public Double SSDIMonthlyAmt { get; set; }
        public Double SSDIRetroAmt { get; set; }
        public Double SSDIMMS25 { get; set; }
        public Double SSDIMedicalConference { get; set; }
        public String SSDIPhysician { get; set; }
        public Double SSDICopyExpense { get; set; }
        public Double SSDICertifiedMail { get; set; }
        public Double SSDIRegStamps { get; set; }
        public Double SSDITravel { get; set; }
        public Double SSDIOfficeSupplies { get; set; }
        public Double SSDIMedicaid { get; set; }
        public String SSDIOther { get; set; }
        public Double SSDIOtherAmt { get; set; }
    }
}
