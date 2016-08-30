namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesGenresNamed1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "GenreName");
        }
    }
}
