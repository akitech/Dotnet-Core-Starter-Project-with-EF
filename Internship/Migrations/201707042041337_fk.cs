namespace Internship.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applications", "EmployementAgreementId", c => c.Int(nullable: false));
            CreateIndex("dbo.Applications", "EmployementAgreementId");
            CreateIndex("dbo.Applications", "EmployerId");
            CreateIndex("dbo.Applications", "LearningObjectiveId");
            AddForeignKey("dbo.Applications", "EmployementAgreementId", "dbo.EmployementAgreements", "EmployementAgreementId", cascadeDelete: true);
            AddForeignKey("dbo.Applications", "EmployerId", "dbo.Employers", "EmployerId", cascadeDelete: true);
            AddForeignKey("dbo.Applications", "LearningObjectiveId", "dbo.LearningObjectives", "LearningObjectiveId", cascadeDelete: true);
            DropColumn("dbo.Applications", "EmploymentAgreementId");
            DropColumn("dbo.Applications", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Applications", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Applications", "EmploymentAgreementId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Applications", "LearningObjectiveId", "dbo.LearningObjectives");
            DropForeignKey("dbo.Applications", "EmployerId", "dbo.Employers");
            DropForeignKey("dbo.Applications", "EmployementAgreementId", "dbo.EmployementAgreements");
            DropIndex("dbo.Applications", new[] { "LearningObjectiveId" });
            DropIndex("dbo.Applications", new[] { "EmployerId" });
            DropIndex("dbo.Applications", new[] { "EmployementAgreementId" });
            DropColumn("dbo.Applications", "EmployementAgreementId");
        }
    }
}
