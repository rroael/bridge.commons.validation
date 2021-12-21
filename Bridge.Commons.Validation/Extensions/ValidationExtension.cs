using System;
using System.Collections.Generic;
using Bridge.Commons.Validation.Enums;
using FluentValidation;

namespace Bridge.Commons.Validation.Extensions
{
    /// <summary>
    ///     Extensão de validação
    /// </summary>
    public static class ValidationExtension
    {
        /// <summary>
        ///     Com estado
        /// </summary>
        /// <param name="rule"></param>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <typeparam name="TEnum"></typeparam>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, TProperty> WithState<T, TProperty, TEnum>(
            this IRuleBuilderOptions<T, TProperty> rule, TEnum errorCode, string message)
            where TEnum : IConvertible
        {
            rule.WithState(s => new Dictionary<EValidationField, string>
            {
                { EValidationField.ERROR_CODE, Convert.ToInt32(errorCode).ToString() },
                { EValidationField.MESSAGE, message }
            });

            return rule;
        }
    }
}