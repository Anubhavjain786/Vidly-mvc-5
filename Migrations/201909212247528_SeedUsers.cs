namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'00758093-b33c-4191-81fc-915ccbf7ff9e', N'Guest@Vidly.com', 0, N'AA2VknlbPw/TqvYRHE1rrCvIQZETTizNcoweMEKjPBD4wfel7hlAIsDKyI55NqKP8Q==', N'6a0371ae-5ea6-449f-88b0-36f99ba11c5b', NULL, 0, 0, NULL, 1, 0, N'Guest@Vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b8201bc6-d7b7-4400-b0f6-165ba40649c6', N'Admin@Vidly.com', 0, N'ABVWxCV0eo7sSAITXLmn2XlZXCugxR1AFJQ/HC2ruKniYGALKO4gSJZov6N8UCzbkw==', N'd7cb9662-1d51-4f9b-ac85-f084793b605c', NULL, 0, 0, NULL, 1, 0, N'Admin@Vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'847a2be2-f1d4-43bd-84fd-2b0be080a549', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b8201bc6-d7b7-4400-b0f6-165ba40649c6', N'847a2be2-f1d4-43bd-84fd-2b0be080a549')

");
        }
        
        public override void Down()
        {
        }
    }
}
