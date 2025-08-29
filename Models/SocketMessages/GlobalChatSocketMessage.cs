namespace PoTSharedModules.Models.SocketMessages;

public class GlobalChatSocketMessage
{
    public GlobalChatMessageType Type { get; set; }
    public required string SteamId { get; set; }
    public required string Message { get; set; }
    public required string PlayerName { get; set; }
    public string? PlayerColor { get; set; }
    public string? PlayerIcon { get; set; }
}

public enum GlobalChatMessageType
{
    Global,
    Whisper
}