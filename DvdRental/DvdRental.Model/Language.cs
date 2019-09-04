using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdRental.Model
{

    [Table("language", Schema = "public")]
    public class Language
    {
        [Key]
        [Display(Name = "language_id")]
        public int language_id { get; set; }

        [Display(Name = "name")]
        public string name { get; set; }

        [Display(Name = "last_update")]
        public DateTime? last_update { get; set; }
    }
}
