/****** Object:  Table [dbo].[MindTarget]    Script Date: 8/3/17 1:52:51 μμ ******/
DROP TABLE [dbo].[MindTarget]
GO

/****** Object:  Table [dbo].[MindTarget]    Script Date: 8/3/17 1:52:51 μμ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MindTarget](
	[Id] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Target] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
