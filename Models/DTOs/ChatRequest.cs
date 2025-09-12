using System.ComponentModel;

namespace PoTSharedModules.Models.DTOs;

public class ChatRequest
{
	public required string PlayerName { get; set; }
	public required string Message { get; set; }
	public required string SteamId { get; set; }
}

public enum ChatColorOption
{
	[Description("#1abc9c")]
	Supporter,
    
	[Description("#9b59b6")]
	ProSupporter,
    
	[Description("#e74c3c")]
	EliteSupporter,
    
	[Description("#9fc1ff")]
	UltimateSupporter,
    
	[Description("#1e86fe")]
	Developer,
    
	[Description("#aa3b3b")]
	ScottieKnowz
}

public static class ChatColorOptionExtensions
{
	public static string ToDescriptionString(this ChatColorOption val)
	{
		var attributes = (DescriptionAttribute[]) val
			.GetType()
			.GetField(val.ToString())
			.GetCustomAttributes(typeof(DescriptionAttribute), false);
		return attributes.Length > 0 ? attributes[0].Description : string.Empty;
	}
}

public enum ChatIconOption
{
	[Description("Developer")]
	Developer,
    
	[Description("WorldrendSupporter")]
	WorldrendSupporter,
    
	[Description("RiftbornSupporter")]
	RiftbornSupporter,
    
	[Description("AtherionSupporter")]
	AtherionSupporter,
}

public static class ChatIconOptionExtensions
{
	public static string ToDescriptionString(this ChatIconOption val)
	{
		var attributes = (DescriptionAttribute[]) val
			.GetType()
			.GetField(val.ToString())
			.GetCustomAttributes(typeof(DescriptionAttribute), false);
		return attributes.Length > 0 ? attributes[0].Description : string.Empty;
	}
}