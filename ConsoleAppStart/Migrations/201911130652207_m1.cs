namespace ConsoleAppStart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOrder = c.Int(nullable: false),
                        ServiceCode = c.Int(nullable: false),
                        Orders_Id = c.Int(),
                        Services_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Orders_Id)
                .ForeignKey("dbo.Services", t => t.Services_Id)
                .Index(t => t.Orders_Id)
                .Index(t => t.Services_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSercvice = c.String(),
                        PrceService = c.Int(nullable: false),
                        ServiceCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders1", "Orders_Id", c => c.Int());
            AddColumn("dbo.Orders", "IdClient", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Client_Id", c => c.Int());
            AddColumn("dbo.Orders", "Employee_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Client_Id");
            CreateIndex("dbo.Orders", "Employee_Id");
            CreateIndex("dbo.Orders1", "Orders_Id");
            AddForeignKey("dbo.Orders1", "Orders_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.Orders", "Client_Id", "dbo.Clients", "Id");
            AddForeignKey("dbo.Orders", "Employee_Id", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceOrders", "Services_Id", "dbo.Services");
            DropForeignKey("dbo.Orders", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.ServiceOrders", "Orders_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders1", "Orders_Id", "dbo.Orders");
            DropIndex("dbo.ServiceOrders", new[] { "Services_Id" });
            DropIndex("dbo.ServiceOrders", new[] { "Orders_Id" });
            DropIndex("dbo.Orders1", new[] { "Orders_Id" });
            DropIndex("dbo.Orders", new[] { "Employee_Id" });
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropColumn("dbo.Orders", "Employee_Id");
            DropColumn("dbo.Orders", "Client_Id");
            DropColumn("dbo.Orders", "IdClient");
            DropColumn("dbo.Orders1", "Orders_Id");
            DropTable("dbo.Services");
            DropTable("dbo.ServiceOrders");
        }
    }
}
