Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports System.ComponentModel
Imports System.Reflection
Imports DevExpress.Razor.Models

Namespace DevExpress.Razor.Controllers
    Public Class RegistrationController
        Inherits Controller
        Private Property IsChangeShowTabsProperty() As Boolean
            Get
                Dim value As Boolean = False
                If Session("ShowTabs") IsNot Nothing Then
                    value = Convert.ToBoolean(Session("ShowTabs"))
                End If
                Return value
            End Get
            Set(ByVal value As Boolean)
                Session("ShowTabs") = value
            End Set
        End Property
        Public Function Index(ByVal showTabs As String) As ActionResult

            Return Wizard("true")
        End Function
        <HttpGet> _
        Public Function Wizard(ByVal showTabs As String) As ActionResult
            If (Not String.IsNullOrWhiteSpace(showTabs)) Then
                IsChangeShowTabsProperty = Convert.ToBoolean(showTabs)
                ViewData("ShowTabs") = IsChangeShowTabsProperty
            End If
            Return View("Wizard", New Account())
        End Function
        <HttpPost> _
        Public Function Wizard(ByVal account As Account) As ActionResult
            If ModelState.IsValid Then
                ViewData("AccountData") = GetAccountHtmlString(account)
            End If
            ViewData("ShowTabs") = IsChangeShowTabsProperty
            Return View("Wizard", account)
        End Function

        Private Function GetAccountHtmlString(ByVal account As Account) As String
            Return String.Format("<b>Personal Info:</b><br />{0}<br />{1}<hr />", account.FirstName, account.LastName) + String.Format("<b>Date Info:</b><br />{0}<br />{1}<hr />", account.AnyDate.Value, account.States) + String.Format("<b>Contact Info:</b><br />{0}<br />{1}<hr />", account.Email, account.ZipCode)
        End Function
    End Class
End Namespace
