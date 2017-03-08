/****** Object:  Table [dbo].[MindReceivedData]    Script Date: 8/3/17 1:57:38 μμ ******/
DROP TABLE [dbo].[MindReceivedData]
GO

/****** Object:  Table [dbo].[MindReceivedData]    Script Date: 8/3/17 1:57:38 μμ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MindReceivedData](
	[Id] [int]  NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Details] [varchar](max) NULL,
	[Title] [varchar](50) NULL,
	[Score] [float] NULL,
	[MaxTarget] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO