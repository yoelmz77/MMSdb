namespace MMSdb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hosp_Recipient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_HospitalInfo", "fac_ID", c => c.Long());
            AddColumn("dbo.tbl_HospitalInfo", "hosp_Recipient", c => c.String());
            DropColumn("dbo.tbl_HospitalInfo", "hosp_FacilityID");
            DropColumn("dbo.tbl_HospitalInfo", "hosp_Recipients");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_HospitalInfo", "hosp_Recipients", c => c.String());
            AddColumn("dbo.tbl_HospitalInfo", "hosp_FacilityID", c => c.Long());
            DropColumn("dbo.tbl_HospitalInfo", "hosp_Recipient");
            DropColumn("dbo.tbl_HospitalInfo", "fac_ID");
        }
    }
}
