Public Class Defaul
   Inherits System.Web.UI.Page

   Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      If Not IsNothing(Session.Item("user_name")) Then
         lblUserName.Text = Session("user_name").ToString()
      Else
         Response.Redirect("Register.aspx")
      End If
   End Sub

   Protected Sub btnClearSession_Click(sender As Object, e As EventArgs)
      Session.Remove("user_name")
      Response.Redirect("Register.aspx")
   End Sub
End Class