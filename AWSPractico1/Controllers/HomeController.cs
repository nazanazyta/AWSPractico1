using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSPractico1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AWSPractico1.Controllers
{
    public class HomeController : Controller
    {
        RepositoryCoches Repo;

        public HomeController(RepositoryCoches repo)
        {
            this.Repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.Repo.GetCoches());
        }

        public IActionResult Details(int id)
        {
            return View(this.Repo.FindCoche(id));
        }
    }
}
