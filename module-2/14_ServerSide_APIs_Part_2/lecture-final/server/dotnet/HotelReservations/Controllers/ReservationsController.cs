using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private static IReservationDao reservationDao;

        public ReservationsController(IReservationDao _reservationDao)
        {
            reservationDao = _reservationDao;
        }

        [HttpGet("reservations")]
        public ActionResult<List<Reservation>> ListReservations()
        {
            return reservationDao.List();
        }

        [HttpGet("reservations/{id}")]
        public ActionResult<Reservation> GetReservation(int id)
        {
            Reservation reservation = reservationDao.Get(id);

            // TODO: What if reservation is null? How do we return a 404?
            if (reservation == null)
            {
                return NotFound();
            }

            return reservation;
        }

        [HttpPost("reservations")]
        public ActionResult<Reservation> AddReservation(Reservation reservation)
        {
            Reservation newReservation = reservationDao.Create(reservation);

            // TODO: How do we give back a 201 created instead?

            return Created("reservations/" + newReservation.Id, newReservation); // 201
        }

        // PUT reservations/{id}
        [HttpPut("reservations/{id}")]
        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return BadRequest("Reservation ID did not match the provided URL"); // 400
            }

            Reservation result = reservationDao.Update(id, reservation);

            if (result == null)
            {
                return NotFound(); // 404
            }

            return result; // 200 OK
        }

        // DELETE reservations/{id}
        [HttpDelete("reservations/{reservationId}")]
        public ActionResult RemoveReservation(int reservationId)
        {
            bool deleted = reservationDao.Delete(reservationId);

            if (deleted)
            {
                return NoContent(); // 204 
            } 
            else
            {
                return NotFound(); // 404
            }
        }
    }
}
