namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedMovieGenreInt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.Int(nullable: false));
        }
    }
}
