namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1f4adb0e-0266-4e93-8456-273b1eef9dbd', N'admin@vidly.com', 0, N'AEGaSVF1kFmwCzgj+m6wA3kW4PYzQ3GKE5eKZYaEKKEqKdxT28kBkyRA4SYimVdb/g==', N'05c19102-086f-458c-97fe-2ba4c8b0c4f1', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ebc4db03-48d4-42e8-bead-b4fb4573ec65', N'guest@vidly.com', 0, N'AMLVdpayCVo4A+UU/Uui2CHhwJQQxCqYbuBISEGKswcb2gy+unXPZcAfSdvEkQUZDw==', N'2b6b235e-d552-4fa8-910d-8fa3f2d3428d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f6380b32-a862-41d8-bda4-81b5dff28afc', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1f4adb0e-0266-4e93-8456-273b1eef9dbd', N'f6380b32-a862-41d8-bda4-81b5dff28afc')
");
        }
        
        public override void Down()
        {
        }
    }
}
