namespace InageUpload.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "imagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "imagePath");
        }
    }
}
