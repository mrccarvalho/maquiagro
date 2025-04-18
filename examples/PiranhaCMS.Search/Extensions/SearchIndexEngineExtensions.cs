﻿using PiranhaCMS.Search.Engine;
using PiranhaCMS.Search.Models.Base;
using PiranhaCMS.Search.Models.Internal;
using System.Linq.Expressions;

namespace PiranhaCMS.Search.Extensions;

public static class SearchIndexEngineExtensions
{
    public static string GetFieldName<T>(this ISearchIndexEngine<T> engine, Expression<Func<T, string>> expr) where T : IDocument
    {
        if (expr.Body is not MemberExpression memberExpression)
            throw new ArgumentException($"The provided expression contains a {expr.GetType().Name} which is not supported. Only simple member accessors (fields, properties) of an object are supported.");

        return GetFieldName<T>(memberExpression.Member.Name);
    }

    public static string GetFieldName<T>(this ISearchIndexEngine<T> engine, Expression<Func<T, int>> expr) where T : IDocument
    {
        if (expr.Body is not MemberExpression memberExpression)
            throw new ArgumentException($"The provided expression contains a {expr.GetType().Name} which is not supported. Only simple member accessors (fields, properties) of an object are supported.");

        return GetFieldName<T>(memberExpression.Member.Name);
    }

    public static string GetFieldName<T>(this ISearchIndexEngine<T> engine, Expression<Func<T, DateTime>> expr) where T : IDocument
    {
        if (expr.Body is not MemberExpression memberExpression)
            throw new ArgumentException($"The provided expression contains a {expr.GetType().Name} which is not supported. Only simple member accessors (fields, properties) of an object are supported.");

        return GetFieldName<T>(memberExpression.Member.Name);
    }

    private static string GetFieldName<T>(string fieldName) where T : IDocument
    {
        if (!DocumentFields<T>.HasFields)
            throw new Exception("Document index is empty");

        if (DocumentFields<T>.GetField(fieldName) is null)
            throw new ArgumentException($"The provided property doesn't exists: {fieldName}.");

        return DocumentFields<T>.GetField(fieldName)?.FieldName;
    }
}
