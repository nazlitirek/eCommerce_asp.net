using System.ComponentModel.DataAnnotations;
using eCommerce.Data.Base;

namespace eCommerce.Models
{
	public class Actor:IEntityBase
	{
		[Key]
		public int Id { get; set; }


		[Display(Name ="Profile Picture Url")]
        [Required(ErrorMessage = "required")]
        public string  ProfilePictureUrl { get; set; }


		[Display(Name = "Full Name")]
        [Required(ErrorMessage = "required")]
        public string FullName { get; set;}


		[Display(Name = "Bio")]
        [Required(ErrorMessage = "required")]
        public string Bio { get; set;}

		//relationships
		public List<Actor_Movie> Actors_Movies { get; set; }

	}
}
