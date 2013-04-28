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
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean vel massa quis tellus luctus consectetur eget et ante. Sed mauris elit, sollicitudin a placerat in, rutrum nec nisi. Nam consectetur hendrerit risus, ultricies laoreet turpis dapibus ac. Praesent faucibus pulvinar arcu. Phasellus vestibulum leo tempus justo egestas posuere. Nunc nec erat non dolor eleifend adipiscing eu et arcu. In hac habitasse platea dictumst. Morbi tincidunt neque a odio porta at dictum turpis dictum. Cras vel enim vitae orci euismod sodales at ullamcorper ligula. Vivamus pellentesque dignissim purus, sed malesuada leo tempor sed. Pellentesque eu nisi dolor, vel convallis nibh. Nulla id augue dui. Aenean laoreet ante ac justo porta congue. Quisque vel libero vitae ipsum fringilla porta sed a erat. </p>
      </div>
    </div>

  </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
  <script src="Scripts/default.js"></script>
</asp:Content>
