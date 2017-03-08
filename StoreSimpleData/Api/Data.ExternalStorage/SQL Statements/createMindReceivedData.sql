


/****** Object:  Table [dbo].[MindReceivedData]    Script Date: 8/3/17 10:43:16 πμ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MindReceivedData](
	[Id] [int] NULL,
	[Details] [varchar](max) NULL,
	[Title] [varchar](50) NULL,
	[Score] [float] NULL,
	[MaxTarget] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


