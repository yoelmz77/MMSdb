using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_Image")]
    public class tbl_Image
    {
        [Key]
        public long img_ID { get; set; }
        public long dmg_ID { get; set; }
        public Byte[]? img_Image { get; set; }
        public Boolean? deleted { get; set; }
    }
}
