using System;
using System.Collections.Generic;

namespace PoTSharedModules.Models.DTOs;

public class CharacterGearSnapshot
{
	public DateTime CapturedAt { get; set; }
	public string? ModVersion { get; set; }
	public required List<GearSlotSnapshot> Slots { get; set; } = [];
}

public class GearSlotSnapshot
{
	public required string Slot { get; set; }
	public GearItemSnapshot? Item { get; set; }
}

public class GearItemSnapshot
{
	public required string SourceMod { get; set; }
	public required string InternalName { get; set; }
	public int TypeId { get; set; }
	public required string DisplayName { get; set; }
	public required string ItemType { get; set; }
	public required string Rarity { get; set; }
	public required string Influence { get; set; }
	public int ItemLevel { get; set; }
	public bool Corrupted { get; set; }
	public bool Cloned { get; set; }
	public int PrefixId { get; set; }
	public int SuffixId { get; set; }
	public int Damage { get; set; }
	public int Defense { get; set; }
	public int CritChance { get; set; }
	public float Knockback { get; set; }
	public int UseTime { get; set; }
	public int ManaCost { get; set; }
	public required List<GearAffixSnapshot> Affixes { get; set; } = [];
	public required List<string> AffixTextLines { get; set; } = [];
}

public class GearAffixSnapshot
{
	public required string AffixType { get; set; }
	public required string DisplayText { get; set; }
	public float Value { get; set; }
	public int Tier { get; set; }
	public bool IsImplicit { get; set; }
	public bool IsCorrupted { get; set; }
}
