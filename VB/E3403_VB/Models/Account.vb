Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports System.Web.Script.Serialization

Namespace Models
    Public Class Account
        Private privateFirstName As String
        <Required(ErrorMessage:="First Name is required")> _
        Public Property FirstName() As String
            Get
                Return privateFirstName
            End Get
            Set(ByVal value As String)
                privateFirstName = value
            End Set
        End Property
        Private privateLastName As String
        <Required(ErrorMessage:="Last Name is required")> _
        Public Property LastName() As String
            Get
                Return privateLastName
            End Get
            Set(ByVal value As String)
                privateLastName = value
            End Set
        End Property
        Private privateIAgree As Nullable(Of Boolean)
        <Required(ErrorMessage:="I agree is required")> _
        Public Property IAgree() As Nullable(Of Boolean)
            Get
                Return privateIAgree
            End Get
            Set(ByVal value As Nullable(Of Boolean))
                privateIAgree = value
            End Set
        End Property

        Private privateAnyDate As Nullable(Of DateTime)
        <Required(ErrorMessage:="Any Date is required")> _
        Public Property AnyDate() As Nullable(Of DateTime)
            Get
                Return privateAnyDate
            End Get
            Set(ByVal value As Nullable(Of DateTime))
                privateAnyDate = value
            End Set
        End Property
        Private privateStates As String
        <Required(ErrorMessage:="States is required")> _
        Public Property States() As String
            Get
                Return privateStates
            End Get
            Set(ByVal value As String)
                privateStates = value
            End Set
        End Property

        Private privateEmail As String
        <Required(ErrorMessage:="E-mail is required"), RegularExpression("\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage:="Invalid E-Mail")> _
        Public Property Email() As String
            Get
                Return privateEmail
            End Get
            Set(ByVal value As String)
                privateEmail = value
            End Set
        End Property

        Private privateZipCode As String
        <Required(ErrorMessage:="ZIP Code is required"), RegularExpression("\d{5}(-\d{4})?", ErrorMessage:="Invalid ZIP Code")> _
        Public Property ZipCode() As String
            Get
                Return privateZipCode
            End Get
            Set(ByVal value As String)
                privateZipCode = value
            End Set
        End Property
    End Class
End Namespace