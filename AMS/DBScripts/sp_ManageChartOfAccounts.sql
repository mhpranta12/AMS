IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_ManageChartOfAccounts]'))
    DROP PROCEDURE [dbo].[sp_ManageChartOfAccounts]
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
CREATE PROCEDURE sp_ManageChartOfAccounts
	-- Add the parameters for the stored procedure here
	@Action NVARCHAR(20),
	@Id uniqueidentifier , 
	@Name nvarchar(50) , 
	@UserType nvarchar(50),
	@Cash decimal(18,2),
	@ParentAccountId uniqueidentifier = null,
	@AccountType nvarchar(50),
	@Recieveable decimal(18,2)
AS
BEGIN
	SET NOCOUNT ON;
IF @Action = 'Insert'
BEGIN

    -- Insert statements for procedure here
	 INSERT INTO Accounts (Id, Name, UserType,Cash,Recieveable,ParentAccountId,AccountType)
    VALUES (@Id, @Name, @UserType,@Cash,@Recieveable,@ParentAccountId,@AccountType);
END
ELSE IF @Action = 'Update'
BEGIN

    -- Insert statements for procedure here
	 INSERT INTO Accounts (Id, Name, UserType,Cash,Recieveable,ParentAccountId,AccountType)
    VALUES (@Id, @Name, @UserType,@Cash,@Recieveable,@ParentAccountId,@AccountType);
END
END
