<!DOCTYPE HTML>
<html>
<head>
    <title>@ViewData("Title")</title>
    @Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout})
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
  
    @Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.Editors}, New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout})
</head>
<body>
    @RenderBody()
</body>
</html>