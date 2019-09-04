using DvdRental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdRental.Service.Services
{
    public class LanguageService
    {
        public List<Language> GetAllLanguages()
        {
            var listing = new List<Language>();
            using (var db = new DvdRentalDbContext())
            {
                listing = db.Languages.ToList();                
            }

            return listing;
        }

        public Language Add(Language language)
        {           
            using (var db = new DvdRentalDbContext())
            {
                db.Languages.Add(language);
                db.SaveChanges();
            }

            return language;
        }

        public Language Update(Language language)
        {
            using (var db = new DvdRentalDbContext())
            {
                var updateLanguage = db.Languages.FirstOrDefault(f => f.language_id == language.language_id);

                updateLanguage.name = language.name;
                updateLanguage.last_update = language.last_update;

                db.SaveChanges();
            }

            return language;
        }
    }
}
