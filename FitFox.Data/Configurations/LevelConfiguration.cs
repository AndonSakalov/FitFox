using FitFox.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitFox.Data.Configurations
{
	public class LevelConfiguration : IEntityTypeConfiguration<Level>
	{
		public void Configure(EntityTypeBuilder<Level> builder)
		{
			var level1Id = Guid.Parse("11111111-1111-1111-1111-111111111111");
			builder.HasData(
			new Level
			{
				Id = level1Id,
				LevelNumber = 1,
				RequiredXP = 0,
				LevelTitle = "Newbie"
			},
			new Level
			{
				Id = Guid.Parse("3f8d2c64-7a41-4d8e-9a3d-0c5b2c9e8f11"),
				LevelNumber = 2,
				RequiredXP = 300,
				LevelTitle = "Newbie"
			},
			new Level
			{
				Id = Guid.Parse("c1a4b9d7-5e32-4893-9f6f-2a7d23b0e4d2"),
				LevelNumber = 3,
				RequiredXP = 300,
				LevelTitle = "Newbie"
			},
			new Level
			{
				Id = Guid.Parse("a74b2fa1-0e9c-4c88-b1d2-1510e754ad55"),
				LevelNumber = 4,
				RequiredXP = 300,
				LevelTitle = "Newbie"
			},
			new Level
			{
				Id = Guid.Parse("9d2c4e8f-3af1-41c7-8fab-7b1c9e72aa90"),
				LevelNumber = 5,
				RequiredXP = 300,
				LevelTitle = "Beginner"
			},
			new Level
			{
				Id = Guid.Parse("f0b8d6c1-4ec3-4c99-92fb-41e1bfb83b3a"),
				LevelNumber = 6,
				RequiredXP = 300,
				LevelTitle = "Beginner"
			},
			new Level
			{
				Id = Guid.Parse("52a0df49-868e-4f6e-9b73-1e3c0a44e91f"),
				LevelNumber = 7,
				RequiredXP = 300,
				LevelTitle = "Beginner"
			},
			new Level
			{
				Id = Guid.Parse("81cce7d4-b7b2-4a22-9364-9daccf28a6ba"),
				LevelNumber = 8,
				RequiredXP = 300,
				LevelTitle = "Beginner"
			},
			new Level
			{
				Id = Guid.Parse("e3b69c2a-2f80-4d6d-9b1e-dbc7d257c89b"),
				LevelNumber = 9,
				RequiredXP = 300,
				LevelTitle = "Beginner"
			},
			new Level
			{
				Id = Guid.Parse("6a5f3e11-8fd1-4b62-91d9-5c3dcd73f8c2"),
				LevelNumber = 10,
				RequiredXP = 300,
				LevelTitle = "Skilled Novice"
			}
			);
		}
	}
}
