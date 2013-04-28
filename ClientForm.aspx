<%@ Page Title="Edit Client" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="ClientForm.aspx.vb" Inherits="ClientTracking.ClientForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <div class="span5">
    <div class="control-group">
      <label class="control-label" for="lastName">Name</label>
      <div class="controls">
        <asp:TextBox runat="server" class="input-medium" id="lastName" placeholder="Last Name"></asp:TextBox>
        <asp:TextBox runat="server" class="input-mini" id="middleName" placeholder="Mid"></asp:TextBox>
        <asp:TextBox runat="server" class="input-small" id="firstName" placeholder="First Name"></asp:TextBox>
      </div>
    </div>
    <div class="control-group">
      <label class="control-label" for="address">Address</label>
      <div class="controls">
        <asp:TextBox runat="server" class="input-xlarge" id="address" placeholder="Address"></asp:TextBox>
      </div>
    </div>
    <div class="control-group">
      <label class="control-label" for="address">City, State Zip</label>
      <div class="controls">
        <asp:TextBox runat="server" class="input-medium" id="city" placeholder="City"></asp:TextBox>
        <asp:TextBox runat="server" class="input-mini" id="state" placeholder="State"></asp:TextBox>
        <asp:TextBox runat="server" type="number" class="input-small" id="zip" placeholder="Zip"></asp:TextBox>
      </div>
    </div>
    <div class="control-group">
      <label class="control-label" for="phoneHome">Phone</label>
      <div class="controls">
        <asp:TextBox runat="server" type="tel" class="input-medium" id="homePhone" placeholder="Home"></asp:TextBox>
        <asp:TextBox runat="server" type="tel" class="input-medium" id="cellPhone" placeholder="Cell"></asp:TextBox>
      </div>
    </div>
    <div class="control-group">
      <label class="control-label" for="employer">Treament Location</label>
      <div class="controls">
        <asp:TextBox runat="server" class="input-mini" id="treatmentLocation"></asp:TextBox><span class="help-inline">C for Cambridge, R for Roxbury</span>
      </div>
    </div>
  </div>
  <div class="span4">
    <div class="control-group">
      <label class="control-label" for="address">Email Address</label>
      <div class="controls">
        <asp:TextBox runat="server" type="email" class="input-large" id="emailAddress" placeholder="Email"></asp:TextBox>
      </div>
    </div>
    <div class="control-group">
      <label class="control-label" for="dateOfBirth">Date of Birth,&nbsp;&nbsp;&nbsp;# of Children</label>
      <div class="controls">
        <asp:TextBox runat="server" type="date" class="input-small" id="dateOfBirth"></asp:TextBox>
        <asp:TextBox runat="server" type="number" class="input-mini" id="numberOfChildren"></asp:TextBox>
      </div>
    </div>
    <div class="control-group">
      <label class="control-label" for="employer">Employer</label>
      <div class="controls">
        <asp:TextBox runat="server" class="input-large" id="employer"></asp:TextBox>
      </div>
    </div>
    <div class="control-group">
      <label class="control-label" for="language">Language</label>
      <div class="controls">
         <asp:DropDownList runat="server" class="input-large" id="language"></asp:DropDownList>
      </div>
    </div>
    <div class="control-group">
      <label class="control-label" for="race">Race</label>
      <div class="controls">
        <asp:DropDownList runat="server" class="input-large" id="race"></asp:DropDownList>
      </div>
    </div>
  </div>
  <div class="span3">
    <div class="control-group">
      <label class="control-label" for="race">Notes</label>
      <div class="controls">
        <textarea class="input-large" id="notes"></textarea>
      </div>
    </div>
    <div class="control-group">
      <label class="control-label" for="race">Status</label>
      <div class="controls">
        <asp:DropDownList runat="server" class="input-large" id="status"></asp:DropDownList>
      </div>
    </div>
  </div>
  <div class="span12">
    <button type="submit" class="btn btn-primary">Save changes</button>
    <button type="button" class="btn">Cancel</button>

  </div>
</asp:Content>

