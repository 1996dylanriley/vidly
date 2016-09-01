namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedMovieGenreInt1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "GenreName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "GenreName", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
