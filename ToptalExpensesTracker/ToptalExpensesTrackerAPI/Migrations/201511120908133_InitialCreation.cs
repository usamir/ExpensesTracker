namespace ToptalExpensesTrackerAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Expenses", "User_Id", "dbo.Users");
            DropIndex("dbo.Expenses", new[] { "User_Id" });
            AddColumn("dbo.Expenses", "UserId", c => c.String());
            DropColumn("dbo.Expenses", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Expenses", "User_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Expenses", "UserId");
            CreateIndex("dbo.Expenses", "User_Id");
            AddForeignKey("dbo.Expenses", "User_Id", "dbo.Users", "Id");
        }
    }
}
