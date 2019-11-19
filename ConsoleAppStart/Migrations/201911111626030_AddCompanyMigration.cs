namespace ConsoleAppStart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Adres = c.String(),
                        Tel = c.Int(nullable: false),
                        NumberOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOrder = c.Int(nullable: false),
                        SumOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        NumberOrder = c.Int(nullable: false),
                        NameOrder = c.String(),
                        DateOrder = c.DateTime(nullable: false),
                        IdEmployee = c.Int(nullable: false),
                        Srok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
            DropTable("dbo.Orders1");
            DropTable("dbo.Employees");
        }
    }
}
