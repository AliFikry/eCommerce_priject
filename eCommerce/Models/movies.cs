using eCommerce.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class movies
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MoviesCategory MoviesCategory { get; set; }

    }
}
