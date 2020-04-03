namespace PrezzieWithDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        userName = c.String(nullable: false, maxLength: 128),
                        countryUser = c.String(),
                    })
                .PrimaryKey(t => t.userName);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        eMail = c.String(nullable: false, maxLength: 128),
                        password = c.String(),
                        firstName = c.String(),
                        surName = c.String(),
                        birthday = c.String(),
                        descriptionUser = c.String(),
                    })
                .PrimaryKey(t => t.eMail)
                .ForeignKey("dbo.Customers", t => t.eMail)
                .Index(t => t.eMail);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "eMail", "dbo.Customers");
            DropIndex("dbo.Profiles", new[] { "eMail" });
            DropTable("dbo.Profiles");
            DropTable("dbo.Customers");
        }
    }
}
