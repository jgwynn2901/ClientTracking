<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ClientTracking._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
  <section class="featured">
    <div class="container-fluid">
      <div class="row-fluid">
      <img src="Content/images/logo.png" />
        </div>
      <div class="row-fluid">
        <h3>Welcome</h3>
        <p class="lead">
          Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor. Duis mollis, est non commodo luctus.     
        </p>
      </div>
    </div>

  </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
</asp:Content>
