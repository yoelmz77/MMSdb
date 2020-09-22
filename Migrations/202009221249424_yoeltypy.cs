namespace MMSdb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yoeltypy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_UserRights", "ur_DeleteSocialSecurity", c => c.Boolean());
            DropColumn("dbo.tbl_UserRights", "ur_DeleteSocialSecurityyoel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_UserRights", "ur_DeleteSocialSecurityyoel", c => c.Boolean());
            DropColumn("dbo.tbl_UserRights", "ur_DeleteSocialSecurity");
        }
    }
}
