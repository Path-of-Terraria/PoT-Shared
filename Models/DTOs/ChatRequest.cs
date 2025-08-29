namespace PoTSharedModules.Models.DTOs;

public class ChatRequest
{
	public required string PlayerName { get; set; }
	public required string Message { get; set; }
	public required string SteamId { get; set; }
}