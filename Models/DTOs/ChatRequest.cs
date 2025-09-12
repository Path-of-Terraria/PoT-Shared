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
	private ChatColorOption(string value) { Value = value; }

	public string Value { get; private set; }

	public static ChatColorOption Supporter => new ChatColorOption("#1abc9c");
	public static ChatColorOption ProSupporter => new ChatColorOption("#9b59b6");
	public static ChatColorOption EliteSupporter => new ChatColorOption("#e74c3c");
	public static ChatColorOption UltimateSupporter => new ChatColorOption("#9fc1ff");
	public static ChatColorOption Developer => new ChatColorOption("#1e86fe");
	public static ChatColorOption ScottieKnowz => new ChatColorOption("#aa3b3b");

	public override string ToString()
	{
		return Value;
	}
}

public class ChatIconOption
{
	private ChatIconOption(string value) { Value = value; }

	public string Value { get; private set; }

	public static ChatIconOption Developer => new ChatIconOption("Developer");
	public static ChatIconOption WorldrendSupporter => new ChatIconOption("WorldrendSupporter");
	public static ChatIconOption RiftbornSupporter => new ChatIconOption("RiftbornSupporter");
	public static ChatIconOption AtherionSupporter => new ChatIconOption("AtherionSupporter");

	public override string ToString()
	{
		return Value;
	}
}