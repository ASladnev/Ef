namespace efContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComputerPrinter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        ComputerId = c.String(nullable: false, maxLength: 128),
                        Vendor = c.String(),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.ComputerId);
            
            CreateTable(
                "dbo.Printers",
                c => new
                    {
                        PrinterId = c.String(nullable: false, maxLength: 128),
                        Vendor = c.String(),
                        Counter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PrinterId);
            
            CreateTable(
                "dbo.PrinterComputers",
                c => new
                    {
                        Printer_PrinterId = c.String(nullable: false, maxLength: 128),
                        Computer_ComputerId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Printer_PrinterId, t.Computer_ComputerId })
                .ForeignKey("dbo.Printers", t => t.Printer_PrinterId, cascadeDelete: true)
                .ForeignKey("dbo.Computers", t => t.Computer_ComputerId, cascadeDelete: true)
                .Index(t => t.Printer_PrinterId)
                .Index(t => t.Computer_ComputerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrinterComputers", "Computer_ComputerId", "dbo.Computers");
            DropForeignKey("dbo.PrinterComputers", "Printer_PrinterId", "dbo.Printers");
            DropIndex("dbo.PrinterComputers", new[] { "Computer_ComputerId" });
            DropIndex("dbo.PrinterComputers", new[] { "Printer_PrinterId" });
            DropTable("dbo.PrinterComputers");
            DropTable("dbo.Printers");
            DropTable("dbo.Computers");
        }
    }
}
