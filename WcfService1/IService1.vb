' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function GetData(value As GetUser) As String


End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.

<DataContract()>
Public Class GetUser

    <DataMember()>
    Public Property Name As String

    <DataMember()>
    Public Property Email As String

    <DataMember()>
    Public Property Phone As String

End Class

<DataContract()>
Public Class InsertUser

    <DataMember()>
    Public Property Name As String

    <DataMember()>
    Public Property Email As String

    <DataMember()>
    Public Property Phone As String

End Class


<DataContract()>
Public Class UpdateUser

    <DataMember()>
    Public Property Name As String

    <DataMember()>
    Public Property Email As String

    <DataMember()>
    Public Property Phone As String

End Class
