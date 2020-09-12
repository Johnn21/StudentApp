namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [RoleTypeId]) VALUES (N'a700a410-0342-423a-b720-c08f141ef9a5', N'student1@student.com', 0, N'AImShvI8yXYK9eXQ0YkYhIWNQi3/a/qUO8P6MozEqtEMCq2kotHe8xTB8I1BCR7AAA==', N'4d8ec324-743e-46ba-8477-7ac891b31321', NULL, 0, 0, NULL, 1, 0, N'student1@student.com', 1)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [RoleTypeId]) VALUES (N'b435fd23-d2d9-499b-9a9d-7f0fb306d4d5', N'student@student.com', 0, N'ABpB1L8vueaFMYDQPBmVQ8fONob0wXBeiVFvQnGucJvkzXbL8Y8UhMaMJonxAWSa1w==', N'd6b36fd3-4e24-4a56-87d1-aba98a73b6aa', NULL, 0, 0, NULL, 1, 0, N'student@student.com', 1)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [RoleTypeId]) VALUES (N'dd5d5f62-053c-4c78-95b6-283aaa1bc357', N'teacher@student.com', 0, N'AKPH0qmhSMbM6gl8ZGxiQ+87ief/hvJlx2k4wzknmp8zo/ilK4/MPl0K6dIVKwIIQg==', N'de9eec4c-cce4-4c2b-bf64-d328e3c45159', NULL, 0, 0, NULL, 1, 0, N'teacher@student.com', 2)

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8c63cb41-1c28-405c-b052-1ed47817de4c', N'Student')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a700a410-0342-423a-b720-c08f141ef9a5', N'8c63cb41-1c28-405c-b052-1ed47817de4c')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
