
DECLARE @UserId UNIQUEIDENTIFIER 
DECLARE @RoleId UNIQUEIDENTIFIER

--AspNetRoles Table Data Import
IF NOT EXISTS(Select * FROM AspNetRoles Where [Name] ='Admin')
	INSERT INTO AspNetRoles(Id, [Name]) Values
	(NEWID(),'Admin');

SELECT @RoleId = Id FROM AspNetRoles WHERE [Name] = 'Admin'
SELECT @UserId = Id FROM AspNetUsers WHERE Email = 'admin@gmail.com'

IF @RoleId IS NOT NULL AND @UserId IS NOT NULL
BEGIN
    IF NOT EXISTS ( SELECT * FROM AspNetUserRoles WHERE UserId = @UserId AND RoleId = @RoleId)
    BEGIN
        INSERT INTO AspNetUserRoles (UserId, RoleId)
        VALUES (@UserId, @RoleId)
    END
END


