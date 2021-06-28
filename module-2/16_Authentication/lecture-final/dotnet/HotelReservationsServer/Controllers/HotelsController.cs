using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;
using Microsoft.AspNetCore.Authorization;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    [Authorize] // Every method here now requires authentication, unless it has AllowAnonymous
    public class HotelsController : ControllerBase
    {
        private static IHotelDao _hotelDao;
        private static IReservationDao _reservationDao;

        public HotelsController()
        {
            if (_hotelDao == null)
            {
                _hotelDao = new HotelDao();
            }

            if (_reservationDao == null)
            {
                _reservationDao = new ReservationDao();
            }
        }

        [HttpGet("hotels")]
        [AllowAnonymous] // Any user can list hotels, even if they're not authenticated
        public List<Hotel> ListHotels()
        {
            return _hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            Hotel hotel = _hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("hotels/filter")]
        public List<Hotel> FilterByStateAndCity(string state, string city)
        {
            List<Hotel> filteredHotels = new List<Hotel>();

            List<Hotel> hotels = ListHotels();
            // return hotels that match state
            foreach (Hotel hotel in hotels)
            {
                if (city != null)
                {
                    // if city was passed we don't care about the state filter
                    if (hotel.Address.City.ToLower().Equals(city.ToLower()))
                    {
                        filteredHotels.Add(hotel);
                    }
                }
                else
                {
                    if (hotel.Address.State.ToLower().Equals(state.ToLower()))
                    {
                        filteredHotels.Add(hotel);
                    }
                }
            }
            return filteredHotels;
        }

        [HttpGet("reservations")]
        [Authorize] // Must be AUTHENTICATED to call this method
        public List<Reservation> ListReservations()
        {
            return _reservationDao.List();
        }

        [HttpGet("reservations/{id}")]
        [Authorize]
        public ActionResult<Reservation> GetReservation(int id)
        {
            Reservation reservation = _reservationDao.Get(id);

            if (reservation != null)
            {
                return reservation;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("hotels/{hotelId}/reservations")]
        [Authorize]
        public ActionResult<List<Reservation>> ListReservationsByHotel(int hotelId)
        {
            Hotel hotel = _hotelDao.Get(hotelId);
            if (hotel == null)
            {
                return NotFound("Hotel Id is invalid");
            }
            return _reservationDao.FindByHotel(hotelId);
        }

        [HttpPost("reservations")]
        [Authorize(Roles = "admin, creator")] // Must be authenticated, plus must be authorized as an admin or creator
        public ActionResult<Reservation> AddReservation(Reservation reservation)
        {
            // Get the user's ID from their claims 'sub' field

            // Get the user from the database by their ID

            // Check that the user is either an admin, OR their hotel matches the reservation hotel

            // if user.HotelID != reservation.HotelID, then return Forbidden()
            // return Forbid("Wrong hotel, buddy");

            Reservation added = _reservationDao.Create(reservation);
            return Created($"/reservations/{added.Id}", added);
        }

        [HttpPut("reservations/{id}")]
        [Authorize(Roles = "admin")]
        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservation)
        {
            Reservation existingReservation = _reservationDao.Get(id);
            if (existingReservation == null)
            {
                return NotFound("Reservation does not exist");
            }

            Reservation result = _reservationDao.Update(id, reservation);
            return Ok(result);
        }

        [HttpDelete("reservations/{id}")]
        [Authorize(Roles = "admin")]
        public ActionResult DeleteReservation(int id)
        {
            Reservation existingReservation = _reservationDao.Get(id);
            if (existingReservation == null)
            {
                return NotFound("Reservation does not exist");
            }

            bool result = _reservationDao.Delete(id);
            if (result)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
