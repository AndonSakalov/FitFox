using FitFox.Data.Models.Enums;
using FitFox.Data.Models.MappingModels;
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
			MapUsers = new HashSet<UserMap>();
			IsDeleted = false;
		}

		[Key]
		[Required]
		[Comment("The identifier of the map.")]
		public Guid Id { get; set; }

		[Required]
		[Comment("The category of the map - training, nutrition, hydration, recovery, etc.")]
		public MapCategory MapCategory { get; set; }

		[Comment("Collection of the lessons in the map.")]
		public virtual ICollection<Lesson> Lessons { get; set; } = null!;

		public virtual ICollection<UserMap> MapUsers { get; set; } = null!;

		public bool IsDeleted { get; set; }
	}
}