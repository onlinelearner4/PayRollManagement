namespace PayrollManagementDL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employeemodelfixup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "FirstName", c => c.String());
            AddColumn("dbo.Employees", "LastName", c => c.String());
            AddColumn("dbo.Employees", "Phone", c => c.String());
            DropColumn("dbo.Employees", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Name", c => c.String());
            DropColumn("dbo.Employees", "Phone");
            DropColumn("dbo.Employees", "LastName");
            DropColumn("dbo.Employees", "FirstName");
        }
    }
}
