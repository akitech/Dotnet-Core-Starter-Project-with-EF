namespace Internship.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Applications", "CPTformId");
            AddForeignKey("dbo.Applications", "CPTformId", "dbo.CPTforms", "CPTformId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applications", "CPTformId", "dbo.CPTforms");
            DropIndex("dbo.Applications", new[] { "CPTformId" });
        }
    }
}
