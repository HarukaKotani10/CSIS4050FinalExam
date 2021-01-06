namespace TravelBookingApp
{
    partial class TravelBookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.buttonUpdateDatabase = new System.Windows.Forms.Button();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.textBoxDestinationCode = new System.Windows.Forms.TextBox();
            this.labelNumberOfBookings = new System.Windows.Forms.Label();
            this.labelDisplayNumberOfBookings = new System.Windows.Forms.Label();
            this.labelAverageBookingCost = new System.Windows.Forms.Label();
            this.labelDisplayAverageBookingCost = new System.Windows.Forms.Label();
            this.labelDestinationCode = new System.Windows.Forms.Label();
            this.labelBookingsReport = new System.Windows.Forms.Label();
            this.labelBookings = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelFlights = new System.Windows.Forms.Label();
            this.labelClients = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(31, 46);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(296, 150);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Location = new System.Drawing.Point(367, 46);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.Size = new System.Drawing.Size(470, 150);
            this.dataGridViewFlights.TabIndex = 2;
            // 
            // buttonUpdateDatabase
            // 
            this.buttonUpdateDatabase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUpdateDatabase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdateDatabase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdateDatabase.Location = new System.Drawing.Point(643, 319);
            this.buttonUpdateDatabase.Name = "buttonUpdateDatabase";
            this.buttonUpdateDatabase.Size = new System.Drawing.Size(130, 23);
            this.buttonUpdateDatabase.TabIndex = 4;
            this.buttonUpdateDatabase.Text = "Update Database";
            this.buttonUpdateDatabase.UseVisualStyleBackColor = false;
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(30, 265);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.Size = new System.Drawing.Size(583, 150);
            this.dataGridViewBookings.TabIndex = 5;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(30, 488);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(583, 150);
            this.dataGridViewReport.TabIndex = 6;
            // 
            // textBoxDestinationCode
            // 
            this.textBoxDestinationCode.Location = new System.Drawing.Point(744, 567);
            this.textBoxDestinationCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDestinationCode.Name = "textBoxDestinationCode";
            this.textBoxDestinationCode.Size = new System.Drawing.Size(93, 20);
            this.textBoxDestinationCode.TabIndex = 7;
            // 
            // labelNumberOfBookings
            // 
            this.labelNumberOfBookings.AutoSize = true;
            this.labelNumberOfBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumberOfBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfBookings.Location = new System.Drawing.Point(61, 665);
            this.labelNumberOfBookings.Name = "labelNumberOfBookings";
            this.labelNumberOfBookings.Size = new System.Drawing.Size(125, 15);
            this.labelNumberOfBookings.TabIndex = 9;
            this.labelNumberOfBookings.Text = "Number Of Bookings";
            // 
            // labelDisplayNumberOfBookings
            // 
            this.labelDisplayNumberOfBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayNumberOfBookings.Location = new System.Drawing.Point(207, 665);
            this.labelDisplayNumberOfBookings.Name = "labelDisplayNumberOfBookings";
            this.labelDisplayNumberOfBookings.Size = new System.Drawing.Size(83, 15);
            this.labelDisplayNumberOfBookings.TabIndex = 10;
            this.labelDisplayNumberOfBookings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAverageBookingCost
            // 
            this.labelAverageBookingCost.AutoSize = true;
            this.labelAverageBookingCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAverageBookingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverageBookingCost.Location = new System.Drawing.Point(393, 665);
            this.labelAverageBookingCost.Name = "labelAverageBookingCost";
            this.labelAverageBookingCost.Size = new System.Drawing.Size(135, 15);
            this.labelAverageBookingCost.TabIndex = 11;
            this.labelAverageBookingCost.Text = "Average Booking Cost";
            // 
            // labelDisplayAverageBookingCost
            // 
            this.labelDisplayAverageBookingCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayAverageBookingCost.Location = new System.Drawing.Point(544, 665);
            this.labelDisplayAverageBookingCost.Name = "labelDisplayAverageBookingCost";
            this.labelDisplayAverageBookingCost.Size = new System.Drawing.Size(84, 15);
            this.labelDisplayAverageBookingCost.TabIndex = 12;
            this.labelDisplayAverageBookingCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDestinationCode
            // 
            this.labelDestinationCode.AutoSize = true;
            this.labelDestinationCode.Location = new System.Drawing.Point(652, 570);
            this.labelDestinationCode.Name = "labelDestinationCode";
            this.labelDestinationCode.Size = new System.Drawing.Size(88, 13);
            this.labelDestinationCode.TabIndex = 13;
            this.labelDestinationCode.Text = "Destination Code";
            // 
            // labelBookingsReport
            // 
            this.labelBookingsReport.AutoSize = true;
            this.labelBookingsReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBookingsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingsReport.Location = new System.Drawing.Point(31, 439);
            this.labelBookingsReport.Name = "labelBookingsReport";
            this.labelBookingsReport.Size = new System.Drawing.Size(103, 15);
            this.labelBookingsReport.TabIndex = 15;
            this.labelBookingsReport.Text = "Bookings Report";
            // 
            // labelBookings
            // 
            this.labelBookings.AutoSize = true;
            this.labelBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookings.Location = new System.Drawing.Point(30, 224);
            this.labelBookings.Name = "labelBookings";
            this.labelBookings.Size = new System.Drawing.Size(61, 15);
            this.labelBookings.TabIndex = 16;
            this.labelBookings.Text = "Bookings";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(744, 526);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(93, 25);
            this.buttonFilter.TabIndex = 17;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // labelFlights
            // 
            this.labelFlights.AutoSize = true;
            this.labelFlights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlights.Location = new System.Drawing.Point(367, 18);
            this.labelFlights.Name = "labelFlights";
            this.labelFlights.Size = new System.Drawing.Size(46, 15);
            this.labelFlights.TabIndex = 19;
            this.labelFlights.Text = "Flights";
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.Location = new System.Drawing.Point(31, 18);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(47, 15);
            this.labelClients.TabIndex = 20;
            this.labelClients.Text = "Clients";
            // 
            // TravelBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 714);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.labelFlights);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.labelBookings);
            this.Controls.Add(this.labelBookingsReport);
            this.Controls.Add(this.labelDestinationCode);
            this.Controls.Add(this.labelDisplayAverageBookingCost);
            this.Controls.Add(this.labelAverageBookingCost);
            this.Controls.Add(this.labelDisplayNumberOfBookings);
            this.Controls.Add(this.labelNumberOfBookings);
            this.Controls.Add(this.textBoxDestinationCode);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.dataGridViewBookings);
            this.Controls.Add(this.buttonUpdateDatabase);
            this.Controls.Add(this.dataGridViewFlights);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "TravelBookingForm";
            this.Text = "Travel Booking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.TextBox textBoxDestinationCode;
        private System.Windows.Forms.Label labelNumberOfBookings;
        private System.Windows.Forms.Label labelDisplayNumberOfBookings;
        private System.Windows.Forms.Label labelAverageBookingCost;
        private System.Windows.Forms.Label labelDisplayAverageBookingCost;
        private System.Windows.Forms.Label labelDestinationCode;
        private System.Windows.Forms.Label labelBookingsReport;
        private System.Windows.Forms.Label labelBookings;
        private System.Windows.Forms.Button buttonUpdateDatabase;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelFlights;
        private System.Windows.Forms.Label labelClients;
    }
}

