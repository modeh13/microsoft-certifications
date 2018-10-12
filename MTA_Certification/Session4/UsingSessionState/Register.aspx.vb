Public Class Register
   Inherits System.Web.UI.Page

   Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      If Not IsNothing(Session.Item("user_name")) Then
         Response.Redirect("Default.aspx")
      End If

      DataBind()
   End Sub

   Protected Sub btnSubmit_Click(sender As Object, e As EventArgs)
      Session.Add("user_name", txtName.Text.Trim)
      'Session("user_name") = txtName.Text.Trim
      Response.Redirect("Default.aspx")
   End Sub
End Class