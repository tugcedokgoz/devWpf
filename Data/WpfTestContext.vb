Imports System.Configuration
Imports System.Data.Entity
Imports Microsoft.VisualBasic.ApplicationServices
Imports Model

Public Class WpfTestContext
    Inherits DbContext

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("contextPath").ConnectionString)
        Database.SetInitializer(Of WpfTestContext)(Nothing)
    End Sub



    Public Property Users As DbSet(Of Model.User)
End Class
