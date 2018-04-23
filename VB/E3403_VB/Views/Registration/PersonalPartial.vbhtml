@ModelType DevExpress.Razor.Models.Account
      
<div id="PersonalContent">
    @Html.DevExpress().Label( _
    Sub(editorSettings)
            editorSettings.Text = "First Name:"
            editorSettings.AssociatedControlName = "FirstName"
    End Sub).GetHtml()
    @Html.DevExpress().TextBox( _
    Sub(editorSettings)
            editorSettings.Name = "FirstName"
            editorSettings.ShowModelErrors = True
            editorSettings.ControlStyle.CssClass = "editor"
            editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
    End Sub).Bind(Model.FirstName).GetHtml()
    <hr />
    @Html.DevExpress().Label( _
    Sub(editorSettings)
            editorSettings.Text = "Last Name:"
            editorSettings.AssociatedControlName = "LastName"
    End Sub).GetHtml()
    @Html.DevExpress().TextBox( _
    Sub(editorSettings)
            editorSettings.Name = "LastName"
            editorSettings.ShowModelErrors = True
            editorSettings.ControlStyle.CssClass = "editor"
            editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
    End Sub).Bind(Model.LastName).GetHtml()
    <hr />
    @Html.DevExpress().CheckBox( _
    Sub(editorSettings)
            editorSettings.Name = "IAgree"
            editorSettings.Text = "I agree"
            editorSettings.ShowModelErrors = True
            editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
    End Sub).Bind(Model.IAgree).GetHtml()
    <hr />    
    @Html.DevExpress().Button( _
    Sub(buttonSettings)
            buttonSettings.Name = "btnGoToContactTab;"
            buttonSettings.Text = "Next"
            buttonSettings.ClientSideEvents.Click = "OnClickNextButton"
    End Sub).GetHtml()
</div>