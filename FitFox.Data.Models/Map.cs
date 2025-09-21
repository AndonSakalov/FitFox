using FitFox.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models
{
	public class Map
	{
		public Map()
		{
			Id = Guid.NewGuid();
			Lessons = new HashSet<Lesson>();
		}

		[Required]
		[Comment("The identifier of the map.")]
		public Guid Id { get; set; }

		[Required]
		[Comment("The category of the map - training, nutrition, hydration, recovery, etc.")]
		public MapCategory MapCategory { get; set; }

		[Comment("Collection of the lessons in the map.")]
		public virtual ICollection<Lesson> Lessons { get; set; }
	}
}