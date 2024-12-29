using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eCommerce.Data.Base;
using eCommerce.Data.Enums;

namespace eCommerce.Models
{
    public class NewMovieVM
	{
        [Display(Name = "Image Url")]
        [Required(ErrorMessage = "required")]
        public string ImageUrl { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "required")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "required")]
        public double Price { get; set; }

        [Display(Name= "Start Date")]
        [Required(ErrorMessage = "required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "required")]
        public MovieCategory MovieCategory { get; set; }

        //relationships
        [Display(Name = "Select Actor(s)")]
        [Required(ErrorMessage = "required")]
        public List<int> ActorIds { get; set;}

        [Display(Name = "Select cinema")]
        [Required(ErrorMessage = "required")]
        public int? CinemaId { get; set; }

        [Display(Name = "Select Producer(s)")]
        [Required(ErrorMessage = "required")]
        public int? ProducerId { get; set; }
		
	}
}
