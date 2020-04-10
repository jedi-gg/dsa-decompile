using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleSpawnPointComponent : MonoBehaviour, IMonoArchetypePooledItem
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053AC0", Offset="0x1053AC0")]
	[FieldOffset(Offset="0x18")]
	private int <SpawnIndex>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053AD0", Offset="0x1053AD0")]
	[FieldOffset(Offset="0x1C")]
	private int <TeamId>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053AE0", Offset="0x1053AE0")]
	[FieldOffset(Offset="0x20")]
	private bool <IsOccupied>k__BackingField;

	public bool IsOccupied
	{
		[Address(RVA="0x1293BE8", Offset="0x1293BE8", VA="0x1293BE8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E5A8", Offset="0x106E5A8")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x1293BF0", Offset="0x1293BF0", VA="0x1293BF0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E5B8", Offset="0x106E5B8")]
		set
		{
		}
	}

	public int SpawnIndex
	{
		[Address(RVA="0x1293BC8", Offset="0x1293BC8", VA="0x1293BC8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E568", Offset="0x106E568")]
		get
		{
			return new int();
		}
		[Address(RVA="0x1293BD0", Offset="0x1293BD0", VA="0x1293BD0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E578", Offset="0x106E578")]
		set
		{
		}
	}

	public int TeamId
	{
		[Address(RVA="0x1293BD8", Offset="0x1293BD8", VA="0x1293BD8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E588", Offset="0x106E588")]
		get
		{
			return new int();
		}
		[Address(RVA="0x1293BE0", Offset="0x1293BE0", VA="0x1293BE0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E598", Offset="0x106E598")]
		set
		{
		}
	}

	[Address(RVA="0x1293C14", Offset="0x1293C14", VA="0x1293C14")]
	public BattleSpawnPointComponent()
	{
	}

	[Address(RVA="0x1293BFC", Offset="0x1293BFC", VA="0x1293BFC", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1293C10", Offset="0x1293C10", VA="0x1293C10", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x1293C00", Offset="0x1293C00", VA="0x1293C00", Slot="5")]
	public void Shutdown()
	{
	}
}