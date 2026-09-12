using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        //[StringLength(50, MinimumLength = 2)]
        [MinLength(2, ErrorMessage = "Слишком мало"), MaxLength(50, ErrorMessage = "Слишком много")] public string Title { get; set; }

        [RangeAttribute(typeof(DateOnly), "1888-10-14", "2128-12-31")]
        public DateOnly ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public string? URL { get; set; }
        public string Poster {  get; set; }
    }
}
