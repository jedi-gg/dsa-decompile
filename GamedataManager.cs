using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class GamedataManager : ILoggable<LogCategory>, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10586A0", Offset="0x10586A0")]
	[FieldOffset(Offset="0x10")]
	private byte[] <BattleScript>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10586B0", Offset="0x10586B0")]
	[FieldOffset(Offset="0x18")]
	private string <LoadedVersion>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x10586C0", Offset="0x10586C0")]
	[FieldOffset(Offset="0x20")]
	private GamedataService _gamedataService;

	[Attribute(Name="InjectAttribute", RVA="0x10586D0", Offset="0x10586D0")]
	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10586E0", Offset="0x10586E0")]
	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x38")]
	private StaticGamedata? _staticGamedata;

	[FieldOffset(Offset="0x50")]
	private List<ulong> _variantIds;

	public byte[] BattleScript
	{
		[Address(RVA="0x14E9938", Offset="0x14E9938", VA="0x14E9938")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FBF4", Offset="0x106FBF4")]
		get
		{
			return null;
		}
		[Address(RVA="0x14E9940", Offset="0x14E9940", VA="0x14E9940")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC04", Offset="0x106FC04")]
		private set
		{
		}
	}

	public string LoadedVersion
	{
		[Address(RVA="0x14E9948", Offset="0x14E9948", VA="0x14E9948")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC14", Offset="0x106FC14")]
		get
		{
			return null;
		}
		[Address(RVA="0x14E9950", Offset="0x14E9950", VA="0x14E9950")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC24", Offset="0x106FC24")]
		private set
		{
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x14E9930", Offset="0x14E9930", VA="0x14E9930", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x14E9FC8", Offset="0x14E9FC8", VA="0x14E9FC8")]
	public GamedataManager()
	{
	}

	[Address(RVA="0x14E9D88", Offset="0x14E9D88", VA="0x14E9D88", Slot="5")]
	public void HandleDispatchAction(DPlayerChangeAction playerChangeAction)
	{
	}

	[Address(RVA="0x14E9958", Offset="0x14E9958", VA="0x14E9958")]
	public void Initialize()
	{
	}

	[Address(RVA="0x14E9A18", Offset="0x14E9A18", VA="0x14E9A18")]
	public void LoadGamedata(string contentUrl, string version, bool force, Action<FetchContentJob.FetchResult> finished)
	{
	}

	[Address(RVA="0x14E9990", Offset="0x14E9990", VA="0x14E9990")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BFCC", Offset="0x104BFCC")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public GamedataManager <>4__this;

		[FieldOffset(Offset="0x18")]
		public string version;

		[FieldOffset(Offset="0x20")]
		public Action<FetchContentJob.FetchResult> finished;

		[Address(RVA="0x14E9BC4", Offset="0x14E9BC4", VA="0x14E9BC4")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x14EA038", Offset="0x14EA038", VA="0x14EA038")]
		internal void <LoadGamedata>b__0(StaticGamedata gamedata)
		{
		}

		[Address(RVA="0x14EA2E4", Offset="0x14EA2E4", VA="0x14EA2E4")]
		internal void <LoadGamedata>b__1()
		{
		}
	}
}