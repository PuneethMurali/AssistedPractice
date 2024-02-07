using System.ComponentModel.DataAnnotations;

namespace WebAPIAssessment.Models
{
    public class Movie
    {
        [Key]
        public int Movie_id { get; set; }
        public string? Movie_name { get; set; }
        public string? StartCast { get; set; }
        public string? Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? producer { get; set; }

    }
}
