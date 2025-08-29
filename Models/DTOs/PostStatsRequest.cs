namespace PoTSharedModules.Models.DTOs;

public class PostStatsRequest
{
	public Guid? Guid { get; set; }
	public int SavePlayTimeSeconds { get; set; }
	public int ModPlayerPlayTimeSeconds { get; set; }
	public required string PlayerName { get; set; }
	public string ModVersion { get; set; }
	public required string ModList { get; set; }
	public int Level { get; set; }
	public int Experience { get; set; }
	public required string SteamId { get; set; }
	public int Strength { get; set; }
	public int Dexterity { get; set; }
	public int Intelligence { get; set; }
}