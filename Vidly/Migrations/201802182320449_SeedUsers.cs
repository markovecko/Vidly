namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'20266e68-57c3-4a54-944b-5e92063e1f67', N'guest@vidly.com', 0, N'AM4HEZCePu+FxP4dqJVuMGGu7Xv9SWIelNTcZ8bojh8heE/8WLdyv5uw9s+kxVxAFw==', N'20718613-6e6f-4ee6-a335-35c790f6afd6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f9bc9e7c-9afd-4822-a456-d83b706ffae7', N'admin@vidly.com', 0, N'AKTojkTpK5w0NQtwZj941kW1mBaljkstOKhYUpKFhjaOepcy9lOlHeXttQgERPqRuQ==', N'92ec92f9-868a-4604-b187-8fd537fbced9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6b4f8163-8e4d-47aa-a744-ec200b8ed45f', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f9bc9e7c-9afd-4822-a456-d83b706ffae7', N'6b4f8163-8e4d-47aa-a744-ec200b8ed45f')

         ");
        }
        
        public override void Down()
        {
        }
    }
}
