namespace efContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComputerPrinter1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PrinterComputers", "Computer_ComputerId", "dbo.Computers");
            DropForeignKey("dbo.PrinterComputers", "Printer_PrinterId", "dbo.Printers");
            DropIndex("dbo.PrinterComputers", new[] { "Printer_PrinterId" });
            DropIndex("dbo.PrinterComputers", new[] { "Computer_ComputerId" });
            DropPrimaryKey("dbo.Computers");
            DropPrimaryKey("dbo.Printers");
            DropPrimaryKey("dbo.PrinterComputers");
            AlterColumn("dbo.Computers", "ComputerId", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Computers", "Vendor", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.Computers", "Number", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.Printers", "PrinterId", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.Printers", "Vendor", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.PrinterComputers", "Printer_PrinterId", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.PrinterComputers", "Computer_ComputerId", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AddPrimaryKey("dbo.Computers", "ComputerId");
            AddPrimaryKey("dbo.Printers", "PrinterId");
            AddPrimaryKey("dbo.PrinterComputers", new[] { "Printer_PrinterId", "Computer_ComputerId" });
            CreateIndex("dbo.PrinterComputers", "Printer_PrinterId");
            CreateIndex("dbo.PrinterComputers", "Computer_ComputerId");
            AddForeignKey("dbo.PrinterComputers", "Computer_ComputerId", "dbo.Computers", "ComputerId", cascadeDelete: true);
            AddForeignKey("dbo.PrinterComputers", "Printer_PrinterId", "dbo.Printers", "PrinterId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrinterComputers", "Printer_PrinterId", "dbo.Printers");
            DropForeignKey("dbo.PrinterComputers", "Computer_ComputerId", "dbo.Computers");
            DropIndex("dbo.PrinterComputers", new[] { "Computer_ComputerId" });
            DropIndex("dbo.PrinterComputers", new[] { "Printer_PrinterId" });
            DropPrimaryKey("dbo.PrinterComputers");
            DropPrimaryKey("dbo.Printers");
            DropPrimaryKey("dbo.Computers");
            AlterColumn("dbo.PrinterComputers", "Computer_ComputerId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.PrinterComputers", "Printer_PrinterId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Printers", "Vendor", c => c.String());
            AlterColumn("dbo.Printers", "PrinterId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Computers", "Number", c => c.String());
            AlterColumn("dbo.Computers", "Vendor", c => c.String());
            AlterColumn("dbo.Computers", "ComputerId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.PrinterComputers", new[] { "Printer_PrinterId", "Computer_ComputerId" });
            AddPrimaryKey("dbo.Printers", "PrinterId");
            AddPrimaryKey("dbo.Computers", "ComputerId");
            CreateIndex("dbo.PrinterComputers", "Computer_ComputerId");
            CreateIndex("dbo.PrinterComputers", "Printer_PrinterId");
            AddForeignKey("dbo.PrinterComputers", "Printer_PrinterId", "dbo.Printers", "PrinterId", cascadeDelete: true);
            AddForeignKey("dbo.PrinterComputers", "Computer_ComputerId", "dbo.Computers", "ComputerId", cascadeDelete: true);
        }
    }
}
