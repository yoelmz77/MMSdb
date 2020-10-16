namespace MMSdb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tweaks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Status",
                c => new
                    {
                        sts_ID = c.Long(nullable: false, identity: true),
                        sts_Description = c.String(),
                    })
                .PrimaryKey(t => t.sts_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Status");
        }
    }
}
