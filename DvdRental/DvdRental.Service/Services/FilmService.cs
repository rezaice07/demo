using DvdRental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdRental.Service.Services
{
    public class FilmService
    {
        public List<Film> GetAllFilms()
        {
            var listing = new List<Film>();
            using (var db = new DvdRentalDbContext())
            {
                listing = db.Films.ToList();

                //var sqlCommand = "select get_film()";
                //var filmListing = db.Database.SqlQuery<FileModel>(sqlCommand).ToList();
            }


            return listing;
        }
    }


    public class FileModel
    {
        public string film_title { get; set; }
        public int film_release_year { get; set; }
    }
}
