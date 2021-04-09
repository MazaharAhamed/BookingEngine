using BookingEngine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookingEngine.Pages
{
    public class ErrorModel : PageModel
    {
        private ApplicationDbContext _db;

        public ErrorModel(ApplicationDbContext context)
        {
            _db = context;
        }

        public int Rid { get; set; }

        public IEnumerable<Room> Room { get; set; }

        public void OnGet(int id)
        {
            Rid = id;
            Room = _db.Rooms.ToList();
        }
    }
}