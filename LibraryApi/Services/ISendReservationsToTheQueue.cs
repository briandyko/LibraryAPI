using LibraryApi.Models;

namespace LibraryApi.Services
{
    public interface ISendReservationsToTheQueue
    {
        void SendReservation(ReservationItem response);
    }
}