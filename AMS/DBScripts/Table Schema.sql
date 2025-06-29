IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'Accounts')
BEGIN
CREATE TABLE [dbo].[Accounts](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	--[IsAdmin] [bit] NOT NULL,
	[UserType] [nvarchar](50) NULL,
	[Cash] decimal(18,2) NULL,
	[Recieveable] decimal(18,2) NULL,
	[ParentAccountId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.columns WHERE table_name = 'Accounts' AND column_name = 'AccountType')
	ALTER TABLE dbo.Accounts ADD AccountType [nvarchar](50) NULL 
GO
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'Vouchers')
BEGIN
CREATE TABLE [dbo].[Vouchers](
	[Id] [uniqueidentifier] NOT NULL,
	[Date] [datetime] NOT NULL DEFAULT(GETDATE()),
	[Type] [nvarchar](50) NULL,
	[ReferenceNo] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NOT NULL DEFAULT(GETDATE()),
 CONSTRAINT [PK_Vouchers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO