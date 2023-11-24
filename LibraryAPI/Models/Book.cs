using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public string Author { get; set; }
        [Required]
        public DateTime Date{ get; set; }
        [MaxLength(50)]
        public string Badiy { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
