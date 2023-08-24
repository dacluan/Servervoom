using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;
        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string user)
        {
            return _reservations.Where(r => r.Username == user);
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation exstingRevervation in _reservations)
            {
                if(exstingRevervation.Conflicts(reservation))
                {
                    throw new ReservationConflictException();
                }
            }
        }
    }
}
