using System.ComponentModel.DataAnnotations;

namespace BadmintonApp.Data.Entities;

/// <summary>
/// Пользователь системы
/// </summary>
public class User : BaseEntity
{
	[MaxLength(255)]
	public string Name { get; set; } = null!;

	[MaxLength(255)]
	public string Surname { get; set; } = null!;

	[MaxLength(255)]
	public string Patronymic { get; set; } = null!;

	[MaxLength(255)]
	public string Email { get; set; } = null!;

	[MaxLength(255)]
	public string PasswordHash { get; set; } = null!;
}