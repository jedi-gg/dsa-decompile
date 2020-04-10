using Glunies;
using Il2CppDummyDll;
using System;

public class MultiplayerRecovery : ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054380", Offset="0x1054380")]
	[FieldOffset(Offset="0x10")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1054390", Offset="0x1054390")]
	[FieldOffset(Offset="0x18")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10543A0", Offset="0x10543A0")]
	[FieldOffset(Offset="0x20")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x10543B0", Offset="0x10543B0")]
	[FieldOffset(Offset="0x28")]
	private TitleController _titleController;

	[Attribute(Name="InjectAttribute", RVA="0x10543C0", Offset="0x10543C0")]
	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x10543D0", Offset="0x10543D0")]
	[FieldOffset(Offset="0x38")]
	private GamedataManager _gamedataManager;

	[Attribute(Name="InjectAttribute", RVA="0x10543E0", Offset="0x10543E0")]
	[FieldOffset(Offset="0x40")]
	private AssetManager _assetManager;

	[FieldOffset(Offset="0x48")]
	private readonly TimeSpan RECOVERY_TIME_LIMIT;

	public LogCategory LogCategory
	{
		[Address(RVA="0x12FC920", Offset="0x12FC920", VA="0x12FC920", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x12FDAF4", Offset="0x12FDAF4", VA="0x12FDAF4")]
	public MultiplayerRecovery()
	{
	}

	[Address(RVA="0x12FD5B0", Offset="0x12FD5B0", VA="0x12FD5B0")]
	public void CacheRecoveryData(MultiplayerRecovery.MpType mpType, byte[] battlePayload)
	{
	}

	[Address(RVA="0x12FD9FC", Offset="0x12FD9FC", VA="0x12FD9FC")]
	public void ClearRecoveryData()
	{
	}

	[Address(RVA="0x12FCDE8", Offset="0x12FCDE8", VA="0x12FCDE8")]
	private MultiplayerRecovery.MpType GetMpTypeFromPrefix(string prefix)
	{
		return new MultiplayerRecovery.MpType();
	}

	[Address(RVA="0x12FD978", Offset="0x12FD978", VA="0x12FD978")]
	private string GetMpTypePrefix(MultiplayerRecovery.MpType mpType)
	{
		return null;
	}

	[Address(RVA="0x12FD8E4", Offset="0x12FD8E4", VA="0x12FD8E4")]
	private string GetPayloadCachePath(MultiplayerRecovery.MpType mpType)
	{
		return null;
	}

	[Address(RVA="0x12FCCC8", Offset="0x12FCCC8", VA="0x12FCCC8")]
	private string GetPayloadCachePath(string cacheFileNamePrefix)
	{
		return null;
	}

	[Address(RVA="0x12FCE94", Offset="0x12FCE94", VA="0x12FCE94")]
	private bool TransitionToBattle(MultiplayerRecovery.MpType mpType, byte[] battlePayload)
	{
		return new bool();
	}

	[Address(RVA="0x12FC928", Offset="0x12FC928", VA="0x12FC928")]
	public bool TryRecovery()
	{
		return new bool();
	}

	public enum MpType
	{
		[FieldOffset(Offset="0x0")]
		INVALID,
		[FieldOffset(Offset="0x0")]
		Pvp,
		[FieldOffset(Offset="0x0")]
		Koth,
		[FieldOffset(Offset="0x0")]
		ClubWar
	}
}