namespace MMSdb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingtbl_ReportRightsUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_ReportRightsUsers",
                c => new
                    {
                        rpt_ID = c.Long(nullable: false),
                        usr_ID = c.Long(nullable: false),
                        rpt_CanAccess = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.rpt_ID, t.usr_ID });
            
            AddColumn("dbo.tbl_UserRights", "ur_DeleteSocialSecurityyoel", c => c.Boolean());
            DropColumn("dbo.tbl_UserRights", "ur_DeleteSocialSecurity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_UserRights", "ur_DeleteSocialSecurity", c => c.Boolean());
            DropColumn("dbo.tbl_UserRights", "ur_DeleteSocialSecurityyoel");
            DropTable("dbo.tbl_ReportRightsUsers");
        }
    }
}
