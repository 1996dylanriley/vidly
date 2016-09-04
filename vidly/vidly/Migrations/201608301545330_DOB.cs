namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
