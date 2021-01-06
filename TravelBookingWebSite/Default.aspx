<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TravelBookingWebSite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="default" runat="server">
        View Clients
        <div>
            <%-- add your code here to the GridView definition to identify select/update/delete methods --%>
            <asp:GridView ID="clientsGridView" runat="server"
                ItemType="TravelBookingCodeFirstFromDB.Client"
                DataKeyNames="ClientId"
                SelectMethod="GetClients"
                UpdateMethod="GridViewClient_UpdateItem"
                DeleteMethod ="GridViewClient_DeleteItem"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="ClientId" HeaderText="ClientId" ReadOnly="true" />
                    <asp:BoundField DataField="ClientName" HeaderText="Client Name" />
                </Columns>
            </asp:GridView>
        </div>
        <p>
            Add a client
        </p>
        <div>
            Client Name
            <asp:TextBox ID="textBoxClientName" runat="server"></asp:TextBox>
        </div>
        <div>
            <%-- add your code to the Button definition to identify onclick handler method --%>
            <asp:Button ID="buttonAddClient" runat="server" Text="Add Client" OnClick="ButtonAddClient_Click"/>
        </div>
        <p></p>
        <div>
            Status Message: 
            <asp:Label ID="labelClientStatus" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
