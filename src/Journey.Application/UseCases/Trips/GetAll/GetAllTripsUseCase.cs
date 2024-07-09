using Journey.Communication.Responses;
using Journey.Infrastructure;

namespace Journey.Application.UseCases.Trips.GetAll
{
    public class GetAllTripsUseCase
    {
        public ResponseTripsJson Execute()
        {
            var dbContext = new JourneyDbContext();

            var trips = dbContext.Trips.ToList();

            dbContext.SaveChanges();

            return new ResponseTripsJson
            {
                Trips = trips.Select(trips => new ResponseShortTripJson
                {
                    Id = trips.Id,
                    EndDate = trips.EndDate,
                    Name = trips.Name,
                    StartDate = trips.StartDate
                }).ToList()
            };
        }
    }
}
