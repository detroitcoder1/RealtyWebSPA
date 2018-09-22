namespace RealtyWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PropertyAddress = c.String(nullable: false),
                        SSN = c.String(),
                        Debt = c.Int(nullable: false),
                        Pets = c.String(),
                        PreviousAdress = c.String(),
                        LandLord = c.String(),
                        LandLphone = c.String(),
                        MonthlyPayment = c.String(),
                        IsLeased = c.Boolean(nullable: false),
                        IsOwned = c.Boolean(nullable: false),
                        Occupation = c.String(),
                        CoAppSSN = c.String(),
                        CoApplicanFname = c.String(),
                        CoApplicanLname = c.String(),
                        OtherOccupants = c.String(),
                        Employer = c.String(),
                        SupervisorName = c.String(),
                        EmployerPhone = c.String(),
                        HowLongEmployed = c.String(),
                        AnnualIncome = c.Int(nullable: false),
                        OtherIncome = c.String(),
                        Reference2 = c.String(),
                        RefPhone2 = c.String(),
                        Reference1 = c.String(),
                        RefPhone1 = c.String(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUserRoles", "Customer_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Company", c => c.String());
            AddColumn("dbo.AspNetUsers", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "IsPartner", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUserClaims", "Customer_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUserLogins", "Customer_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUserClaims", "Customer_Id");
            CreateIndex("dbo.AspNetUserLogins", "Customer_Id");
            CreateIndex("dbo.AspNetUserRoles", "Customer_Id");
            AddForeignKey("dbo.AspNetUserClaims", "Customer_Id", "dbo.Customers", "Id");
            AddForeignKey("dbo.AspNetUserLogins", "Customer_Id", "dbo.Customers", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.AspNetUserLogins", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.AspNetUserClaims", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.AspNetUserRoles", new[] { "Customer_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "Customer_Id" });
            DropIndex("dbo.AspNetUserClaims", new[] { "Customer_Id" });
            DropColumn("dbo.AspNetUserLogins", "Customer_Id");
            DropColumn("dbo.AspNetUserClaims", "Customer_Id");
            DropColumn("dbo.AspNetUsers", "IsPartner");
            DropColumn("dbo.AspNetUsers", "IsActive");
            DropColumn("dbo.AspNetUsers", "Company");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUserRoles", "Customer_Id");
            DropTable("dbo.Customers");
        }
    }
}
