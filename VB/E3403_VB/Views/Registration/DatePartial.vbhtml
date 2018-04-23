@ModelType DevExpress.Razor.Models.Account

<div id="DateContent">
    @Html.DevExpress().Label( _
    Sub(editorSettings)
            editorSettings.Text = "Any Date:"
            editorSettings.AssociatedControlName = "AnyDate"
    End Sub).GetHtml()
    @Html.DevExpress().DateEdit( _
    Sub(editorSettings)
            editorSettings.Name = "AnyDate"
            editorSettings.ShowModelErrors = True
            editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
    End Sub).Bind(Model.AnyDate).GetHtml()
    <hr />
    @Html.DevExpress().Label( _
    Sub(editorSettings)
            editorSettings.Text = "States:"
            editorSettings.AssociatedControlName = "States"
    End Sub).GetHtml()
    @Html.DevExpress().ComboBox( _
    Sub(editorSettings)
            editorSettings.Name = "States"
            editorSettings.ShowModelErrors = True
            editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
            editorSettings.Properties.ValueType = GetType(String)
            editorSettings.Properties.Items.Add("Alaska", "Alaska")
            editorSettings.Properties.Items.Add("Indiana", "Indiana")
            editorSettings.Properties.Items.Add("Kentucky", "Kentucky")
            editorSettings.Properties.Items.Add("Minnesota", "Minnesota")
            editorSettings.Properties.Items.Add("Nevada", "Nevada")
    End Sub).Bind(Model.States).GetHtml()
    <hr />
    @Html.DevExpress().Button( _
    Sub(buttonSettings)
            buttonSettings.Name = "btnGoToMoreTab;"
            buttonSettings.Text = "Next"
           
            buttonSettings.ClientSideEvents.Click = "OnClickNextButton"
    End Sub).GetHtml()
</div>