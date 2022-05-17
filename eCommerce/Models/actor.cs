using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class actor
    {
        [Key]
        public int id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }

        public string Bio { get; set; }
    }
}
