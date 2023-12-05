Imports System.Linq.Expressions
Imports Infrastructure.Infrastructure.Models



Public Interface IBaseRepsitory(Of TEntity As {BaseEntity(Of TEntityId), New}, TEntityId)
    Function [Get](
        Optional predicate As Expression(Of Func(Of TEntity, Boolean)) = Nothing,
        Optional enableTracking As Boolean = True,
        Optional includeList As List(Of String) = Nothing
    ) As TEntity

    Function GetById(
        id As TEntityId,
        Optional enableTracking As Boolean = True,
        Optional includeList As List(Of String) = Nothing
    ) As TEntity

    Function GetList(
        Optional predicate As Expression(Of Func(Of TEntity, Boolean)) = Nothing,
        Optional orderBy As Func(Of IQueryable(Of TEntity), IOrderedQueryable(Of TEntity)) = Nothing,
        Optional enableTracking As Boolean = True,
        Optional includeList As List(Of String) = Nothing
    ) As IQueryable(Of TEntity)

    Function GetCount(Optional predicate As Expression(Of Func(Of TEntity, Boolean)) = Nothing) As Long

    Function Any(Optional predicate As Expression(Of Func(Of TEntity, Boolean)) = Nothing, Optional enableTracking As Boolean = True) As Boolean

    Function Add(entity As TEntity) As TEntity

    Function AddRange(entities As ICollection(Of TEntity)) As ICollection(Of TEntity)

    Sub Update(entity As TEntity)

    Sub UpdateRange(entities As ICollection(Of TEntity))

    Sub Delete(entity As TEntity, Optional permanent As Boolean = False)

    Sub DeleteRange(entities As ICollection(Of TEntity), Optional permanent As Boolean = False)
End Interface
