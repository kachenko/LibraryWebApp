using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibWebApp.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int PersonID { get; set; }
        public int BookID { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}