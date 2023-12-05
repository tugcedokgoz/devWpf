Namespace Infrastructure.Models

    Public Class BaseEntity(Of TEntityId)
        Public Property Id As TEntityId
        Public Property CreatedBy As Long
        Public Property CreatedDate As DateTime
        Public Property UpdatedBy As Long?
        Public Property UpdatedDate As DateTime?
        Public Property DeletedBy As Long?
        Public Property DeletedDate As DateTime?
        Public Property IsActive As Boolean = True
    End Class

End Namespace