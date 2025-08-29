namespace PoTSharedModules.Models.SocketMessages;

public sealed record SocketMessage<T>(
    SocketMessageType Type,
    T Payload,
    DateTimeOffset SentAt
);

public enum SocketMessageType
{
    Trade,
    Chat
}