
Public Class BaseDto(Of TDtoId)
    Implements IDto

    Public Property Id As TDtoId
    Public Property CreatedBy As Long
    Public Property CreatedDate As DateTime
    Public Property UpdatedBy As Long
    Public Property UpdatedDate As DateTime
    Public Property DeletedBy As Long
    Public Property DeletedDate As DateTime
    Public Property IsActive As Boolean

End Class