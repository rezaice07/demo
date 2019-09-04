using DvdRental.Model;
using DvdRental.Service.Services;
using DvdRental.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DvdRental.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FilmService filmService = new FilmService();

            var listing = filmService.GetAllFilms();

            var model = new FilmListViewModel
            {
                Films = listing
            };


            //LanguageService languageService = new LanguageService();

            //var newLanguage = new Language
            //{
            //    name = "Bangla",
            //    last_update=DateTime.Now

            //};

            //languageService.Add(newLanguage);


            //var updateLanguage = new Language
            //{
            //    language_id = 7,
            //    name = "Bengali",
            //    last_update = DateTime.Now

            //};

            //languageService.Update(updateLanguage);

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}