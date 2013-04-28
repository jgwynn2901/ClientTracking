Imports emergeRepository

Public Class ClientForm
  Inherits System.Web.UI.Page

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    If Not IsPostBack Then
      PopulateDropDown(Me.language, ClientRepository.GetLanguage())
      PopulateDropDown(Me.status, ClientRepository.GetActiveStatus())
      PopulateDropDown(Me.race, ClientRepository.GetRace())
    End If

  End Sub

  Private Sub PopulateDropDown(sender As Global.System.Web.UI.WebControls.DropDownList, ByRef list As List(Of String))
    Dim count = 0
    For Each item As String In list
      count = count + 1
      sender.Items.Add(New ListItem(item, count.ToString()))
    Next
  End Sub



  Protected Sub status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status.SelectedIndexChanged

  End Sub
End Class