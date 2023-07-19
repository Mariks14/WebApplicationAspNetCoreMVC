using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

using WebApplicationAspNetCoreMVC.Models;

namespace WebApplicationAspNetCoreMVC.Controllers
{
	public class HomeController : Controller
	{
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Companies.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Details(string id, string name, string address, string city, string state)
        {
            //ClientScript.RegisterStartupScript(GetType(), "Javascript", "javascript:FUNCTIONNAME(); ", true);
            ViewData["id"] = id;
            //ViewBag.Companies = value;
            ViewData["name"] = name;
            ViewData["address"] = address;
            ViewData["city"] = city;
            ViewData["state"] = state;

            List<History> history = new List<History>();
            foreach (var item in  db.History)
            {
                if (item.NameCompany == name)
                {
                    history.Add(item);
                }
            }
            ViewData["history"] = history;

            List<Notes> notes = new List<Notes>();
            foreach (var item in  db.Notes)
            {
                if (item.NameCompany == name)
                {
                    notes.Add(item);
                }
            }
            ViewData["notes"] = notes;

            List<Employes> employes = new List<Employes>();
            foreach (var empl in await db.Employes.ToListAsync())
            {
                foreach (var note in await db.Notes.ToListAsync())
                {
                    if (empl.FirstName + " " + empl.LastName == note.Employee && note.NameCompany ==name)
                    {
                        employes.Add(empl);
                    }
                }
            }
            ViewData["employes"] = employes;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Companies companies)
        {
            db.Companies.Add(companies);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        

        private readonly ILogger<HomeController> _logger;

		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

		//public IActionResult Index()
		//{
		//	return View();
		//}

		public IActionResult Privacy()
		{
			return View();
		}

		//public IActionResult Create()
		//{
		//	return View();
		//}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}