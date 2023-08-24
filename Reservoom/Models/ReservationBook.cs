using Reservoom.Exceptions;
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

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservations.Where(r => r.Username == username);
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation exstingRevervation in _reservations)
            {
                if(exstingRevervation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(exstingRevervation, reservation);
                }
                
            }

           _reservations.Add(reservation);
        }

       
    }
}
