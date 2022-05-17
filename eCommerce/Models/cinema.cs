using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class cinema
    {
        [Key]
        public int id { get; set; }
        public String logo { get; set; }
        public string Name { get; set; }
        public string  desription { get; set; }
    }
}
