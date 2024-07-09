using Journey.Communication.Requests;
using Journey.Exception.ExceptionsBase;
using Journey.Exception;

namespace Journey.Application.UseCases.Trips.Register
{
    public class RegisterTripUseCase
    {
        public void Execute(RequestRegisterTripJson request)
        {
            Validate(request);
        }

        //fazendo as validacoes
        private void Validate(RequestRegisterTripJson request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                throw new JourneyException(ResourceErrorMessages.NAME_EMPTY);
            }

            if(request.StartDate.Date < DateTime.UtcNow.Date)
            {
                throw new JourneyException(ResourceErrorMessages.DATA_TRIP_MUST_BE_LATER_THAN_TODAY);
            }

            if (request.EndDate.Date < request.StartDate.Date)
            {
                throw new JourneyException(ResourceErrorMessages.END_DATA_TRIP_MUST_BE_LATER_START_DATE);
            }
        }
    }
}
