namespace DrugStore_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDatabaseGenCreatedAt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContactMesses", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContactMesses", "CreatedAt", c => c.DateTime(nullable: false));
        }
    }
}
