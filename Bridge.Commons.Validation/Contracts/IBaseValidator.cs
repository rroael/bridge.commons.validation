using System;
using FluentValidation;

namespace Bridge.Commons.Validation.Contracts
{
    /// <summary>
    ///     Interface base de validador
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseValidator<in T> : IValidator<T>, IBaseValidator
    {
    }

    /// <summary>
    ///     Interface base de validador
    /// </summary>
    public interface IBaseValidator : IValidator
    {
        /// <summary>
        ///     Busca tipo de entidade
        /// </summary>
        /// <returns></returns>
        Type GetEntityType();
    }
}