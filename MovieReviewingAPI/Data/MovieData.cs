using Microsoft.EntityFrameworkCore;
using MovieReviewingAPI.Model;

namespace MovieReviewingAPI.Data
{
    public class MovieData:DbContext
    {
        public MovieData(DbContextOptions<MovieData> options):base(options)
        {

        }
        public DbSet<AdminPage> MovieDatas { get; set; }

    }
}
