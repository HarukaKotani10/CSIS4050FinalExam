using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;

namespace TravelBookingCodeFirstFromDB
{
    /// <summary>
    /// Extension methods to create and seed the TravelBookingDB
    /// 
    /// This will contain compile errors until the entity classes are created.
    /// </summary>
    public static class SeedDatabaseExtensionMethods
    {
        /// <summary>
        /// Creates the TravelBookingDB
        /// 
        /// Used by TravelBookingApp and TravelBookingWebSite
        /// 
        /// DO NOT CHANGE THIS
        /// </summary>
        /// <param name="context"></param>
        public static void CreateDatabase(this TravelBookingEntities context)
        {
            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();

            context.Database.Delete();
            context.Database.Create();

            context.SaveChanges();
        }

        /// <summary>
        /// Seeds the TravelBookingDB from a list of data for each table
        /// 
        /// Code MUST BE ADDED to update the database.
        /// 
        /// Just use the context parameter to do so.
        /// </summary>
        /// <param name="context"></param>
        public static void SeedData(this TravelBookingEntities context)
        {
            // Client data

            List<Client> clients = new List<Client>()
            {
                new Client() { ClientName = "Patricio"},
                new Client() { ClientName = "Gurjit"},
                new Client() { ClientName = "Arshpreet"},
                new Client() { ClientName = "Andrei"},
                new Client() { ClientName = "Parmanpreet"},
                new Client() { ClientName = "Natalia"},
                new Client() { ClientName = "Naina"},
                new Client() { ClientName = "Julia"},
                new Client() { ClientName = "Max"},
                new Client() { ClientName = "Himani"},
                new Client() { ClientName = "Kanika"},
                new Client() { ClientName = "Satnam"},
                new Client() { ClientName = "Karandeep"},
                new Client() { ClientName = "Kyung Hee"},
                new Client() { ClientName = "Vaishali"},
                new Client() { ClientName = "Raphael"},
            };

            context.Clients.AddRange(clients);
            context.SaveChanges();

            // Flight data

            List<Flight> flights = new List<Flight>()
            {
                new Flight() { DestinationCode = "YVR", DestinationName = "Vancouver", FlightCost = 500 },
                new Flight() { DestinationCode = "YVR", DestinationName = "Vancouver", FlightCost = 2000 },
                new Flight() { DestinationCode = "YYZ", DestinationName = "Toronto", FlightCost = 300 },
                new Flight() { DestinationCode = "MIA", DestinationName = "Miami", FlightCost = 600 },
                new Flight() { DestinationCode = "LAS", DestinationName = "Las Vegas", FlightCost = 450 },
                new Flight() { DestinationCode = "DEL", DestinationName = "Delhi", FlightCost = 1100 },
                new Flight() { DestinationCode = "DEL", DestinationName = "Delhi", FlightCost = 3000 },
                new Flight() { DestinationCode = "HKG", DestinationName = "Hong Kong", FlightCost = 1300 },
                new Flight() { DestinationCode = "SEA", DestinationName = "Seattle", FlightCost = 500 },
                new Flight() { DestinationCode = "LHR", DestinationName = "London", FlightCost = 800 },
                new Flight() { DestinationCode = "ICN", DestinationName = "Seoul", FlightCost = 1200 },
            };

            context.Flights.AddRange(flights);
            context.SaveChanges();

            // Bookings data

            List<Booking> bookings = new List<Booking>()
            {
                new Booking() { ClientId = 1, FlightId = 1},
                new Booking() { ClientId = 14, FlightId = 2},
                new Booking() { ClientId = 13, FlightId = 3},
                new Booking() { ClientId = 12, FlightId = 4},
                new Booking() { ClientId = 3, FlightId = 5},
                new Booking() { ClientId = 5, FlightId = 6},
                new Booking() { ClientId = 7, FlightId = 7},
                new Booking() { ClientId = 2, FlightId = 8},
                new Booking() { ClientId = 9, FlightId = 9},
                new Booking() { ClientId = 8, FlightId = 10},
                new Booking() { ClientId = 9, FlightId = 11},
                new Booking() { ClientId = 4, FlightId = 1},
                new Booking() { ClientId = 11, FlightId = 2},
                new Booking() { ClientId = 10, FlightId = 5},
                new Booking() { ClientId = 14, FlightId = 6},
                new Booking() { ClientId = 6, FlightId = 7},
                new Booking() { ClientId = 12, FlightId = 9},
                new Booking() { ClientId = 13, FlightId = 9},

            };

            context.Bookings.AddRange(bookings);
            context.SaveChanges();


        }
    }
}
