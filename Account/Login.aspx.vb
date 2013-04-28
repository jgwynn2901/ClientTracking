Public Class Login
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim returnUrl = HttpUtility.UrlEncode(Request.QueryString("ReturnUrl"))
    End Sub
End Class