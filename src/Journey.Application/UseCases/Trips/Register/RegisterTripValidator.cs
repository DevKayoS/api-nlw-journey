using FluentValidation;
using Journey.Communication.Requests;
using Journey.Exception;

namespace Journey.Application.UseCases.Trips.Register
{
    public class RegisterTripValidator : AbstractValidator<RequestRegisterTripJson>
    {
        public RegisterTripValidator()
        {
            //criando regra de validação para o Name
            RuleFor(request => request.Name).NotEmpty().WithMessage(ResourceErrorMessages.NAME_EMPTY);

            //criando regra de validação de data de inicio de viagem ser maior do que a data de criação
            RuleFor(request => request.StartDate.Date).GreaterThanOrEqualTo(DateTime.UtcNow.Date).WithMessage(ResourceErrorMessages.DATA_TRIP_MUST_BE_LATER_THAN_TODAY);

            //criando regra de validação para a data de término da viagem ser maior do que a data de inicio da viagem
            RuleFor(request => request).Must(request => request.EndDate.Date >= request.StartDate.Date).WithMessage(ResourceErrorMessages.END_DATA_TRIP_MUST_BE_LATER_START_DATE);
        }
    }
}