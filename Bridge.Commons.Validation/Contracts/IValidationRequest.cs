using FluentValidation;

namespace Bridge.Commons.Validation.Contracts
{
    /// <summary>
    ///     Requisição de validação
    /// </summary>
    public interface IValidationRequest
    {
        /// <summary>
        ///     Buscar validador
        /// </summary>
        /// <returns></returns>
        IValidator GetValidator();
    }
}