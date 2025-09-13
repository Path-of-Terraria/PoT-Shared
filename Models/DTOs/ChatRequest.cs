using System;
using PoTSharedModules.Models.SocketMessages;

namespace PoTSharedModules.Models.DTOs;

public class ChatRequest
{
	public required GlobalChatMessageType Type { get; set; }
	public required string SteamId { get; set; }
	public required string Message { get; set; }
	public required string PlayerName { get; set; }
	public string? PlayerColor { get; set; }
	public string? PlayerIcon { get; set; }
}

public class ChatColorOption
{
	public ChatColorOption() {}
	private ChatColorOption(string value) { Value = value; }

	public string Value { get; set; }

	public static ChatColorOption Supporter => new("#1abc9c");
	public static ChatColorOption ProSupporter => new("#9b59b6");
	public static ChatColorOption EliteSupporter => new("#e74c3c");
	public static ChatColorOption UltimateSupporter => new("#9fc1ff");
	public static ChatColorOption Developer => new("#1e86fe");
	public static ChatColorOption ScottieKnowz => new("#aa3b3b");

	public override string ToString()
	{
		return Value;
	}

	public static ChatColorOption? ToChatColorOption(string? value)
	{
		if (string.IsNullOrWhiteSpace(value)) return null;
		if (string.Equals(value, Supporter.ToString(), StringComparison.OrdinalIgnoreCase))
			return Supporter;
		if (string.Equals(value, ProSupporter.ToString(), StringComparison.OrdinalIgnoreCase))
			return ProSupporter;
		if (string.Equals(value, EliteSupporter.ToString(), StringComparison.OrdinalIgnoreCase))
			return EliteSupporter;
		if (string.Equals(value, UltimateSupporter.ToString(), StringComparison.OrdinalIgnoreCase))
			return UltimateSupporter;
		return null;
	}
}

public class ChatIconOption
{
	public ChatIconOption() {}
	private ChatIconOption(string value) { Value = value; }

	public string Value { get; set; }

	public static ChatIconOption Developer => new("Developer");
	public static ChatIconOption WorldrendSupporter => new("WorldrendSupporter");
	public static ChatIconOption RiftbornSupporter => new("RiftbornSupporter");
	public static ChatIconOption AtherionSupporter => new("AtherionSupporter");

	public override string ToString()
	{
		return Value;
	}
	
	public static ChatIconOption? ToChatIconOption(string? value)
	{
		if (string.IsNullOrWhiteSpace(value)) return null;
		if (string.Equals(value, AtherionSupporter.ToString(), StringComparison.OrdinalIgnoreCase))
			return AtherionSupporter;
		if (string.Equals(value, WorldrendSupporter.ToString(), StringComparison.OrdinalIgnoreCase))
			return WorldrendSupporter;
		if (string.Equals(value, RiftbornSupporter.ToString(), StringComparison.OrdinalIgnoreCase))
			return RiftbornSupporter;
		return null;
	}
}