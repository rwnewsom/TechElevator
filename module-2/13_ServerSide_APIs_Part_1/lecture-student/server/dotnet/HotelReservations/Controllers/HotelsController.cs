using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")] // If there is a specific route here, it gets prepended to any route for a method below
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelDao _hotelDao;
        private readonly IReservationDao _reservationDao;

        public HotelsController()
        {
            _hotelDao = new HotelDao();
            _reservationDao = new ReservationDao();
        }

        /// <summary>
        /// This method returns a simple greeting message to show you that ASP .NET works
        /// </summary>
        [HttpGet("greeting")] // Responds to GET requests to /Greeting
        public string HelloWorld()
        {
            return "Hello .NET Purple. Welcome to ASP .NET";
        }

        // GET hotels - Get all available hotels
        [HttpGet("hotels")]
        public List<Hotel> GetAllHotels()
        {
            return _hotelDao.List();
        }

        // GET hotels/{someHotelId} - Get a specific hotel
        [HttpGet("hotels/{hotelId}")]
        public Hotel GetSomeHotelBySomeId(int hotelId)
        {
            return _hotelDao.Get(hotelId);
        }

        // GET reservations - Get all reservations
        [HttpGet("reservations")]
        public List<Reservation> GetAllActiveReservations()
        {
            return _reservationDao.List();
        }

        // GET reservations/{someReservationId} - Get a specific reservation
        [HttpGet("reservations/{reservationId}")]
        public Reservation FindReservation(int reservationId)
        {
            return _reservationDao.Get(reservationId);
        }

        // GET hotels/{someHotelId}/reservations - Get all reservations for a given hotel
        [HttpGet("hotels/{hotelId}/reservations")]
        public List<Reservation> GetReservationsForSomeHotel(int hotelId)
        {
            return _reservationDao.FindByHotel(hotelId);
        }

        /*
        //multi variable example
        [HttpGet("hotels/{hotelId}/reservation/{reservationId")]
        public Reservation FindReservation(int hotelId, int reservationId)
        {
            return _reservationDao.Get(reservationId);
        }
        */

        // GET hotels/filter - Get hotels, but filtered down by state or city based on the query string parameters
        // Query string parameters must be named "state" and "city" respectively
        // ?state=OH&city=columbus
        //BAD: [HttpGet("hotels/filter?state={state}&city={city}")]
        [HttpGet("hotels/filter")] //?state=OH&city=columbus)]
        public List<Hotel> SearchHotels(string state, string city)
        {
            List<Hotel> allHotels = _hotelDao.List();
            List<Hotel> matchingHotels = new List<Hotel>();
            foreach (Hotel hotel in allHotels)
            {
                if(state != null) //user provided state
                {
                    if (hotel.Address.State.ToLower() == state.ToLower())
                    {
                        matchingHotels.Add(hotel);
                    }
                }
                //probably reverse this flow and check city first
                //i would prefer a stricter filter
                else if (city!= null)
                {
                    if(hotel.Address.City.ToLower() == city.ToLower())
                    {
                        matchingHotels.Add(hotel);
                    }
                }

                if(state==null && city == null)
                {
                    matchingHotels.Add(hotel);
                }
            }

            return matchingHotels;
        }

        // POST reservations - Add a new reservation
        [HttpPost("reservations")]
        public Reservation CreateNewReservation([FromBody]Reservation reservation) // the [FromBody] clarifies where the data is coming from, this works without it though
            //if you need to return multiple objects, make them children of a parent object
        {
            return _reservationDao.Create(reservation);
        }
    }
}
