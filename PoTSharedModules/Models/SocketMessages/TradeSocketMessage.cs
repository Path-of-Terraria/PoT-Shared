using System;

namespace PoTSharedModules.Models.SocketMessages;

public class TradeSocketMessage
{
    public TradeSocketMessageType Type { get; set; }
    public required string SteamId { get; set; }
    public required Guid ListingId { get; set; }
}

public enum TradeSocketMessageType {
    RequestSold,
}