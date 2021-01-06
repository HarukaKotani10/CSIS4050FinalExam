using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using TravelBookingCodeFirstFromDB;

namespace TravelBookingApp
{
    public partial class TravelBookingForm : Form
    {
        /// <summary>
        /// This simple application only requires a single context that is kept open
        /// while the form is active. No need to use unit-of-work or EFController at all.
        /// </summary>
        TravelBookingEntities context;
        public TravelBookingForm()
        {

            InitializeComponent();

            // create new context, do not dispose

            context = new TravelBookingEntities();

            // initialize the database using extension methods

            context.CreateDatabase();

            // make sure you add code to the SeedData() method to add the data to the db

            context.SeedData();

            this.Load += (s, e) => TravelBookingForm_Load();
            buttonFilter.Click += ButtonFilter_Click;
            buttonUpdateDatabase.Click += ButtonUpdateDatabase_Click;
        }

        /// <summary>
        /// Update the db
        /// </summary>
        private void ButtonUpdateDatabase_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        /// <summary>
        /// Filter DestinationCode and display in BookingReportGridView
        /// </summary>
        private void ButtonFilter_Click(object sender, EventArgs e)
        {

            string destination = textBoxDestinationCode.Text.ToUpper();

            // get items that matches destinationCode entered
            var selectedCode =
                from v in context.Bookings
                where v.Flight.DestinationCode == destination
                select v;

            int flightCost = 0;
            dataGridViewReport.Rows.Clear();

            foreach (var booking in selectedCode)
            {
                dataGridViewReport.Rows.Add(new string[] {booking.Client.ClientName, booking.Flight.DestinationCode,
                booking.Flight.DestinationName, booking.Flight.FlightCost.ToString()});
                flightCost = (int)(flightCost + booking.Flight.FlightCost);
            }

            Booking booking1 = new Booking();

            labelDisplayNumberOfBookings.Text = selectedCode.Count().ToString("n0");
            labelDisplayAverageBookingCost.Text = (flightCost / selectedCode.Count()).ToString("c2");
        }

        /// <summary>
        /// Set up all of the datagridview controls
        /// </summary>
        private void TravelBookingForm_Load()
        {
            // common setup for datagridview controls

            InitializeDataGridView<Client>(dataGridViewClients, "Clients");
            InitializeDataGridView<Flight>(dataGridViewFlights, "Flights");
            InitializeDataGridView<Booking>(dataGridViewBookings, "Bookings");
            InitializeDataGridViewBookingReport();

            this.dataGridViewClients.Columns["Bookings"].Visible = false;
            this.dataGridViewFlights.Columns["Bookings"].Visible = false;
            this.dataGridViewBookings.Columns["Client"].Visible = false;
            this.dataGridViewBookings.Columns["Flight"].Visible = false;

        }


        /// <summary>
        /// Default handler for invalid data entered in a datagridview cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Invalid data entered");
        }

        /// <summary>
        /// Initializes datagridview controls with default properties set.
        /// Feel free to use this or adapt as you see fit.
        /// </summary>
        /// <param name="dataGridView"></param>
        private void InitializeDataGridView<T>(DataGridView dataGridView, params string[] navProperties) where T : class
        {
            dataGridView.DataError += HandleDataError;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView.DataSource = SetBindingList<T>();

        }

        /// <summary>
        /// Set up the BookingReportGridView
        /// </summary>
        private void InitializeDataGridViewBookingReport()
        {
            dataGridViewReport.Columns.Clear();  // any columns created by the designer, get rid of them
            dataGridViewReport.ReadOnly = true;  // no cell editing allowed
            dataGridViewReport.AllowUserToAddRows = true;     // no rows can be added or deleted
            dataGridViewReport.AllowUserToDeleteRows = false;

            // right justify everything

            dataGridViewReport.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewReport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // set the colum 
            DataGridViewColumn[] columns = new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "ClientName", Width = 132},
                new DataGridViewTextBoxColumn() { Name = "DestinationCode", Width = 132},
                new DataGridViewTextBoxColumn() { Name = "DestinationName", Width = 132 },
                new DataGridViewTextBoxColumn() { Name = "FlightCost", Width = 132, ValueType = typeof(int) },

            };

            dataGridViewReport.Columns.AddRange(columns);
            dataGridViewReport.Rows.Clear();
            int flightCost = 0;

            foreach (Booking booking in context.Bookings)
            {
                dataGridViewReport.Rows.Add(new string[] {booking.Client.ClientName, booking.Flight.DestinationCode,
                booking.Flight.DestinationName, booking.Flight.FlightCost.ToString()});
                flightCost = (int)(flightCost + booking.Flight.FlightCost);
            }

            Booking booking1 = new Booking();

            labelDisplayNumberOfBookings.Text = context.Bookings.Count().ToString("n0");
            labelDisplayAverageBookingCost.Text = (flightCost / context.Bookings.Count()).ToString("c2");
        }

        /// <summary>
        /// Save changes to the database, and update the controls
        /// </summary>
        private void SaveChanges()
        {

            foreach (Booking booking in context.Bookings)
            {
                if (booking.Client == null || booking.Flight == null)
                    context.Bookings.Remove(booking);
            }

            // update the database

            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error updating the database: " + e.Message);
                Environment.Exit(1);
            }

            // refresh the controls

            dataGridViewClients.Refresh();
            dataGridViewFlights.Refresh();
            dataGridViewReport.Refresh();
        }


        /// <summary>
        /// Generic method to load a table and set it to a BindingList for use
        /// by DataGridView.
        /// 
        /// Can be used to reload tables from db. This is done in the generic
        /// addupdate form processing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private BindingList<T> SetBindingList<T>() where T : class
        {
            DbSet<T> dbSet = context.Set<T>();

            dbSet.Load();
            BindingList<T> list = dbSet.Local.ToBindingList<T>();
            return list;
        }

    }
}
