using BattleLib;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class BattleTelemetryCollector : IDispatchHandler<DBattleAbilityCastResultAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1053DC0", Offset="0x1053DC0")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1053DD0", Offset="0x1053DD0")]
	[FieldOffset(Offset="0x18")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x1053DE0", Offset="0x1053DE0")]
	[FieldOffset(Offset="0x20")]
	private ABattle _battle;

	[FieldOffset(Offset="0x28")]
	private Dictionary<ulong, BattleTelemetryCollector.AbilityDefTelemetry> _abilities;

	[Address(RVA="0x1295BA8", Offset="0x1295BA8", VA="0x1295BA8")]
	public BattleTelemetryCollector()
	{
	}

	[Address(RVA="0x1294CD0", Offset="0x1294CD0", VA="0x1294CD0")]
	public int GetTotalUsedAbilityCount()
	{
		return new int();
	}

	[Address(RVA="0x1294E1C", Offset="0x1294E1C", VA="0x1294E1C")]
	public List<object> GetUsedAbilitiesData()
	{
		return null;
	}

	[Address(RVA="0x129542C", Offset="0x129542C", VA="0x129542C", Slot="4")]
	public void HandleDispatchAction(DBattleAbilityCastResultAction action)
	{
	}

	[Address(RVA="0x1294C60", Offset="0x1294C60", VA="0x1294C60")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1294C98", Offset="0x1294C98", VA="0x1294C98")]
	public void Shutdown()
	{
	}

	private class AbilityDefTelemetry
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong DefinitionId;

		[FieldOffset(Offset="0x18")]
		public int TotalCastCount;

		[FieldOffset(Offset="0x20")]
		private Dictionary<byte, BattleTelemetryCollector.AbilityTelemetry> _abilities;

		public IEnumerable<BattleTelemetryCollector.AbilityTelemetry> Abilities
		{
			[Address(RVA="0x12953CC", Offset="0x12953CC", VA="0x12953CC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1295A0C", Offset="0x1295A0C", VA="0x1295A0C")]
		public AbilityDefTelemetry(ulong defId)
		{
		}

		[Address(RVA="0x1295A90", Offset="0x1295A90", VA="0x1295A90")]
		public void RecordCast(byte index)
		{
		}
	}

	private class AbilityTelemetry
	{
		[FieldOffset(Offset="0x10")]
		public readonly byte Index;

		[FieldOffset(Offset="0x14")]
		public int CastCount;

		[Address(RVA="0x1295C18", Offset="0x1295C18", VA="0x1295C18")]
		public AbilityTelemetry(byte index)
		{
		}
	}
}