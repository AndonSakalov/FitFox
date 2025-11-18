using System.ComponentModel.DataAnnotations;

namespace FitFox.Data.Models.MappingModels
{
	public class UserMap
	{
		[Required]
		public Guid UserId { get; set; }
		public virtual ApplicationUser User { get; set; } = null!;

		[Required]
		public Guid MapId { get; set; }
		public virtual Map Map { get; set; } = null!;

		[Required]
		public double PercentCovered { get; set; }
	}
}
