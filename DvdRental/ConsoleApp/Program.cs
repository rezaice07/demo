using DvdRental.Model;
using DvdRental.Service.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FilmService filmService = new FilmService();

            var listing = filmService.GetAllFilms();

            foreach (var item in listing)
            {
                Console.WriteLine(item.title);
            }


            LanguageService languageService = new LanguageService();

            //var newLanguage = new Language
            //{
            //    name = "Bangla",
            //    last_update=DateTime.Now

            //};

            //languageService.Add(newLanguage);


            var updateLanguage = new Language
            {
                language_id=7,
                name = "Bengali",
                last_update = DateTime.Now

            };

            languageService.Update(updateLanguage);

            Console.ReadKey();
        }
    }
}
