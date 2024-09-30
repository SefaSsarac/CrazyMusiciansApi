using System.ComponentModel.DataAnnotations;

namespace CrazyMusiciansApi.Models
{
    public class CrazyMusicians
    {
         
        public int Id { get; set; }

        [Required(ErrorMessage = "Musician name required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Musician name must be minimun 3 character.")]
        public string MusicianName { get; set; }

        public string Job { get; set; }

        public string FunFeature { get; set; }

        public bool IsDone { get; set; }

    }
}

