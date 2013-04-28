Imports emergeRepository

Public Class ClientForm
  Inherits System.Web.UI.Page

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

  Private Sub PopulateDropDown(sender As Global.System.Web.UI.WebControls.DropDownList, ByRef list As List(Of String))
    Dim count = 0
    For Each item As String In list
      count = count + 1
      sender.Items.Add(New ListItem(item, count.ToString()))
    Next
  End Sub

  Private Sub SearchById(emergeId As Integer)
    Dim client = New ClientRepository().FindById(emergeId)
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

  Private Sub SetSelectedItemFromDescription(list As Global.System.Web.UI.WebControls.DropDownList, item As String)
    If item <> "" Then
      Dim index As Integer = 0
      For Each record As ListItem In list.Items
        index = index + 1
        If record.Text = item Then
          list.SelectedValue = index.ToString
          Exit For
        End If

      Next
    End If
  End Sub

End Class