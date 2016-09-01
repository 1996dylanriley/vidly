namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedPropsFromMovies : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Genre");
            DropColumn("dbo.Movies", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Category", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Genre", c => c.Int(nullable: false));
        }
    }
}
