using Il2CppDummyDll;
using System;

public class BattleConfig
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10530A4", Offset="0x10530A4")]
	[FieldOffset(Offset="0x10")]
	private float <DefaultTimeScale>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10530B4", Offset="0x10530B4")]
	[FieldOffset(Offset="0x14")]
	private bool <ShowRounds>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10530C4", Offset="0x10530C4")]
	[FieldOffset(Offset="0x15")]
	private bool <AutoBattleEnabled>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10530D4", Offset="0x10530D4")]
	[FieldOffset(Offset="0x16")]
	private bool <IgnoreAutoBattlePref>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10530E4", Offset="0x10530E4")]
	[FieldOffset(Offset="0x17")]
	private bool <BattleSpeedToggleEnabled>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10530F4", Offset="0x10530F4")]
	[FieldOffset(Offset="0x18")]
	private string <AutoBattleStartsOnPrefKey>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053104", Offset="0x1053104")]
	[FieldOffset(Offset="0x20")]
	private AutoBattle.Speed <DefaultBattleSpeed>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053114", Offset="0x1053114")]
	[FieldOffset(Offset="0x28")]
	private string <AutoBattleSpeedPlayerPrefKey>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053124", Offset="0x1053124")]
	[FieldOffset(Offset="0x30")]
	private bool <ShowCardsImmediately>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053134", Offset="0x1053134")]
	[FieldOffset(Offset="0x31")]
	private bool <AllowMenu>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053144", Offset="0x1053144")]
	[FieldOffset(Offset="0x32")]
	private bool <AllowQuit>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053154", Offset="0x1053154")]
	[FieldOffset(Offset="0x33")]
	private bool <AllowPause>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053164", Offset="0x1053164")]
	[FieldOffset(Offset="0x34")]
	private bool <ShowEnvironmentImmediately>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053174", Offset="0x1053174")]
	[FieldOffset(Offset="0x35")]
	private bool <AllowEmotes>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053184", Offset="0x1053184")]
	[FieldOffset(Offset="0x36")]
	private bool <PlayVictoryOnDefeat>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053194", Offset="0x1053194")]
	[FieldOffset(Offset="0x37")]
	private bool <AllowReversedPositions>k__BackingField;

	public bool AllowEmotes
	{
		[Address(RVA="0x113F3F8", Offset="0x113F3F8", VA="0x113F3F8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E488", Offset="0x106E488")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F400", Offset="0x113F400", VA="0x113F400")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E498", Offset="0x106E498")]
		private set
		{
		}
	}

	public bool AllowMenu
	{
		[Address(RVA="0x113F3A8", Offset="0x113F3A8", VA="0x113F3A8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E408", Offset="0x106E408")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F3B0", Offset="0x113F3B0", VA="0x113F3B0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E418", Offset="0x106E418")]
		private set
		{
		}
	}

	public bool AllowPause
	{
		[Address(RVA="0x113F3D0", Offset="0x113F3D0", VA="0x113F3D0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E448", Offset="0x106E448")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F3D8", Offset="0x113F3D8", VA="0x113F3D8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E458", Offset="0x106E458")]
		private set
		{
		}
	}

	public bool AllowQuit
	{
		[Address(RVA="0x113F3BC", Offset="0x113F3BC", VA="0x113F3BC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E428", Offset="0x106E428")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F3C4", Offset="0x113F3C4", VA="0x113F3C4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E438", Offset="0x106E438")]
		private set
		{
		}
	}

	public bool AllowReversedPositions
	{
		[Address(RVA="0x113F420", Offset="0x113F420", VA="0x113F420")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E4C8", Offset="0x106E4C8")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F428", Offset="0x113F428", VA="0x113F428")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E4D8", Offset="0x106E4D8")]
		private set
		{
		}
	}

	public bool AutoBattleEnabled
	{
		[Address(RVA="0x113F328", Offset="0x113F328", VA="0x113F328")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E328", Offset="0x106E328")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F330", Offset="0x113F330", VA="0x113F330")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E338", Offset="0x106E338")]
		private set
		{
		}
	}

	public string AutoBattleSpeedPlayerPrefKey
	{
		[Address(RVA="0x113F384", Offset="0x113F384", VA="0x113F384")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E3C8", Offset="0x106E3C8")]
		get
		{
			return null;
		}
		[Address(RVA="0x113F38C", Offset="0x113F38C", VA="0x113F38C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E3D8", Offset="0x106E3D8")]
		private set
		{
		}
	}

	public string AutoBattleStartsOnPrefKey
	{
		[Address(RVA="0x113F364", Offset="0x113F364", VA="0x113F364")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E388", Offset="0x106E388")]
		get
		{
			return null;
		}
		[Address(RVA="0x113F36C", Offset="0x113F36C", VA="0x113F36C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E398", Offset="0x106E398")]
		private set
		{
		}
	}

	public bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x113F350", Offset="0x113F350", VA="0x113F350")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E368", Offset="0x106E368")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F358", Offset="0x113F358", VA="0x113F358")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E378", Offset="0x106E378")]
		private set
		{
		}
	}

	public AutoBattle.Speed DefaultBattleSpeed
	{
		[Address(RVA="0x113F374", Offset="0x113F374", VA="0x113F374")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E3A8", Offset="0x106E3A8")]
		get
		{
			return new AutoBattle.Speed();
		}
		[Address(RVA="0x113F37C", Offset="0x113F37C", VA="0x113F37C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E3B8", Offset="0x106E3B8")]
		private set
		{
		}
	}

	public float DefaultTimeScale
	{
		[Address(RVA="0x113F304", Offset="0x113F304", VA="0x113F304")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E2E8", Offset="0x106E2E8")]
		get
		{
			return new float();
		}
		[Address(RVA="0x113F30C", Offset="0x113F30C", VA="0x113F30C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E2F8", Offset="0x106E2F8")]
		private set
		{
		}
	}

	public bool IgnoreAutoBattlePref
	{
		[Address(RVA="0x113F33C", Offset="0x113F33C", VA="0x113F33C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E348", Offset="0x106E348")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F344", Offset="0x113F344", VA="0x113F344")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E358", Offset="0x106E358")]
		private set
		{
		}
	}

	public bool PlayVictoryOnDefeat
	{
		[Address(RVA="0x113F40C", Offset="0x113F40C", VA="0x113F40C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E4A8", Offset="0x106E4A8")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F414", Offset="0x113F414", VA="0x113F414")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E4B8", Offset="0x106E4B8")]
		private set
		{
		}
	}

	public bool ShowCardsImmediately
	{
		[Address(RVA="0x113F394", Offset="0x113F394", VA="0x113F394")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E3E8", Offset="0x106E3E8")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F39C", Offset="0x113F39C", VA="0x113F39C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E3F8", Offset="0x106E3F8")]
		private set
		{
		}
	}

	public bool ShowEnvironmentImmediately
	{
		[Address(RVA="0x113F3E4", Offset="0x113F3E4", VA="0x113F3E4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E468", Offset="0x106E468")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F3EC", Offset="0x113F3EC", VA="0x113F3EC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E478", Offset="0x106E478")]
		private set
		{
		}
	}

	public bool ShowRounds
	{
		[Address(RVA="0x113F314", Offset="0x113F314", VA="0x113F314")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E308", Offset="0x106E308")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x113F31C", Offset="0x113F31C", VA="0x113F31C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E318", Offset="0x106E318")]
		private set
		{
		}
	}

	[Address(RVA="0x113F434", Offset="0x113F434", VA="0x113F434")]
	public BattleConfig()
	{
	}

	public static class Factory
	{
		[Address(RVA="0x113F4AC", Offset="0x113F4AC", VA="0x113F4AC")]
		public static BattleConfig Create(ABattleGameState battleGameState, FeatureLockController featureLockController)
		{
			return null;
		}
	}
}