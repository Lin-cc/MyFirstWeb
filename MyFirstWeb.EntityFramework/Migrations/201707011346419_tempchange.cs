namespace MyFirstWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tempchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LinLanguages", "IsDisabled", c => c.Boolean(nullable: false));
            AlterColumn("dbo.LinAuditLogs", "ServiceName", c => c.String());
            AlterColumn("dbo.LinAuditLogs", "MethodName", c => c.String());
            AlterColumn("dbo.LinAuditLogs", "Parameters", c => c.String());
            AlterColumn("dbo.LinAuditLogs", "ClientIpAddress", c => c.String());
            AlterColumn("dbo.LinAuditLogs", "ClientName", c => c.String());
            AlterColumn("dbo.LinAuditLogs", "BrowserInfo", c => c.String());
            AlterColumn("dbo.LinAuditLogs", "Exception", c => c.String());
            AlterColumn("dbo.LinAuditLogs", "CustomData", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LinAuditLogs", "CustomData", c => c.String(maxLength: 2000));
            AlterColumn("dbo.LinAuditLogs", "Exception", c => c.String(maxLength: 2000));
            AlterColumn("dbo.LinAuditLogs", "BrowserInfo", c => c.String(maxLength: 256));
            AlterColumn("dbo.LinAuditLogs", "ClientName", c => c.String(maxLength: 128));
            AlterColumn("dbo.LinAuditLogs", "ClientIpAddress", c => c.String(maxLength: 64));
            AlterColumn("dbo.LinAuditLogs", "Parameters", c => c.String(maxLength: 1024));
            AlterColumn("dbo.LinAuditLogs", "MethodName", c => c.String(maxLength: 256));
            AlterColumn("dbo.LinAuditLogs", "ServiceName", c => c.String(maxLength: 256));
            DropColumn("dbo.LinLanguages", "IsDisabled");
        }
    }
}
