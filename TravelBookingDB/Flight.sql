CREATE TABLE [dbo].[Flight]
(
	[FlightId] INT NOT NULL IDENTITY PRIMARY KEY, 
    [DestinationCode] NVARCHAR(50) NULL, 
    [DestinationName] NVARCHAR(50) NULL, 
    [FlightCost] INT NULL
)
