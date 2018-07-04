namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2e98c94e-748c-4250-aee6-ea77665cbfb8', N'admin@vidly.com', 0, N'ANplS6RPpC/NM/KK45KMAFS3LSn38Y1qE8MGGSv8270cnD1RmIr6BQO/02w7xUnCaw==', N'beba1678-9332-419c-b05f-3ea5712e960d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3e3aef52-2bd3-4ca8-a28d-9c0988e311d2', N'guest@vidly.com', 0, N'AIyAFiqvyp0mP74RDUrhs2FM/3jQlpvoRhscCmlDknycFH+0iZtgX+BpKzWER9bGGA==', N'92be2f25-5ca1-4e6f-b5a1-df9deec51444', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'35163769-2554-4a2f-aad3-d0b509b8035d', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2e98c94e-748c-4250-aee6-ea77665cbfb8', N'35163769-2554-4a2f-aad3-d0b509b8035d')  
");
        }
        
        public override void Down()
        {
        }
    }
}
