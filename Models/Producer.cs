﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Data.Base;
using eCommerce.Models;

namespace eCommerce.Models
{
	public class Producer:IEntityBase
	{
		[Key]
		public int Id { get; set; }
		[Display(Name = "Profile Picture Url")]
		[Required(ErrorMessage = "required")]
		public string ProfilePictureUrl { get; set; }
		[Display(Name = "Full Name")]
		[Required(ErrorMessage = "required")]
		public string FullName { get; set; }
		[Display(Name = "Bio")]
		[Required(ErrorMessage = "required")]
		public string Bio { get; set; }

		//Relationships
		public List<Movie> Movies { get; set; }
	}
}