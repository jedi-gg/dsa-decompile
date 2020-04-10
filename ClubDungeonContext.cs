using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubDungeonContext
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056848", Offset="0x1056848")]
	[FieldOffset(Offset="0x10")]
	private Serverproto.Club <Club>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056858", Offset="0x1056858")]
	[FieldOffset(Offset="0x18")]
	private ClubDungeon <DungeonData>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056868", Offset="0x1056868")]
	[FieldOffset(Offset="0x20")]
	private ClubDungeonStatus <Status>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056878", Offset="0x1056878")]
	[FieldOffset(Offset="0x28")]
	private ulong <CurrentNodeId>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056888", Offset="0x1056888")]
	[FieldOffset(Offset="0x30")]
	private ulong <CurrentRewardsNodeId>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056898", Offset="0x1056898")]
	[FieldOffset(Offset="0x38")]
	private ClubDungeonState <CurrentState>k__BackingField;

	[FieldOffset(Offset="0x40")]
	private Dictionary<ulong, List<PlayerProfileSimple>> _profilesByNodeId;

	[FieldOffset(Offset="0x48")]
	private Dictionary<ulong, ClubDungeonNode> _nodesById;

	public Serverproto.Club Club
	{
		[Address(RVA="0x11A7E14", Offset="0x11A7E14", VA="0x11A7E14")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF64", Offset="0x106EF64")]
		get
		{
			return null;
		}
		[Address(RVA="0x11A7E1C", Offset="0x11A7E1C", VA="0x11A7E1C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF74", Offset="0x106EF74")]
		set
		{
		}
	}

	public ulong CurrentNodeId
	{
		[Address(RVA="0x11A7E44", Offset="0x11A7E44", VA="0x11A7E44")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EFC4", Offset="0x106EFC4")]
		get
		{
			return new ulong();
		}
		[Address(RVA="0x11A7E4C", Offset="0x11A7E4C", VA="0x11A7E4C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EFD4", Offset="0x106EFD4")]
		private set
		{
		}
	}

	public ulong CurrentRewardsNodeId
	{
		[Address(RVA="0x11A7E54", Offset="0x11A7E54", VA="0x11A7E54")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EFE4", Offset="0x106EFE4")]
		get
		{
			return new ulong();
		}
		[Address(RVA="0x11A7E5C", Offset="0x11A7E5C", VA="0x11A7E5C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EFF4", Offset="0x106EFF4")]
		private set
		{
		}
	}

	public ClubDungeonState CurrentState
	{
		[Address(RVA="0x11A7E64", Offset="0x11A7E64", VA="0x11A7E64")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F004", Offset="0x106F004")]
		get
		{
			return new ClubDungeonState();
		}
		[Address(RVA="0x11A7E6C", Offset="0x11A7E6C", VA="0x11A7E6C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F014", Offset="0x106F014")]
		private set
		{
		}
	}

	public ClubDungeon DungeonData
	{
		[Address(RVA="0x11A7E24", Offset="0x11A7E24", VA="0x11A7E24")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF84", Offset="0x106EF84")]
		get
		{
			return null;
		}
		[Address(RVA="0x11A7E2C", Offset="0x11A7E2C", VA="0x11A7E2C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF94", Offset="0x106EF94")]
		set
		{
		}
	}

	public bool HasActiveBonus
	{
		[Address(RVA="0x11A7E94", Offset="0x11A7E94", VA="0x11A7E94")]
		get
		{
			return new bool();
		}
	}

	public bool HasData
	{
		[Address(RVA="0x11A7E74", Offset="0x11A7E74", VA="0x11A7E74")]
		get
		{
			return new bool();
		}
	}

	public ClubDungeonStatus Status
	{
		[Address(RVA="0x11A7E34", Offset="0x11A7E34", VA="0x11A7E34")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EFA4", Offset="0x106EFA4")]
		get
		{
			return null;
		}
		[Address(RVA="0x11A7E3C", Offset="0x11A7E3C", VA="0x11A7E3C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EFB4", Offset="0x106EFB4")]
		set
		{
		}
	}

	[Address(RVA="0x11A91C0", Offset="0x11A91C0", VA="0x11A91C0")]
	public ClubDungeonContext()
	{
	}

	[Address(RVA="0x11A8AD8", Offset="0x11A8AD8", VA="0x11A8AD8")]
	private void BuildNodeLookup()
	{
	}

	[Address(RVA="0x11A840C", Offset="0x11A840C", VA="0x11A840C")]
	private void BuildPlayerProfileLookup()
	{
	}

	[Address(RVA="0x11A80A8", Offset="0x11A80A8", VA="0x11A80A8")]
	private void CacheNodeIds()
	{
	}

	[Address(RVA="0x11A90B8", Offset="0x11A90B8", VA="0x11A90B8")]
	public List<PlayerProfileSimple> FindPlayers(ulong nodeId)
	{
		return null;
	}

	[Address(RVA="0x11A9138", Offset="0x11A9138", VA="0x11A9138")]
	public ClubDungeonNode GetNode(ulong nodeId)
	{
		return null;
	}

	[Address(RVA="0x11A7ED0", Offset="0x11A7ED0", VA="0x11A7ED0")]
	public void Initialize()
	{
	}

	[Address(RVA="0x11A91B8", Offset="0x11A91B8", VA="0x11A91B8")]
	public void InvalidateDungeonState()
	{
	}

	[Address(RVA="0x11A9028", Offset="0x11A9028", VA="0x11A9028")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11A7F2C", Offset="0x11A7F2C", VA="0x11A7F2C")]
	private void UpdateDungeonState()
	{
	}
}