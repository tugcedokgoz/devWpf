Imports Model

Public Class UserRepository
    Implements IUserRepository


    Public Sub New()
    End Sub

    Public Function Insert() As User Implements IUserRepository.Insert
        Dim context = New WpfTestContext()
    End Function

    Private Function IUserRepository_GetAll() As List(Of User) Implements IUserRepository.GetAll
        Using context = New WpfTestContext()
            Dim userList = context.Users.ToList()
            Return userList
        End Using
    End Function
End Class
