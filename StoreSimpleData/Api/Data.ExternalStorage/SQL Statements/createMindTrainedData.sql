/****** Object:  Table [dbo].[MindTrainedData]    Script Date: 8/3/17 1:56:39 μμ ******/
DROP TABLE [dbo].[MindTrainedData]
GO

/****** Object:  Table [dbo].[MindTrainedData]    Script Date: 8/3/17 1:56:39 μμ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MindTrainedData](
	[Id] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Target] [int] NULL,
	[Details] [varchar](max) NULL,
	[Title] [varchar](50) NULL,
	[Approved] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
