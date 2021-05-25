using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingSystemAPI.Models
{
    public class Booking
    {
        [Key]

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ExecutiveId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeOfPickUp { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }

    }
}
