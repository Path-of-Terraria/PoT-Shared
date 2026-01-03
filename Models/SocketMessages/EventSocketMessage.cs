namespace PoTSharedModules.Models.SocketMessages;

public class EventSocketMessage
{
    public EventSocketMessageType Type { get; set; }
    public required string PlayerName { get; set; }
    public required string Message { get; set; }
}

public enum EventSocketMessageType {
    WorldFirst,
}