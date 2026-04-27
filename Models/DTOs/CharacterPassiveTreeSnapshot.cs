using System;
using System.Collections.Generic;

namespace PoTSharedModules.Models.DTOs;

public class CharacterPassiveTreeSnapshot
{
	public DateTime CapturedAt { get; set; }
	public string? ModVersion { get; set; }
	public int Points { get; set; }
	public int ExtraPoints { get; set; }
	public required List<PassiveTreeNodeSnapshot> AllocatedNodes { get; set; } = [];
}

public class PassiveTreeNodeSnapshot
{
	public int ReferenceId { get; set; }
	public required string InternalIdentifier { get; set; }
	public int Level { get; set; }
}
