namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCategoryToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreName", c => c.String());
            AddColumn("dbo.Movies", "Category", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Category");
            DropColumn("dbo.Movies", "GenreName");
        }
    }
}
