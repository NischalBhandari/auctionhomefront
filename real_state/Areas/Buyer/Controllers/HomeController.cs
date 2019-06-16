using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using real_state.Data;
using real_state.Models;

namespace real_state.Controllers
{
	[Area("Buyer")]
	//[Authorize]
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _db;
		public HomeController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			
			ViewBag.buyercountry = new SelectList(_db.Buyer_Details.ToList(), "Country", "Country");
			ViewBag.buyerstate = new SelectList(_db.Buyer_Details.ToList(), "STATE", "STATE");
			ViewBag.buyercity = new SelectList(_db.Buyer_Details.ToList(), "City", "City");
			ViewBag.Bed = new SelectList(_db.Buyer_Details.ToList(), "Beds", "Beds");
			ViewBag.Baths = new SelectList(_db.Buyer_Details.ToList(), "Baths", "Baths");
		

			return View(_db.Buyer_Details.Where(u => u.Id <30).ToList());
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Search(string Country, string STATE, string City, int? Beds, int? Baths, int? minsqft, int? maxsqft, int? minamount, int? maxamount)
		{

			
			var model = _db.Buyer_Details.Where(u => u.Country == Country && u.STATE == STATE && u.City == City && u.Beds == Beds && u.Baths == Baths && (u.SqFt == minsqft && u.SqFt == maxsqft) && (u.EstAuctionAmt == minamount && u.EstAuctionAmt == maxamount) && u.Id < 10).ToList();

			return View(model);   
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}


		public IActionResult Viewlist()
		{

			ViewBag.buyercountry = new SelectList(_db.Buyer_Details.ToList(), "Country", "Country");
			ViewBag.buyerstate = new SelectList(_db.Buyer_Details.ToList(), "STATE", "STATE");
			ViewBag.buyercity = new SelectList(_db.Buyer_Details.ToList(), "City", "City");
			ViewBag.Bed = new SelectList(_db.Buyer_Details.ToList(), "Beds", "Beds");
			ViewBag.Baths = new SelectList(_db.Buyer_Details.ToList(), "Baths", "Baths");


			return View(_db.Buyer_Details.Where(u => u.Id < 30).ToList());
		}
	}
}
