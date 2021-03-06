using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private static IHotelDao hotelDao;
        private static IReservationDao reservationDao;

        public HotelsController(IHotelDao _hotelDao, IReservationDao _reservationDao)
        {
            hotelDao = _hotelDao;
            reservationDao = _reservationDao;
        }

        [HttpGet("hotels")]
        public ActionResult<List<Hotel>> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            // TODO: What if hotel is null? How do we return a 404?
            if(hotel == null)
            {
                return NotFound("Could not find hotel with id "+id);
            }

            // TODO: What happens if we get an exception here? 
            //ASP.NET handles exceptions, no need for try catch within controller

            return Ok(hotel); //OK here is not needed. Returning hotel on its own also gives a 200 status code.
        }

        [HttpGet("hotels/filter")]
        public ActionResult<List<Hotel>> FilterByStateAndCity(string state, string city)
        {
            List<Hotel> filteredHotels = new List<Hotel>();

            List<Hotel> hotels = hotelDao.List();
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

        [HttpGet("hotels/{hotelId}/reservations")]
        public ActionResult<List<Reservation>> ListReservationsByHotel(int hotelId)
        {
            // TODO: What if the ID is negative?
            if(hotelId <= 0)
            {
                return BadRequest("Enter a valid hotel id. Ids must be greater than 0."); //status code 400
            }

            // TODO: What if they give us a hotel that doesn't exist?

            Hotel hotel = hotelDao.Get(hotelId);
            if(hotel == null)
            {
                return NotFound("There is no hotel with id " + hotelId);
            }

            return reservationDao.FindByHotel(hotelId);

            //return result;
        }
    }
}
