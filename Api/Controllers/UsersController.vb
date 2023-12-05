Imports System.Net
Imports System.Web.Helpers
Imports System.Web.Http
Imports Data
Imports Microsoft.Ajax.Utilities
Imports Newtonsoft.Json

Public Class UsersController
    Inherits ApiController

    ' GET api/values
    Public Function GetValues() As IHttpActionResult
        Dim userRepository As IUserRepository = New UserRepository()
        Dim users = userRepository.GetAll()
        Dim response = JsonConvert.SerializeObject(users)
        Return Ok(response)
    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/values
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
