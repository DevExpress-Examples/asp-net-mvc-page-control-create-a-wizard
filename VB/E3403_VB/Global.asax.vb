' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
' visit http://go.microsoft.com/?LinkId=9394802

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
        filters.Add(New HandleErrorAttribute())
    End Sub

    Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        ' MapRoute takes the following parameters, in order:
        ' (1) Route name
        ' (2) URL with parameters
        ' (3) Parameter defaults
        routes.MapRoute("Default", "{controller}/{action}/{id}", New With {Key .controller = "Registration", Key .action = "Index", Key .id = UrlParameter.Optional})
    End Sub

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        ModelBinders.Binders.DefaultBinder = New Global.DevExpress.Web.Mvc.DevExpressEditorsBinder()
        RegisterGlobalFilters(GlobalFilters.Filters)
        RegisterRoutes(RouteTable.Routes)
    End Sub
End Class
