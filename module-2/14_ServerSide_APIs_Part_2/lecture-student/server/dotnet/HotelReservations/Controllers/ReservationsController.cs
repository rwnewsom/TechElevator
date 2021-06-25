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
            return Created("reservations/" + newReservation.Id, newReservation); //201 created

            //return newReservation;
        }

        // PUT reservations/{id}
        [HttpPut("reservations/{id}")]
        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservation)
        {
            if (reservation == null)
            {
                return BadRequest("Reservation is required");
            }

            if (id != reservation.Id)
            {
                return BadRequest("Reservation ID did not match the provided URL");
            }

            Reservation result = reservationDao.Update(id, reservation);
            if (result == null)
            {
                return NotFound(); //404
            }
            return result; //200ok
        }

        // DELETE reservations/{id}

        [HttpDelete("reservations/{reservationId}")]
        public ActionResult RemoveReservation(int reservationId)
        {
            bool deleted = reservationDao.Delete(reservationId);
            if (deleted)
            {
                return NoContent(); //204
            }
            else
            {
                return NotFound(); //404
            }


        }


    }
}
