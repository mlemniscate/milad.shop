namespace milad.shop.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAggrigateAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CustomerContext.Address",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PostalCode = c.String(nullable: false, maxLength: 10),
                        AddressLine = c.String(nullable: false, maxLength: 500),
                        CityId = c.Int(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("CustomerContext.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "CustomerContext.Customer",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        Password = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("CustomerContext.Address", "CustomerId", "CustomerContext.Customer");
            DropIndex("CustomerContext.Address", new[] { "CustomerId" });
            DropTable("CustomerContext.Customer");
            DropTable("CustomerContext.Address");
        }
    }
}
