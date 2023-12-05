Imports Microsoft.VisualBasic.ApplicationServices
Imports Model

Public Interface IUserRepository
    Function GetAll() As List(Of Model.User)
    Function Insert() As Model.User
End Interface
