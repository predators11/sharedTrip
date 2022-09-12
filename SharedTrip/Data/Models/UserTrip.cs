﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SharedTrip.Data.Models
{
    public class UserTrip
    {        
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public string TripId { get; set; }

        [ForeignKey(nameof(TripId))]
        public Trip Trip { get; set; }
    }
}

//•	Has UserId – a string
//•	Has User – a User object
//•	Has TripId– a string
//•	Has Trip – a Trip object