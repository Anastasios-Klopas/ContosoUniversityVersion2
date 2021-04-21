namespace ContosoUniversityVersion2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoMaxLengthOnNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "LastName", c => c.String());
            AlterColumn("dbo.Student", "FirstMidName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "FirstMidName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Student", "LastName", c => c.String(maxLength: 50));
        }
    }
}
