using System.ComponentModel.DataAnnotations;

namespace MovieReviewingAPI.Model
{
    public class AdminPage
    {
        [Key]
        public string MovieName { get; set; }
        public float RatingonIMD { get; set; }
        public string MovieDesc { get; set; }
    }
}
