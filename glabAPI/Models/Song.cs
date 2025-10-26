using System.ComponentModel.DataAnnotations;

namespace glabAPI.Models
{
    public class Song
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Language { get; set; }
    }
}
