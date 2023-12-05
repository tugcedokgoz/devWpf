' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Imports System.Data.SqlClient

Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    'Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
    '    Return String.Format("You entered: {0}", value)
    'End Function

    Public Function GetData(value As GetUser) As String Implements IService1.GetData
        Dim msg As String
        Dim con As SqlConnection = New SqlConnection("Data Source =  DESKTOP-R04PVQ3\\SQLEXPRESS; Database = wpfTest; Trusted_Connection = true; TrustServerCertificate = true;")
        Dim com As SqlCommand = New SqlCommand("Select * From tblUser", con)

        Dim da As SqlDataAdapter = New SqlDataAdapter(com)



    End Function

End Class
