namespace MMSdb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Image", "img_BImage", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_Image", "img_BImage");
        }
    }
}
