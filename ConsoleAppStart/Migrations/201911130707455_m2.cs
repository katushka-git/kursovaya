namespace ConsoleAppStart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Orders1", newName: "Contracts");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Contracts", newName: "Orders1");
        }
    }
}
