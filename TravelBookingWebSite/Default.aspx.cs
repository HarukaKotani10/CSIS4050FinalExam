using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelBookingCodeFirstFromDB;

namespace TravelBookingWebSite
{
    public partial class Default : System.Web.UI.Page
    {
        private static bool dbInitialized = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(dbInitialized == false)
            {
                using (TravelBookingEntities context = new TravelBookingEntities())
                {
                    context.CreateDatabase();
                    context.SeedData();
                }
                dbInitialized = true;
            }
        }

        /// <summary>
        /// Get all client
        /// </summary>
 
        public IEnumerable<Client> GetClients()
        {
            TravelBookingEntities context = new TravelBookingEntities();
            return context.Clients.ToList();
        }

        /// <summary>
        /// Add a client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonAddClient_Click(object sender, EventArgs e)
        {
            using (TravelBookingEntities context = new TravelBookingEntities())
            {
                Client client = new Client
                {
                    ClientName = textBoxClientName.Text,
                   
                };

                context.Clients.Add(client);
                context.SaveChanges();
            }

              clientsGridView.DataBind();

        }

        /// <summary>
        /// Delete the client 
        /// </summary>
        /// <param name="clientId">Inventory key - CarId</param>
        public void GridViewClient_DeleteItem(int clientId)
        {
            using (TravelBookingEntities context = new TravelBookingEntities())
            {
                Client item = context.Clients.Find(clientId);

                context.Clients.Remove(item);
                context.SaveChanges();

            }
        }

        /// <summary>
        /// Update an item from gridview.
        /// </summary>
        /// <param name="clientId">
        public void GridViewClient_UpdateItem(int clientId)
        {
            using (TravelBookingEntities context = new TravelBookingEntities())
            {
                Client item = context.Clients.Find(clientId);
                //listBoxThings.Items.Add(item.ToString());

                if (item == null)
                {
                    // The item wasn't found
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", clientId));
                    return;
                }

                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    // everthing is ok, so save the changes and update the filter list
                    context.SaveChanges();
                }
            
            }
        }

    }
}