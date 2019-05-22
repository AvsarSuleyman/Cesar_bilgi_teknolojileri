namespace otomativ_tamirhane.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.arac_ID",
                c => new
                    {
                        AracID = c.Int(nullable: false),
                        Plaka = c.String(maxLength: 50),
                        Marka = c.String(maxLength: 50),
                        Model = c.Int(),
                        ModelYili = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.AracID)
                .ForeignKey("dbo.yeni_kayit", t => t.AracID)
                .Index(t => t.AracID);
            
            CreateTable(
                "dbo.yeni_kayit",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 50),
                        Soyad = c.String(maxLength: 50),
                        Telefon = c.String(maxLength: 11),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.arac_ID", "AracID", "dbo.yeni_kayit");
            DropIndex("dbo.arac_ID", new[] { "AracID" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.yeni_kayit");
            DropTable("dbo.arac_ID");
        }
    }
}
