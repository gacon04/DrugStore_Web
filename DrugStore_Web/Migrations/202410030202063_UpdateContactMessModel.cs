namespace DrugStore_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateContactMessModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactMesses", "PhoneNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Accounts", "Address", c => c.String(maxLength: 255));
            AlterColumn("dbo.ContactMesses", "Email", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContactMesses", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Accounts", "Address", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.ContactMesses", "PhoneNumber");
        }
    }
}
