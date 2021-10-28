using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Actor
    {

        public int Id { get; set; }

        [Display(Name = "Given Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Name must begin with an uppercase letter, only use letters and spaces.")]
        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string GivenName { get; set; }

        [Display(Name = "Family Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Name must begin with an uppercase letter, only use letters and spaces.")]
        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string FamilyName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Birth place")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "City must begin with an uppercase letter, only use letters and spaces.")]
        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string Birthplace { get; set; }
        
        [Display(Name = "Number Of Oscars")]
        [Required]
        public int NumberOfOscars { get; set; }
    }
}
