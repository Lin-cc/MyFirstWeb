namespace MyFirstWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTablePrefix : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AbpAuditLogs", newName: "LinAuditLogs");
            RenameTable(name: "dbo.AbpBackgroundJobs", newName: "LinBackgroundJobs");
            RenameTable(name: "dbo.AbpFeatures", newName: "LinFeatures");
            RenameTable(name: "dbo.AbpEditions", newName: "LinEditions");
            RenameTable(name: "dbo.AbpLanguages", newName: "LinLanguages");
            RenameTable(name: "dbo.AbpLanguageTexts", newName: "LinLanguageTexts");
            RenameTable(name: "dbo.AbpNotifications", newName: "LinNotifications");
            RenameTable(name: "dbo.AbpNotificationSubscriptions", newName: "LinNotificationSubscriptions");
            RenameTable(name: "dbo.AbpOrganizationUnits", newName: "LinOrganizationUnits");
            RenameTable(name: "dbo.AbpPermissions", newName: "LinPermissions");
            RenameTable(name: "dbo.AbpRoles", newName: "LinRoles");
            RenameTable(name: "dbo.AbpUsers", newName: "LinUsers");
            RenameTable(name: "dbo.AbpUserClaims", newName: "LinUserClaims");
            RenameTable(name: "dbo.AbpUserLogins", newName: "LinUserLogins");
            RenameTable(name: "dbo.AbpUserRoles", newName: "LinUserRoles");
            RenameTable(name: "dbo.AbpSettings", newName: "LinSettings");
            RenameTable(name: "dbo.AbpTenantNotifications", newName: "LinTenantNotifications");
            RenameTable(name: "dbo.AbpTenants", newName: "LinTenants");
            RenameTable(name: "dbo.AbpUserAccounts", newName: "LinUserAccounts");
            RenameTable(name: "dbo.AbpUserLoginAttempts", newName: "LinUserLoginAttempts");
            RenameTable(name: "dbo.AbpUserNotifications", newName: "LinUserNotifications");
            RenameTable(name: "dbo.AbpUserOrganizationUnits", newName: "LinUserOrganizationUnits");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.LinUserOrganizationUnits", newName: "AbpUserOrganizationUnits");
            RenameTable(name: "dbo.LinUserNotifications", newName: "AbpUserNotifications");
            RenameTable(name: "dbo.LinUserLoginAttempts", newName: "AbpUserLoginAttempts");
            RenameTable(name: "dbo.LinUserAccounts", newName: "AbpUserAccounts");
            RenameTable(name: "dbo.LinTenants", newName: "AbpTenants");
            RenameTable(name: "dbo.LinTenantNotifications", newName: "AbpTenantNotifications");
            RenameTable(name: "dbo.LinSettings", newName: "AbpSettings");
            RenameTable(name: "dbo.LinUserRoles", newName: "AbpUserRoles");
            RenameTable(name: "dbo.LinUserLogins", newName: "AbpUserLogins");
            RenameTable(name: "dbo.LinUserClaims", newName: "AbpUserClaims");
            RenameTable(name: "dbo.LinUsers", newName: "AbpUsers");
            RenameTable(name: "dbo.LinRoles", newName: "AbpRoles");
            RenameTable(name: "dbo.LinPermissions", newName: "AbpPermissions");
            RenameTable(name: "dbo.LinOrganizationUnits", newName: "AbpOrganizationUnits");
            RenameTable(name: "dbo.LinNotificationSubscriptions", newName: "AbpNotificationSubscriptions");
            RenameTable(name: "dbo.LinNotifications", newName: "AbpNotifications");
            RenameTable(name: "dbo.LinLanguageTexts", newName: "AbpLanguageTexts");
            RenameTable(name: "dbo.LinLanguages", newName: "AbpLanguages");
            RenameTable(name: "dbo.LinEditions", newName: "AbpEditions");
            RenameTable(name: "dbo.LinFeatures", newName: "AbpFeatures");
            RenameTable(name: "dbo.LinBackgroundJobs", newName: "AbpBackgroundJobs");
            RenameTable(name: "dbo.LinAuditLogs", newName: "AbpAuditLogs");
        }
    }
}
