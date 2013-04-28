Imports emergeRepository

Public Class ClientForm
  Inherits System.Web.UI.Page

  ''' <summary>
  ''' Handles the Load event of the Page control.
  ''' </summary>
  ''' <param name="sender">The source of the event.</param>
  ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    If Not IsPostBack Then
      PopulateDropDown(Me.language, ClientRepository.GetLanguage())
      PopulateDropDown(Me.status, ClientRepository.GetActiveStatus())
      PopulateDropDown(Me.race, ClientRepository.GetRace())
    End If
    Dim searchId As Global.System.Web.UI.WebControls.TextBox = Me.Master.FindControl("emergeId")
    If searchId.Text <> "" Then
      SearchById(searchId.Text)
      searchId.Text = ""
    End If

  End Sub

  ''' <summary>
  ''' Populates the drop down.
  ''' </summary>
  ''' <param name="sender">The sender.</param>
  ''' <param name="list">The list of values.</param>
  Private Sub PopulateDropDown(sender As Global.System.Web.UI.WebControls.DropDownList, ByRef list As List(Of String))
    Dim count = 0
    sender.Items.Clear()
    sender.Items.Add(New ListItem("Select", count.ToString()))

    For Each item As String In list
      count = count + 1
      sender.Items.Add(New ListItem(item, count.ToString()))
    Next
  End Sub

  ''' <summary>
  ''' Searches client by the by emergeId.
  ''' </summary>
  ''' <param name="emergeId">The emerge id.</param>
  Private Sub SearchById(emergeId As Integer)
    Dim client = New ClientRepository().FindById(emergeId)
    Me.clientPk.Value = client.PkbipcLients.ToString()
    Me.lastName.Text = client.LastName
    Me.firstName.Text = client.FirstName
    Me.middleName.Text = client.MiddleInitial
    Me.address.Text = client.Address
    Me.city.Text = client.City
    Me.state.Text = client.State
    Me.zip.Text = client.Zip
    Me.homePhone.Text = client.HomePhone
    Me.cellPhone.Text = client.CellPhone
    Me.treatmentLocation.Text = client.TrtmntLoc
    Me.emailAddress.Text = client.EMail
    If client.Dob.HasValue Then
      Me.dateOfBirth.Text = client.Dob
    Else
      Me.dateOfBirth.Text = ""
    End If
    Me.numberOfChildren.Text = client._cHildren
    Me.employer.Text = client.Employer
    SetSelectedItemFromDescription(Me.language, client.Language)
    SetSelectedItemFromDescription(Me.race, client.Race)
    SetSelectedItemFromDescription(Me.status, client.Status)
    Me.notes.Text = client.Notes

  End Sub

  ''' <summary>
  ''' Sets the dropdown's selected item from description.
  ''' </summary>
  ''' <param name="list">The list.</param>
  ''' <param name="item">The item.</param>
  Private Sub SetSelectedItemFromDescription(list As Global.System.Web.UI.WebControls.DropDownList, item As String)
    If item <> "" Then
      Dim index As Integer = 0
      For Each record As ListItem In list.Items
        If record.Text = item Then
          list.SelectedValue = index.ToString
          Exit For
        End If
        index = index + 1
      Next
    End If
  End Sub
  
  ''' <summary>
  ''' Handles the Click event of the SaveChanges control.
  ''' </summary>
  ''' <param name="sender">The source of the event i.e. the submit button.</param>
  ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
  Protected Sub SaveChanges_Click(sender As Object, e As EventArgs) Handles submit.Click
    Dim client As BipClients
    Dim repo = New ClientRepository()
    Dim isInsert = False


    If Me.clientPk.Value = "" Then
      ' TODO: add code for update here i.e. get record by PK and copy form data then save changes
      client = New BipClients()
      client.PkbipcLients = ClientRepository.GetMaxPrimaryKey + 1
      isInsert = True
    Else
      client = repo.FindByPk(Integer.Parse(clientPk.Value))
    End If
    client.LastName = Me.lastName.Text
    client.FirstName = Me.firstName.Text
    client.MiddleInitial = Me.middleName.Text
    client.Address = Me.address.Text
    client.City = Me.city.Text
    client.State = Me.state.Text
    client.Zip = Me.zip.Text
    client.HomePhone = Me.homePhone.Text
    client.CellPhone = Me.cellPhone.Text
    client.TrtmntLoc = Me.treatmentLocation.Text
    client.EMail = Me.emailAddress.Text
    client.Notes = Me.notes.Text

    If isInsert Then
      repo.InsertOnSubmit(client)
    End If
    repo.SubmitChanges()

  End Sub
End Class