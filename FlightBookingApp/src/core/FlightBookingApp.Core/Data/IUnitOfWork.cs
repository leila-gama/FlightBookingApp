namespace FlightBookingApp.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}