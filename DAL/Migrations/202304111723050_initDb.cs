namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketId = c.Int(nullable: false),
                        uId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        OrderStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.TicketId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.uId, cascadeDelete: true)
                .Index(t => t.TicketId)
                .Index(t => t.uId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false),
                        TimeOfShow = c.DateTime(nullable: false),
                        Status = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "uId", "dbo.Users");
            DropForeignKey("dbo.OrderDetails", "TicketId", "dbo.Tickets");
            DropIndex("dbo.OrderDetails", new[] { "uId" });
            DropIndex("dbo.OrderDetails", new[] { "TicketId" });
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
            DropTable("dbo.OrderDetails");
        }
    }
}
