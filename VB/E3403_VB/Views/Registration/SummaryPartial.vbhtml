@Html.DevExpress().PopupControl( _
    Sub(settings)
            settings.Name = "pcSummary"
            settings.HeaderText = "Summary"
            settings.PopupElementID = "popupAnchor"
            settings.ShowOnPageLoad = True
            settings.CloseAction = CloseAction.CloseButton
            settings.SetContent(ViewData("AccountData").ToString())
    End Sub).GetHtml()