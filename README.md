# EventCalender
Simple app to show calendar to user and set events

used FullCalendar library for calendar

mostly the web service calling is with ajax

you can see Demo here http://eventcalendar20180118011314.azurewebsites.net/

for data base Did use Entityframework with model first
it is simple table 

CREATE TABLE [dbo].[Event](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Start] [datetime] NOT NULL,
	[End] [datetime] NOT NULL,
	[Location] [nvarchar](max) NULL,
	[Color] [nvarchar](max) NULL,
	[IsFullDay] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Event] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



