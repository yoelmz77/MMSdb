using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.Models
{
    [Table("clsAccntReceivable")]
    class clsAppointment
    {
        [Key]

        public long ID { get; set; }
        public long CaseID { get; set; }
        public long UserID { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime EndTime { get; set; }
        public string Body { get; set; }
    }
}
