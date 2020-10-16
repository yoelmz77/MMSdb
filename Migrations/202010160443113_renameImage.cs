namespace MMSdb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Image", "img_Image", c => c.Binary());
            DropColumn("dbo.tbl_Image", "img_BImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_Image", "img_BImage", c => c.Binary());
            DropColumn("dbo.tbl_Image", "img_Image");
        }
    }
}
