<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Customer.aspx.cs" Inherits="Web.Customer" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
        <form>
          <div class="form-group row">
              <br />
              <br />
              <br />
              <asp:Label for="tb_Name" ID="lbl_Name" runat="server" Text="Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Name" runat="server" class="form-control" placeholder="Please enter the name of the customer"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_zipcode" ID="lbl_zipcode" runat="server" Text="Zipcode" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_zipcode" runat="server" class="form-control" placeholder="Enter zipcode"></asp:TextBox>
            </div>
          </div>

           <div class="form-group row">
              <asp:Label for="tb_email" ID="email" runat="server" Text="Email" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_email" runat="server" class="form-control" placeholder="xyz@gmail.com"></asp:TextBox>
            </div>
          </div>

          <div class="form-group row">
              <asp:Label for="tb_username" ID="username" runat="server" Text="Username" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_username" runat="server" class="form-control" placeholder="Enter your username"></asp:TextBox>
            </div>
          </div>

           <div class="form-group row">
              <asp:Label for="tb_pwd" ID="pwd" runat="server" Text="Password" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_pwd" runat="server" class="form-control" placeholder="************"></asp:TextBox>
            </div>
          </div>

           <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="addCustomer" class="btn btn-primary" runat="server" Text="Add" OnClick="btn_Add_Click" />
                <br />
                <br />
            </div>
              <asp:GridView ID="GridView2" runat="server" BackColor="WhiteSmoke" Width="237px"> </asp:GridView>

          </div>

    </form>
    </div>
</asp:Content>