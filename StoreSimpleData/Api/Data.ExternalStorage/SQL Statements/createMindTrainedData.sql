﻿/****** Object:  Table [dbo].[MindTrainedData]    Script Date: 11/1/2017 2:47:26 μμ ******/
DROP TABLE [dbo].[MindTrainedData]
GO

/****** Object:  Table [dbo].[MindTrainedData]    Script Date: 11/1/2017 2:47:26 μμ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MindTrainedData](
	[Id] [int] NULL,
	[Details] [varchar](max) NULL,
	[Title] [varchar](50) NULL,
	[Score] [float] NULL,
	[MaxTarget] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

