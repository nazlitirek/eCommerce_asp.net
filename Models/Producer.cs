using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Models;

namespace eCommerce.Models
{
	public class Producer
	{
		[Key]
		public int Id { get; set; }
		[Display(Name = "Profile Picture Url")]
		public string ProfilePictureUrl { get; set; }
		[Display(Name = "Full Name")]
		public string FullName { get; set; }
		[Display(Name = "Bio")]
		public string Bio { get; set; }

		//Relationships
		public List<Movie> Movies { get; set; }
	}
}