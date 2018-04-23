@ModelType DevExpress.Razor.Models.Account
@Functions
    Private Function GetEditorsNames() As String
        Dim result As String = String.Empty
        For Each [property] In ViewData.ModelMetadata.Properties
            If (Not String.IsNullOrEmpty(result)) Then
                result &= ","
            End If
            result &= String.Format("'{0}'", [property].PropertyName)
        Next [property]
        Return String.Format("[{0}]", result)
    End Function
    
    Private ReadOnly Property ShowTabs() As Boolean
        Get
            Return If(ViewData("ShowTabs") Is Nothing, True, CBool(ViewData("ShowTabs")))
        End Get
    End Property
End Functions
<script type="text/javascript">
    function OnSubmitForm(s, e) {
        if ($("#validateForm").valid())
            $("#validateForm").submit();      
    }
    function OnClickNextButton(s, e) {
        var indexTab = pageControl.GetActiveTabIndex();
        if ($("#validateForm").valid())
            pageControl.SetActiveTabIndex(indexTab + 1);
    }
    function OnTabChanging(s, e) {
        e.cancel = !$("#validateForm").valid();
    }
    function OnCheckedChanged(s, e) {
        window.location.href = "@Url.Action("Wizard", "Registration")" + "?showTabs=" + s.GetValue();
    }
</script>
<div style="float: left">
    @Using (Html.BeginForm("Wizard", "Registration", FormMethod.Post, New With {.id = "validateForm"}))
        @Html.DevExpress().CheckBox( _
        Sub(settings)
            settings.Name = "ShowTabs"
            settings.Text = "Show Tabs"
            settings.Properties.ClientSideEvents.ValueChanged = "OnCheckedChanged"
        End Sub).Bind(ShowTabs).GetHtml()
        @<br />
        @Html.DevExpress().PageControl( _
        Sub(settings)
            settings.Name = "pageControl"
            settings.EnableClientSideAPI = True
            settings.ClientSideEvents.ActiveTabChanging = "OnTabChanging"
            settings.Width = System.Web.UI.WebControls.Unit.Pixel(350)
            settings.ShowTabs = ShowTabs
        
            settings.TabPages.Add("Personal").SetContent( _
                Function()
                    Html.RenderPartial("PersonalPartial", Model)
                    Return Nothing
                End Function)

            settings.TabPages.Add("Date").SetContent( _
                Function()
                    Html.RenderPartial("DatePartial", Model)
                    Return Nothing
                End Function)
            
            settings.TabPages.Add("Contact").SetContent( _
                Function()
                    Html.RenderPartial("ContactPartial", Model)
                    Return Nothing
                End Function)
        End Sub).GetHtml()
    End Using
</div>
<div id="popupAnchor" style="float: left; margin-left: 5px">
</div>
@If (ViewData("AccountData") IsNot Nothing) Then
    @Html.Partial("SummaryPartial")
End If