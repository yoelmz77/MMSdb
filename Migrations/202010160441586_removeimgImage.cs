namespace MMSdb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeimgImage : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tbl_Image", "img_Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_Image", "img_Image", c => c.String());
        }
    }
}
