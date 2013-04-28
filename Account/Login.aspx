<%@ Page Title="Log in" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.vb" Inherits="ClientTracking.Login" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
  <div class="row-fluid">
    <section id="loginForm">
      <div class="span12">
        <div class="form-signin">
        <h2 class="form-signin-heading">Please log in</h2>

        <asp:TextBox runat="server" class="input-block-level" ID="UserName" placeholder="username" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />

        <asp:TextBox runat="server" class="input-block-level" ID="Password" placeholder="username" TextMode="Password" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="The password field is required." />


        <asp:Button runat="server" class="btn btn-primary inline" CommandName="Login" Text="Log in" />
          </div>
      </div>
    </section>
  </div>
</asp:Content>
