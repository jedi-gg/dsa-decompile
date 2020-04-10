using Glunies;
using Il2CppDummyDll;
using System;

public class AutoAuthenticationController : ILoggable<LogCategory>, IDispatchHandler<DRestartAutoAuthenticationAction>, IDispatchHandler, IDispatchHandler<DAutoAuthenticateTimedOutAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10526B0", Offset="0x10526B0")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x10526C0", Offset="0x10526C0")]
	[FieldOffset(Offset="0x18")]
	private IPlayerAuthenticator _authenticator;

	[Attribute(Name="InjectAttribute", RVA="0x10526D0", Offset="0x10526D0")]
	[FieldOffset(Offset="0x20")]
	private RevSdkController _revSdkController;

	[Attribute(Name="InjectAttribute", RVA="0x10526E0", Offset="0x10526E0")]
	[FieldOffset(Offset="0x28")]
	private SharedPrefs _sharedPrefs;

	public LogCategory LogCategory
	{
		[Address(RVA="0x115E050", Offset="0x115E050", VA="0x115E050", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x115E694", Offset="0x115E694", VA="0x115E694")]
	public AutoAuthenticationController()
	{
	}

	[Address(RVA="0x115E69C", Offset="0x115E69C", VA="0x115E69C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E048", Offset="0x106E048")]
	private void <AutoAuthenticateCompleted>g__QueryIapProductsCompleted|7_0()
	{
	}

	[Address(RVA="0x115E514", Offset="0x115E514", VA="0x115E514")]
	private void AutoAuthenticateCompleted(bool success)
	{
	}

	[Address(RVA="0x115E308", Offset="0x115E308", VA="0x115E308", Slot="5")]
	public void HandleDispatchAction(DRestartAutoAuthenticationAction action)
	{
	}

	[Address(RVA="0x115E400", Offset="0x115E400", VA="0x115E400", Slot="6")]
	public void HandleDispatchAction(DAutoAuthenticateTimedOutAction action)
	{
	}

	[Address(RVA="0x115E058", Offset="0x115E058", VA="0x115E058")]
	public void Initialize()
	{
	}

	[Address(RVA="0x115E22C", Offset="0x115E22C", VA="0x115E22C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x115E170", Offset="0x115E170", VA="0x115E170")]
	public void TickUpdate()
	{
	}
}