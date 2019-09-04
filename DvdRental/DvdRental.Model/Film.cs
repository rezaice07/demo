using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdRental.Model
{

    [Table("film", Schema = "public")]
    public class Film
    {
        [Key]
        [Display(Name = "film_id")]
        public int film_id { get; set; }

        [Display(Name = "title")]
        public string title { get; set; }

        [Display(Name = "description")]
        public string description { get; set; }

        [Display(Name = "release_year")]
        public int? release_year { get; set; }

        [Display(Name = "language_id")]
        public int? language_id { get; set; }

        [Display(Name = "rental_duration")]
        public int? rental_duration { get; set; }

        [Display(Name = "rental_rate")]
        public decimal? rental_rate { get; set; }

        [Display(Name = "length")]
        public int length { get; set; }

        [Display(Name = "replacement_cost")]
        public decimal? replacement_cost { get; set; }

        [Display(Name = "rating")]
        public string rating { get; set; }

        [Display(Name = "last_update")]
        public DateTime last_update { get; set; }

        [Display(Name = "special_features")]
        public string special_features { get; set; }

        [Display(Name = "fulltext")]
        public string fulltext { get; set; }
    }
}
