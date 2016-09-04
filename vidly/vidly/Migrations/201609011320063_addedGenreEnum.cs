namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedGenreEnum : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "GenreName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreName", c => c.String());
        }
    }
}
