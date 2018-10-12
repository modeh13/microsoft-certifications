Public Class UnderstadingPageEvents
   Inherits System.Web.UI.Page

#Region "Start stage (PAGE EVENTS)"
   'Each EVENT have a method in the Base class that It's in charge of trigger them.
   'Methods
   'OnPreInit, OnInit, OnInitComplete

   'Request, Response, IsPostBack y UICulture are established at this STAGE.
   Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("-- BEGIN 'START' STAGE <br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("Written message from Page_PreInit.<br/>")
   End Sub

   'All controls in the Page are initialized and available.
   Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
      Response.Write("Written message from Page_Init.<br/>")
   End Sub

   Protected Overrides Sub TrackViewState()
      MyBase.TrackViewState()
      Response.Write("Written message from TrackViewState method.<br/>")
   End Sub

   Protected Sub Page_InitComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.InitComplete
      Response.Write("Written message from Page_InitComplete.<br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("-- END 'START' STAGE <br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
   End Sub
#End Region

   'LOAD THE VIEWSTATE AND CONTROL STATE (Page_LoadViewState method)
   'PROCESS THE POSTDATA

#Region "Load stage (PAGE EVENTS)"
   'Methods
   'OnPreLoad, OnLoad

   Protected Overrides Sub LoadViewState(savedState As Object)
      MyBase.LoadViewState(savedState)
   End Sub

   Protected Sub Page_PreLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreLoad
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("-- BEGIN 'LOAD' STAGE <br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("Written message from LoadViewState method.<br/>")
      Response.Write("Written message from ProcessPostBackData method.<br/>")
      Response.Write("Written message from Page_PreLoad.<br/>")
   End Sub

   Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Response.Write("Written message from Page_Load.<br/>")
      DataBind() 'This call is needed to BIND the variables into USER_CONTROLS
   End Sub
#End Region

   'These are intermediate phases that they are executed between LOAD and PRERENDERING stages.
   'CONTROL-CHANGED EVENTS
   'VALIDATIONS
   'RAISE POSTBACKEVENT

#Region "PreRendering stage (PAGE EVENTS)"
   'It is the last point to be able to modify the OutputStream

   'Methods
   'OnLoadComplete, OnPreRender, OnPreRenderComplete
   Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("-- END 'LOAD' STAGE <br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("Control-changed events have been executed.<br/>")
      Response.Write("Validations events have been executed.<br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("-- BEGIN 'PRERENDERING' STAGE <br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("Written message from Page_LoadComplete.<br/>")
   End Sub

   Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
      Response.Write("Written message from Page_PreRender.<br/>")
   End Sub

   Protected Sub Page_PreRenderComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRenderComplete
      Response.Write("Data-bindings-events have been executed.<br/>")
      Response.Write("Written message from Page_PreRenderComplete.<br/>")
   End Sub

   Protected Overrides Function SaveViewState() As Object
      Return MyBase.SaveViewState()
      Response.Write("Written message from Page_SaveViewState method.<br/>")
   End Function

   Protected Sub Page_SaveStateComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SaveStateComplete
      Response.Write("Written message from Page_SaveStateComplete.<br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("-- END 'PRERENDERING' STAGE <br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
      Response.Write("-- BEGIN 'PRERENDER' STAGE <br/>")
      Response.Write("-- -- -- -- -- -- -- -- -- -- -- -<br/>")
   End Sub
#End Region

#Region "Rendering stage"
   'It is stage tha page calls for each control and execute the Render method to get the OutputStream of Control.

   Public Overrides Sub RenderControl(writer As HtmlTextWriter)
      MyBase.RenderControl(writer)
      Response.Write("Written message from RenderControl method.<br/>")
   End Sub

   Protected Overrides Sub Render(writer As HtmlTextWriter)
      MyBase.Render(writer)
      Response.Write("Written message from Render method.<br/>")
   End Sub

   Protected Overrides Sub RenderChildren(writer As HtmlTextWriter)
      MyBase.RenderChildren(writer)
      Response.Write("Written message from RenderChildren method.<br/>")
   End Sub
#End Region

#Region "Unload stage"
   'It is stage tha page calls for each control and execute the Render method to get the OutputStream of Control.
   'Methods
   'OnUnload

   Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
      'The Request and Response objects are not accessible
   End Sub
#End Region
End Class