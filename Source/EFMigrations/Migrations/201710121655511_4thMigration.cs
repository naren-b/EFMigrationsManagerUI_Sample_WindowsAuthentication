namespace EFMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4thMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "SecondaryPhone", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "SecondaryPhone");
        }
    }
}
