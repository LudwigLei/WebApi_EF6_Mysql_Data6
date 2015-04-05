namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogContentColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Content", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Content");
        }
    }
}
