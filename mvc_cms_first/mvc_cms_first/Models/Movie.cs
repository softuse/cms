using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_cms_first.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required, StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }

        public string Test { get; set; }
    }

    public class MovieDBContext : DbContext
    {

        public MovieDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }

    }

}
