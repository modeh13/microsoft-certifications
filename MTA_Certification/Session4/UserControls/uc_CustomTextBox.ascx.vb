Public Class uc_CustomTextBox
   Inherits System.Web.UI.UserControl

   Public Property LabelText() As String

   Private _TextBoxText As String
   Public Property TextBoxText() As String
      Get
         Return _TextBoxText
      End Get
      Set(ByVal value As String)
         _TextBoxText = value
      End Set
   End Property

#Region "START"
   Protected Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
      Response.Write("Written message from Control_Init.<br/>")
   End Sub
#End Region

#Region "LOAD"
   Protected Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Response.Write("Written message from Control_Load.<br/>")
   End Sub
#End Region

#Region "PRERENDERING"
   Protected Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
      Response.Write("Written message from Control_PreRender.<br/>")
   End Sub

   Protected Overrides Function SaveViewState() As Object
      Return MyBase.SaveViewState()
      Response.Write("Written message from Control_SaveViewState method.<br/>")
   End Function
#End Region

#Region "RENDER"
   Public Overrides Sub RenderControl(writer As HtmlTextWriter)
      MyBase.RenderControl(writer)
      Response.Write("Written message from Control_RenderControl method.<br/>")
   End Sub

   Protected Overrides Sub RenderChildren(writer As HtmlTextWriter)
      MyBase.RenderChildren(writer)
      Response.Write("Written message from Control_RenderChildren method.<br/>")
   End Sub

   Protected Overrides Sub Render(writer As HtmlTextWriter)
      MyBase.Render(writer)
      Response.Write("Written message from Control_Render method.<br/>")
   End Sub
#End Region

#Region "UPLOAD"
   Protected Sub Control_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
      'The Request and Response objects are not accessible
   End Sub
#End Region
End Class