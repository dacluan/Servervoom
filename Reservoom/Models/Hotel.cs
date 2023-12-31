﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }
        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        /// <summary>
        /// Get the reservation for a user.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns> The reservations for the user.</returns>
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservationBook.GetReservationsForUser(username);
        }

        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="reservation">The incoming reservation.</param>
        /// <exception cref="SerervationConflictException"
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
