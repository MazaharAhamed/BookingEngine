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

        public int ResId { get; set; }

        public string RoomName { get; set; }

        public IEnumerable<Room> Room { get; set; }

        public void OnGet(int id, int resid)
        {
            Rid = id;
            ResId = resid;
            //RoomName = _db.Rooms.Where(r => r.RoomId == Rid).Select(r => r.RoomName).FirstOrDefault();
            Room = _db.Rooms.ToList();
        }
    }
}