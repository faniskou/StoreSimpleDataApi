/****** Object:  Table [dbo].[MindTrainedData]    Script Date: 8/3/17 10:44:52 πμ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MindTrainedData](
	[Id] [int] NULL,
	[Target] [int] NULL,
	[Details] [varchar](max) NULL,
	[Title] [varchar](50) NULL,
	[Approved] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

