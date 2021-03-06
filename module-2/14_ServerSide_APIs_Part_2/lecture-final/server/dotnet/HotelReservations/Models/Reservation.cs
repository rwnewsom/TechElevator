using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    public class Reservation
    {
        public int? Id { get; set; }

        // TODO: Mark some of these fields as required

        // TODO: What happens if the set is private?

        public int HotelId { get; set; }

        // TODO: Use a string length validation on FullName
        [Required(ErrorMessage = "Who is this reservation for?", AllowEmptyStrings = false)]
        [StringLength(255, MinimumLength = 2)]
        public string FullName { get; set; }

        [Required]
        public string CheckinDate { get; set; }

        [Required]
        public string CheckoutDate { get; set; }

        // TODO: Add range validation to this to restrict the guest count to between 1 and 5 guests
        [Range(1, 8)]
        public int Guests { get; set; }

        public Reservation() // TODO: What happens if we don't have a parameterless reservation constructor?
        {
        }

        public Reservation(int? id, int hotelId, string fullName, string checkinDate, string checkoutDate, int guests)
        {
            Id = id ?? new Random().Next(100, int.MaxValue);
            HotelId = hotelId;
            FullName = fullName;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            Guests = guests;
        }
    }
}
