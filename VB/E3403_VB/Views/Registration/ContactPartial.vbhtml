@ModelType DevExpress.Razor.Models.Account

<div id="ContactContent">
    @Html.DevExpress().Label( _
    Sub(editorSettings)
            editorSettings.Text = "E-Mail:"
            editorSettings.AssociatedControlName = "Email"
    End Sub).GetHtml()
    @Html.DevExpress().TextBox( _
    Sub(editorSettings)
            editorSettings.Name = "Email"
            editorSettings.ShowModelErrors = True
            editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
            editorSettings.ControlStyle.CssClass = "editor"
    End Sub).Bind(Model.Email).GetHtml()
    <hr />
    @Html.DevExpress().Label( _
    Sub(editorSettings)
            editorSettings.Text = "Zip-Code:"
            editorSettings.AssociatedControlName = "ZipCode"
    End Sub).GetHtml()
    @Html.DevExpress().TextBox( _
    Sub(editorSettings)
            editorSettings.Name = "ZipCode"
            editorSettings.ShowModelErrors = True
            editorSettings.ControlStyle.CssClass = "editor"
    End Sub).Bind(Model.ZipCode).GetHtml()
    <hr />
    @Html.DevExpress().Button( _
    Sub(buttonSettings)
            buttonSettings.Name = "btnFinish;"
            buttonSettings.Text = "Finish"
            buttonSettings.ClientSideEvents.Click = "OnSubmitForm"           
    End Sub).GetHtml()
</div>