
DECLARE @UserId UNIQUEIDENTIFIER = '1F6388E7-49F1-48E3-9F58-14F657CB0D0D'
DECLARE @RoleId UNIQUEIDENTIFIER

IF NOT EXISTS(Select * FROM AspNetUsers Where UserName ='Admin')
	INSERT INTO AspNetUsers(Id, UserName,Email,PasswordHash,NormalizedUserName,AccessFailedCount,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled) Values
	(@UserId,'Admin','admin@gmail.com','AQAAAAIAAYagAAAAEKTZ/LyaD/jMUOPVuKBVLkdaXActb20JNAnuG3ODBO/1H65ORgWAySm0GdnC1UJgxQ==','Admin User',0,1,1,0,0);

--AspNetRoles Table Data Import
IF NOT EXISTS(Select * FROM AspNetRoles Where Name ='Admin')
	INSERT INTO AspNetRoles(Id, [Name]) Values
	('4F6A88E7-49F1-48E3-9F58-14F657CB09F1','Admin');

SELECT @RoleId = Id FROM AspNetRoles WHERE Name = 'Admin'

IF @RoleId IS NOT NULL
BEGIN
    IF NOT EXISTS ( SELECT * FROM AspNetUserRoles WHERE UserId = @UserId AND RoleId = @RoleId)
    BEGIN
        INSERT INTO AspNetUserRoles (UserId, RoleId)
        VALUES (@UserId, @RoleId)
    END
END


