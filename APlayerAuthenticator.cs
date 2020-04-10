using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public abstract class APlayerAuthenticator : IPlayerAuthenticator, ILoggable<LogCategory>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052610", Offset="0x1052610")]
	[FieldOffset(Offset="0x10")]
	private string <AuthToken>k__BackingField;

	[FieldOffset(Offset="0x0")]
	private const float AUTO_AUTH_TIMEOUT_DURATION_S = 10f;

	[Attribute(Name="InjectAttribute", RVA="0x1052620", Offset="0x1052620")]
	[FieldOffset(Offset="0x18")]
	protected DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1052630", Offset="0x1052630")]
	[FieldOffset(Offset="0x20")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x1052640", Offset="0x1052640")]
	[FieldOffset(Offset="0x28")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1052650", Offset="0x1052650")]
	[FieldOffset(Offset="0x30")]
	private IGameServiceTransport _gameServiceTransport;

	[Attribute(Name="InjectAttribute", RVA="0x1052660", Offset="0x1052660")]
	[FieldOffset(Offset="0x38")]
	private RevSdkController _revSdk;

	[Attribute(Name="InjectAttribute", RVA="0x1052670", Offset="0x1052670")]
	[FieldOffset(Offset="0x40")]
	private Core _coreService;

	[Attribute(Name="InjectAttribute", RVA="0x1052680", Offset="0x1052680")]
	[FieldOffset(Offset="0x48")]
	private HelpshiftController _helpshiftController;

	[Attribute(Name="InjectAttribute", RVA="0x1052690", Offset="0x1052690")]
	[FieldOffset(Offset="0x50")]
	private ANotificationController _notificationController;

	[Attribute(Name="InjectAttribute", RVA="0x10526A0", Offset="0x10526A0")]
	[FieldOffset(Offset="0x58")]
	private GameLanguageManager _gameLanguageManager;

	[FieldOffset(Offset="0x60")]
	protected bool _doAnonAuth;

	[FieldOffset(Offset="0x64")]
	private float? _autoAuthTimeout;

	protected abstract AuthType AnonymousAuthType
	{
		get;
	}

	public string AuthToken
	{
		[Address(RVA="0x10EF5BC", Offset="0x10EF5BC", VA="0x10EF5BC", Slot="4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E028", Offset="0x106E028")]
		get
		{
			return JustDecompileGenerated_get_AuthToken();
		}
		[Address(RVA="0x10EF5C4", Offset="0x10EF5C4", VA="0x10EF5C4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E038", Offset="0x106E038")]
		set
		{
			JustDecompileGenerated_set_AuthToken(value);
		}
	}

	public string JustDecompileGenerated_get_AuthToken()
	{
		return null;
	}

	private void JustDecompileGenerated_set_AuthToken(string value)
	{
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x10EF5B4", Offset="0x10EF5B4", VA="0x10EF5B4", Slot="8")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x10F01BC", Offset="0x10F01BC", VA="0x10F01BC")]
	protected APlayerAuthenticator()
	{
	}

	public abstract void AutoAuthenticate(Action<bool> completed);

	[Address(RVA="0x10EF7E8", Offset="0x10EF7E8", VA="0x10EF7E8", Slot="12")]
	protected virtual void AutoAuthTimedOut()
	{
	}

	[Address(RVA="0x10EF740", Offset="0x10EF740", VA="0x10EF740")]
	protected void ClearTimeoutTimer()
	{
	}

	[Address(RVA="0x10EF7EC", Offset="0x10EF7EC", VA="0x10EF7EC", Slot="13")]
	protected virtual string GetCachedDeviceId()
	{
		return null;
	}

	[Address(RVA="0x10EFA0C", Offset="0x10EFA0C", VA="0x10EFA0C")]
	private string GetTimezone()
	{
		return null;
	}

	[Address(RVA="0x10EF89C", Offset="0x10EF89C", VA="0x10EF89C")]
	private void InitTransport(AuthType authType, string authToken, Action<bool> completed)
	{
	}

	[Address(RVA="0x10F0010", Offset="0x10F0010", VA="0x10F0010")]
	private void RequestAdvertisingIdentifier(Action<string> completed)
	{
	}

	[Address(RVA="0x10EFA6C", Offset="0x10EFA6C", VA="0x10EFA6C")]
	protected void RequestPlayerRecord(AuthTokenRequest authReq, Action<bool> completed)
	{
	}

	[Address(RVA="0x10EFEB4", Offset="0x10EFEB4", VA="0x10EFEB4")]
	protected void RequestPlayerRecordViaAnonymousId(Action<bool> completed)
	{
	}

	[Address(RVA="0x10EF5CC", Offset="0x10EF5CC", VA="0x10EF5CC", Slot="10")]
	public virtual void Shutdown()
	{
	}

	[Address(RVA="0x10EF748", Offset="0x10EF748", VA="0x10EF748")]
	protected void StartTimeoutTimer()
	{
	}

	[Address(RVA="0x10EF5D0", Offset="0x10EF5D0", VA="0x10EF5D0", Slot="11")]
	public virtual void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AEAC", Offset="0x104AEAC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static APlayerAuthenticator.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__13_3;

		[FieldOffset(Offset="0x10")]
		public static Func<bool> <>9__15_2;

		[Address(RVA="0x10F01C4", Offset="0x10F01C4", VA="0x10F01C4")]
		static <>c()
		{
		}

		[Address(RVA="0x10F0228", Offset="0x10F0228", VA="0x10F0228")]
		public <>c()
		{
		}

		[Address(RVA="0x10F0230", Offset="0x10F0230", VA="0x10F0230")]
		internal bool <InitTransport>b__13_3()
		{
			return new bool();
		}

		[Address(RVA="0x10F0238", Offset="0x10F0238", VA="0x10F0238")]
		internal bool <RequestPlayerRecord>b__15_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE9C", Offset="0x104AE9C")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public Action<bool> completed;

		[FieldOffset(Offset="0x18")]
		public APlayerAuthenticator <>4__this;

		[FieldOffset(Offset="0x20")]
		public Action<PlayerResponse> <>9__1;

		[FieldOffset(Offset="0x28")]
		public Action<long> <>9__2;

		[Address(RVA="0x10EFA04", Offset="0x10EFA04", VA="0x10EFA04")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x10F0240", Offset="0x10F0240", VA="0x10F0240")]
		internal void <InitTransport>b__0(bool success)
		{
		}

		[Address(RVA="0x10F0458", Offset="0x10F0458", VA="0x10F0458")]
		internal void <InitTransport>b__1(PlayerResponse response)
		{
		}

		[Address(RVA="0x10F04BC", Offset="0x10F04BC", VA="0x10F04BC")]
		internal void <InitTransport>b__2(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AEBC", Offset="0x104AEBC")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public APlayerAuthenticator <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action<bool> completed;

		[FieldOffset(Offset="0x20")]
		public AuthTokenRequest authReq;

		[Address(RVA="0x10EFEAC", Offset="0x10EFEAC", VA="0x10EFEAC")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x10F059C", Offset="0x10F059C", VA="0x10F059C")]
		internal void <RequestPlayerRecord>b__0(AuthTokenResponse resp)
		{
		}

		[Address(RVA="0x10F082C", Offset="0x10F082C", VA="0x10F082C")]
		internal void <RequestPlayerRecord>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AECC", Offset="0x104AECC")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset="0x10")]
		public APlayerAuthenticator <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action<bool> completed;

		[Address(RVA="0x10F0008", Offset="0x10F0008", VA="0x10F0008")]
		public <>c__DisplayClass16_0()
		{
		}

		[Address(RVA="0x10F0980", Offset="0x10F0980", VA="0x10F0980")]
		internal void <RequestPlayerRecordViaAnonymousId>b__0(string advertisingId)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AEDC", Offset="0x104AEDC")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset="0x10")]
		public Action<string> completed;

		[FieldOffset(Offset="0x18")]
		public APlayerAuthenticator <>4__this;

		[Address(RVA="0x10F01B4", Offset="0x10F01B4", VA="0x10F01B4")]
		public <>c__DisplayClass17_0()
		{
		}

		[Address(RVA="0x10F0B2C", Offset="0x10F0B2C", VA="0x10F0B2C")]
		internal void <RequestAdvertisingIdentifier>b__0(string advertisingId, bool trackingEnabled, string errorMsg)
		{
		}
	}
}