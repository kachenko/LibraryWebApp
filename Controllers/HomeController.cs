using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BibWebApp.Models;

namespace BibWebApp.Controllers
{
    public class HomeController : Controller
    {
        BookReserv bookReserv = new BookReserv();
        public ActionResult Index()
        {
            IEnumerable<Book> books = bookReserv.Books;
            ViewBag.Books = books;
            return View(bookReserv.Books);
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookID = id;
            return View();
        }

        [HttpPost]
        public string Buy(Reservation reservation)
        {
            reservation.ReservationDate = DateTime.Now;
            bookReserv.Reservations.Add(reservation);
            bookReserv.SaveChanges();
            return "Rezerwacja została potwierdzona.";
        }
        
        protected override void Dispose(bool disposing)
        {
            bookReserv.Dispose();
            base.Dispose(disposing);
        }
    }
}