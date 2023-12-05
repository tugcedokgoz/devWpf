Imports System.Linq.Expressions
Imports Infrastructure.Infrastructure.Models

Public Class BaseRepository(Of TEntity As {BaseEntity(Of TEntityId), New}, TEntityId)
    Implements IBaseRepsitory(Of TEntity, TEntityId)

    Public Sub Update(entity As TEntity) Implements IBaseRepsitory(Of TEntity, TEntityId).Update
        Throw New NotImplementedException()
    End Sub

    Public Sub UpdateRange(entities As ICollection(Of TEntity)) Implements IBaseRepsitory(Of TEntity, TEntityId).UpdateRange
        Throw New NotImplementedException()
    End Sub

    Public Sub Delete(entity As TEntity, Optional permanent As Boolean = False) Implements IBaseRepsitory(Of TEntity, TEntityId).Delete
        Throw New NotImplementedException()
    End Sub

    Public Sub DeleteRange(entities As ICollection(Of TEntity), Optional permanent As Boolean = False) Implements IBaseRepsitory(Of TEntity, TEntityId).DeleteRange
        Throw New NotImplementedException()
    End Sub

    Public Function [Get](Optional predicate As Expression(Of Func(Of TEntity, Boolean)) = Nothing, Optional enableTracking As Boolean = True, Optional includeList As List(Of String) = Nothing) As TEntity Implements IBaseRepsitory(Of TEntity, TEntityId).Get
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As TEntityId, Optional enableTracking As Boolean = True, Optional includeList As List(Of String) = Nothing) As TEntity Implements IBaseRepsitory(Of TEntity, TEntityId).GetById
        Throw New NotImplementedException()
    End Function

    Public Function GetList(Optional predicate As Expression(Of Func(Of TEntity, Boolean)) = Nothing, Optional orderBy As Func(Of IQueryable(Of TEntity), IOrderedQueryable(Of TEntity)) = Nothing, Optional enableTracking As Boolean = True, Optional includeList As List(Of String) = Nothing) As IQueryable(Of TEntity) Implements IBaseRepsitory(Of TEntity, TEntityId).GetList
        Throw New NotImplementedException()
    End Function

    Public Function GetCount(Optional predicate As Expression(Of Func(Of TEntity, Boolean)) = Nothing) As Long Implements IBaseRepsitory(Of TEntity, TEntityId).GetCount
        Throw New NotImplementedException()
    End Function

    Public Function Any(Optional predicate As Expression(Of Func(Of TEntity, Boolean)) = Nothing, Optional enableTracking As Boolean = True) As Boolean Implements IBaseRepsitory(Of TEntity, TEntityId).Any
        Throw New NotImplementedException()
    End Function

    Public Function Add(entity As TEntity) As TEntity Implements IBaseRepsitory(Of TEntity, TEntityId).Add
        Throw New NotImplementedException()
    End Function

    Public Function AddRange(entities As ICollection(Of TEntity)) As ICollection(Of TEntity) Implements IBaseRepsitory(Of TEntity, TEntityId).AddRange
        Throw New NotImplementedException()
    End Function
End Class