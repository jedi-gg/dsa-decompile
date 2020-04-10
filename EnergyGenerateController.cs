using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class EnergyGenerateController : IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DPlayerLevelUpAction>, IDispatchHandler<DGamedataDomainLoadedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1057CF4", Offset="0x1057CF4")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057D04", Offset="0x1057D04")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057D14", Offset="0x1057D14")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x28")]
	private List<EnergyGenerateController.EnergyGenerateData> _data;

	[Address(RVA="0x120E6A8", Offset="0x120E6A8", VA="0x120E6A8")]
	public EnergyGenerateController()
	{
	}

	[Address(RVA="0x120D814", Offset="0x120D814", VA="0x120D814")]
	private EnergyGenerateController.EnergyGenerateData FindEnergyData(ulong energyItemId)
	{
		return null;
	}

	[Address(RVA="0x120D5A4", Offset="0x120D5A4", VA="0x120D5A4")]
	public uint GetGeneratedCap(ulong energyItemId)
	{
		return new uint();
	}

	[Address(RVA="0x120D5F4", Offset="0x120D5F4", VA="0x120D5F4")]
	private uint GetGeneratedCap(ulong energyItemId, Player player)
	{
		return new uint();
	}

	[Address(RVA="0x120D780", Offset="0x120D780", VA="0x120D780")]
	public DateTime GetNextGenerateDateTimeUtc(ulong energyItemId)
	{
		return new DateTime();
	}

	[Address(RVA="0x120D94C", Offset="0x120D94C", VA="0x120D94C")]
	public long GetPveEnergyFullEtaSeconds()
	{
		return new long();
	}

	[Address(RVA="0x120DC4C", Offset="0x120DC4C", VA="0x120DC4C", Slot="4")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x120E0C0", Offset="0x120E0C0", VA="0x120E0C0", Slot="5")]
	public void HandleDispatchAction(DPlayerLevelUpAction action)
	{
	}

	[Address(RVA="0x120E1F0", Offset="0x120E1F0", VA="0x120E1F0", Slot="6")]
	public void HandleDispatchAction(DGamedataDomainLoadedAction action)
	{
	}

	[Address(RVA="0x120CF98", Offset="0x120CF98", VA="0x120CF98")]
	public void Initialize()
	{
	}

	[Address(RVA="0x120E3E4", Offset="0x120E3E4", VA="0x120E3E4")]
	private void SetEnergyData(ulong energyItemId, ulong energyConstantsId)
	{
	}

	[Address(RVA="0x120E5F4", Offset="0x120E5F4", VA="0x120E5F4")]
	private void SetNextGenerateTimeUtc(EnergyGenerateController.EnergyGenerateData energyData)
	{
	}

	[Address(RVA="0x120CFD0", Offset="0x120CFD0", VA="0x120CFD0")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x120D050", Offset="0x120D050", VA="0x120D050")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x120D1A0", Offset="0x120D1A0", VA="0x120D1A0")]
	private void TryGenerateEnergy(EnergyGenerateController.EnergyGenerateData energyData, DateTime nextGenerateTimeUtc)
	{
	}

	private class EnergyGenerateData
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong EnergyItemId;

		[FieldOffset(Offset="0x18")]
		public readonly ulong EnergyConstantsId;

		[FieldOffset(Offset="0x20")]
		public uint GeneratedFrequencySeconds;

		[FieldOffset(Offset="0x24")]
		public uint GeneratedAmount;

		[FieldOffset(Offset="0x28")]
		public uint BonusGeneratedAmount;

		[FieldOffset(Offset="0x2C")]
		public uint GeneratedCap;

		[FieldOffset(Offset="0x30")]
		public DateTime NextGenerateTimeUtc;

		[Address(RVA="0x120E5BC", Offset="0x120E5BC", VA="0x120E5BC")]
		public EnergyGenerateData(ulong energyItemId, ulong energyConstantsId)
		{
		}
	}
}