using System;
using System.Collections.Generic;

namespace PoTSharedModules.Models.DTOs;

public class ProfileResponse
{
    public required string Token { get; set; }
    public Guid Id { get; set; }
    public string? DiscordId { get; set; }
    public string? SteamId { get; set; }
    public string? GOGId { get; set; }
    public required string ProfileName { get; set; }
    public required string Email { get; set; }
    public required string LastName { get; set; }
    public string? Avatar { get; set; }
    
    public ChosenBenefits? ChosenBenefits { get; set; }

    // New fields: available chat icons and colors for the user
    public List<string>? AvailableChatIcons { get; set; }
    public List<string>? AvailableChatColors { get; set; }
}

public record ChosenBenefits
{
	public ChatIconOption? ChatIcon { get; set; }
	public ChatColorOption? ChatColor { get; set; }
}