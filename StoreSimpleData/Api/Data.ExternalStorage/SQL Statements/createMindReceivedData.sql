
/****** Object:  Table [dbo].[MindReceivedData]    Script Date: 11/1/2017 2:49:37 μμ ******/
DROP TABLE [dbo].[MindReceivedData]
GO

/****** Object:  Table [dbo].[MindReceivedData]    Script Date: 11/1/2017 2:49:37 μμ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MindReceivedData](
	[Id] [int] NULL,
	[Target] [int] NULL,
	[Details] [varchar](max) NULL,
	[Title] [varchar](50) NULL,
	[Approved] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO




