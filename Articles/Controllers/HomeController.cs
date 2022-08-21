using Articles.Models;
using Articles.Services;
using Articles.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Articles.Controllers
{
    public class HomeController : Controller
    {
        private IArticlesService ArticlesService;
        public HomeController()
        {
            ArticlesService = new ArticlesService();
        }

        public async Task<ViewResult> Index()
        {
            ArticlesComponentModel latestResults = await ArticlesService.GetArticles();

            return View(latestResults);
        }
    }
}