CREATE TABLE [dbo].[Booking]
(
	[BookingId] INT NOT NULL IDENTITY PRIMARY KEY, 
    [ClientId] INT NOT NULL, 
    [FlightId] INT NOT NULL, 
    CONSTRAINT [FK_Bookings_ToClient] FOREIGN KEY ([ClientId]) REFERENCES Client ([ClientId]), 
    CONSTRAINT [FK_Bookings_ToFlight] FOREIGN KEY ([FlightId]) REFERENCES Flight([FlightId])
)
