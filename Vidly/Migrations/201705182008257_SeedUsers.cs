namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a76dfb9f-1272-48cd-8ab8-b07dbd185064', N'guest@vidly.com', 0, N'AHygQ7n3X18jSHE1hAGeq+Tif/g7zm//0HlwTLxugtn0tA++HvTXxPrAfsVTL4rMGw==', N'2175fb86-afcd-4fe2-9f9b-5a51d6246ea1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ef567c3d-4a2c-4799-a050-39f5b568d815', N'admin@vidly.com', 0, N'AIPWfLItiu7kF6H0yWIT3XDGD1l7fi5UnJdgsu+aYUzJHkG2y8dsKbnTY9tp4I8cgw==', N'50e8f722-884f-4271-9dfa-537501009479', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'af3730a3-8044-40ee-8938-aea0977fd6b0', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ef567c3d-4a2c-4799-a050-39f5b568d815', N'af3730a3-8044-40ee-8938-aea0977fd6b0')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
