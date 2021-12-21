using System;
using Bridge.Commons.Validation.Contracts;
using FluentValidation;

namespace Bridge.Commons.Validation
{
    /// <summary>
    ///     Base de validador
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseValidator<T> : AbstractValidator<T>, IBaseValidator<T>
    {
        /// <summary>
        ///     Busca o tipo de entidade
        /// </summary>
        /// <returns></returns>
        public Type GetEntityType()
        {
            return typeof(T);
        }
    }
}