using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public static class Chronos
{
	[FieldOffset(Offset="0x0")]
	public static TimeSync TimeSync;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1055DA8", Offset="0x1055DA8")]
	[FieldOffset(Offset="0x8")]
	private static bool <AllowTimeScaleManipulation>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1055DB8", Offset="0x1055DB8")]
	[FieldOffset(Offset="0xC")]
	private static float <BattleTimeScale>k__BackingField;

	[FieldOffset(Offset="0x10")]
	public static float BattleClockS;

	[FieldOffset(Offset="0x0")]
	public const float MAX_DELTA_TIME_S = 0.25f;

	[FieldOffset(Offset="0x0")]
	public const uint INVALID_TIME_SCALE_ID = 0;

	[FieldOffset(Offset="0x0")]
	public const int DEFAULT_BATTLE_TIME_SCALE_PRIORITY = 0;

	[FieldOffset(Offset="0x0")]
	public const int AUTOBATTLE_TIME_SCALE_PRIORITY = 99;

	[FieldOffset(Offset="0x0")]
	public const int ABILITY_CAST_TIME_SCALE_PRIORITY = 100;

	[FieldOffset(Offset="0x0")]
	public const int SEQUENCER_TIME_SCALE_PRIORITY = 110;

	[FieldOffset(Offset="0x0")]
	public const int BATTLE_CATCHUP_SCALE_PRIORITY = 125;

	[FieldOffset(Offset="0x0")]
	public const int BATTLE_MENU_TIME_SCALE_PRIORITY = 150;

	[FieldOffset(Offset="0x0")]
	public const int TUTORIAL_TIME_SCALE_PRIORITY = 200;

	[FieldOffset(Offset="0x0")]
	public const int KILLING_BLOW_TIME_SCALE_PRIORITY = 250;

	[FieldOffset(Offset="0x0")]
	public const int BATTLE_QUIT_TIME_SCALE_PRIORITY = 300;

	[FieldOffset(Offset="0x0")]
	public const int DAYS_IN_WEEK = 7;

	[FieldOffset(Offset="0x0")]
	public const int SECONDS_IN_DAY = 86400;

	[FieldOffset(Offset="0x0")]
	public const int MINUTE_TO_SECONDS = 60;

	[FieldOffset(Offset="0x0")]
	public const int HOUR_TO_SECONDS = 3600;

	[FieldOffset(Offset="0x0")]
	private const int MAX_ACTICE_TIME_SCALE_POOL_SIZE = 10;

	[FieldOffset(Offset="0x18")]
	private static List<Chronos.ActiveTimeScale> s_activeTimeScales;

	[FieldOffset(Offset="0x20")]
	private static Queue<Chronos.ActiveTimeScale> s_timeScalesPool;

	[FieldOffset(Offset="0x28")]
	private static uint s_nextTimeScaleId;

	public static bool AllowTimeScaleManipulation
	{
		[Address(RVA="0x11A3E30", Offset="0x11A3E30", VA="0x11A3E30")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EAFC", Offset="0x106EAFC")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x11A3E98", Offset="0x11A3E98", VA="0x11A3E98")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB0C", Offset="0x106EB0C")]
		set
		{
		}
	}

	public static float BattleDeltaTimeS
	{
		[Address(RVA="0x1196C80", Offset="0x1196C80", VA="0x1196C80")]
		get
		{
			return new float();
		}
	}

	public static float BattleTimeScale
	{
		[Address(RVA="0x11A3F94", Offset="0x11A3F94", VA="0x11A3F94")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB1C", Offset="0x106EB1C")]
		get
		{
			return new float();
		}
		[Address(RVA="0x11A3FFC", Offset="0x11A3FFC", VA="0x11A3FFC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB2C", Offset="0x106EB2C")]
		private set
		{
		}
	}

	public static long BattleTimeStepMs
	{
		[Address(RVA="0x11A4070", Offset="0x11A4070", VA="0x11A4070")]
		get
		{
			return new long();
		}
	}

	public static DateTime CurrentRealTimeUtc
	{
		[Address(RVA="0x11A3DC8", Offset="0x11A3DC8", VA="0x11A3DC8")]
		get
		{
			return new DateTime();
		}
	}

	public static float DeltaTimeS
	{
		[Address(RVA="0x118C348", Offset="0x118C348", VA="0x118C348")]
		get
		{
			return new float();
		}
	}

	public static int FrameCount
	{
		[Address(RVA="0x11A3E28", Offset="0x11A3E28", VA="0x11A3E28")]
		get
		{
			return new int();
		}
	}

	public static float RealtimeSinceStartup
	{
		[Address(RVA="0x11A3F84", Offset="0x11A3F84", VA="0x11A3F84")]
		get
		{
			return new float();
		}
	}

	public static DateTime SyncedRealTimeUtc
	{
		[Address(RVA="0x1188408", Offset="0x1188408", VA="0x1188408")]
		get
		{
			return new DateTime();
		}
	}

	public static float TimeScale
	{
		[Address(RVA="0x11A3F8C", Offset="0x11A3F8C", VA="0x11A3F8C")]
		get
		{
			return new float();
		}
	}

	public static float UnscaledDeltaTimeS
	{
		[Address(RVA="0x11A3F08", Offset="0x11A3F08", VA="0x11A3F08")]
		get
		{
			return new float();
		}
	}

	public static float UnscaledUnityClockS
	{
		[Address(RVA="0x119DDD8", Offset="0x119DDD8", VA="0x119DDD8")]
		get
		{
			return new float();
		}
	}

	[Address(RVA="0x11A5608", Offset="0x11A5608", VA="0x11A5608")]
	static Chronos()
	{
	}

	[Address(RVA="0x11A49FC", Offset="0x11A49FC", VA="0x11A49FC")]
	public static uint BeginTimeScale(float timeScale, int priority = 0)
	{
		return new uint();
	}

	[Address(RVA="0x11A4EBC", Offset="0x11A4EBC", VA="0x11A4EBC")]
	public static void EndTimeScale(uint id)
	{
	}

	[Address(RVA="0x11A47A4", Offset="0x11A47A4", VA="0x11A47A4")]
	public static DateTime FromServerTimestampMS(ulong serverTimestampMS)
	{
		return new DateTime();
	}

	[Address(RVA="0x118849C", Offset="0x118849C", VA="0x118849C")]
	public static DateTime FromServerTimestampS(ulong serverTimestampS)
	{
		return new DateTime();
	}

	[Address(RVA="0x11A4840", Offset="0x11A4840", VA="0x11A4840")]
	public static DateTime FromServerTimestampS(long serverTimestampS)
	{
		return new DateTime();
	}

	[Address(RVA="0x11A4CF4", Offset="0x11A4CF4", VA="0x11A4CF4")]
	private static Chronos.ActiveTimeScale GetActiveTimeScale(uint id, float timeScale, int priority)
	{
		return null;
	}

	[Address(RVA="0x11A4904", Offset="0x11A4904", VA="0x11A4904")]
	public static int GetElapsedSecondsInDay(DateTime dateTime)
	{
		return new int();
	}

	[Address(RVA="0x11A4968", Offset="0x11A4968", VA="0x11A4968")]
	public static DateTime GetNextDateTimeMultiple(DateTime startingDateTime, int secondsMultiple)
	{
		return new DateTime();
	}

	[Address(RVA="0x11A4078", Offset="0x11A4078", VA="0x11A4078")]
	public static string GetSystemTimeZone()
	{
		return null;
	}

	[Address(RVA="0x11A427C", Offset="0x11A427C", VA="0x11A427C")]
	public static List<string> GetSystemTimeZoneIds()
	{
		return null;
	}

	[Address(RVA="0x11A4510", Offset="0x11A4510", VA="0x11A4510")]
	public static List<string> GetTimeZoneNames()
	{
		return null;
	}

	[Address(RVA="0x11A5430", Offset="0x11A5430", VA="0x11A5430")]
	public static void ModifyTimeScale(uint id, float timeScale)
	{
	}

	[Address(RVA="0x11A5180", Offset="0x11A5180", VA="0x11A5180")]
	private static void ReleaseActiveTimeScale(Chronos.ActiveTimeScale ats)
	{
	}

	[Address(RVA="0x11A5270", Offset="0x11A5270", VA="0x11A5270")]
	public static void ResetTimeScale()
	{
	}

	[Address(RVA="0x11A4E44", Offset="0x11A4E44", VA="0x11A4E44")]
	private static void SetTimeScale(float timeScale)
	{
	}

	[Address(RVA="0x11A48DC", Offset="0x11A48DC", VA="0x11A48DC")]
	public static DateTime ToLocalTime(DateTime dateTime)
	{
		return new DateTime();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B5CC", Offset="0x104B5CC")]
	private sealed class <>c__DisplayClass55_0
	{
		[FieldOffset(Offset="0x10")]
		public uint id;

		[Address(RVA="0x1D380BC", Offset="0x1D380BC", VA="0x1D380BC")]
		public <>c__DisplayClass55_0()
		{
		}

		[Address(RVA="0x1D380C4", Offset="0x1D380C4", VA="0x1D380C4")]
		internal bool <EndTimeScale>b__0(Chronos.ActiveTimeScale t)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B5DC", Offset="0x104B5DC")]
	private sealed class <>c__DisplayClass56_0
	{
		[FieldOffset(Offset="0x10")]
		public uint id;

		[Address(RVA="0x1D38100", Offset="0x1D38100", VA="0x1D38100")]
		public <>c__DisplayClass56_0()
		{
		}

		[Address(RVA="0x1D38108", Offset="0x1D38108", VA="0x1D38108")]
		internal bool <ModifyTimeScale>b__0(Chronos.ActiveTimeScale t)
		{
			return new bool();
		}
	}

	private class ActiveTimeScale
	{
		[FieldOffset(Offset="0x10")]
		public uint Id;

		[FieldOffset(Offset="0x14")]
		public float TimeScale;

		[FieldOffset(Offset="0x18")]
		public int Priority;

		[Address(RVA="0x1D38144", Offset="0x1D38144", VA="0x1D38144")]
		public ActiveTimeScale()
		{
		}
	}
}