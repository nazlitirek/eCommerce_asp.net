using System.ComponentModel.DataAnnotations;
using eCommerce.Data.Base;

namespace eCommerce.Models
{
	public class Cinema:IEntityBase
	{
		[Key]
		public int Id { get; set; }
		[Display(Name = "Logo")]
		public string? Logo { get; set; }
		[Display(Name = "Name")]
		public string? Name { get; set; }
		[Display(Name = "Description")]
		public string? Description { get; set; }

		//relationships
		public List<Movie> Movies { get; set; }
	}
}
