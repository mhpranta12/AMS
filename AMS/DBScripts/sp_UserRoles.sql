IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_UserRoles]'))
    DROP PROCEDURE [dbo].[sp_UserRoles]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE sp_UserRoles
	-- Add the parameters for the stored procedure here
	@Action NVARCHAR(20),
	@Id uniqueidentifier , 
	@Name nvarchar(50) 
AS
BEGIN
	SET NOCOUNT ON;
IF @Action = 'Create'
BEGIN

    -- Insert statements for procedure here
	 INSERT INTO AspNetRoles (Id, [Name])
     VALUES (@Id, @Name);
END
ELSE IF @Action = 'Remove'
BEGIN

    DELETE FROM AspNetRoles WHERE Id=@Id;
END
END
