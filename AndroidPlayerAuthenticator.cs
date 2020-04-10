using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class AndroidPlayerAuthenticator : APlayerAuthenticator
{
	[FieldOffset(Offset="0x70")]
	private Action _mainThreadCallback;

	[Attribute(Name="InjectAttribute", RVA="0x10525E0", Offset="0x10525E0")]
	[FieldOffset(Offset="0x78")]
	private SystemDialogManager _systemDialog;

	[Attribute(Name="InjectAttribute", RVA="0x10525F0", Offset="0x10525F0")]
	[FieldOffset(Offset="0x80")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1052600", Offset="0x1052600")]
	[FieldOffset(Offset="0x88")]
	private SharedPrefs _sharedPrefs;

	protected override AuthType AnonymousAuthType
	{
		[Address(RVA="0x115B564", Offset="0x115B564", VA="0x115B564", Slot="14")]
		get
		{
			return new AuthType();
		}
	}

	[Address(RVA="0x115AF34", Offset="0x115AF34", VA="0x115AF34")]
	public AndroidPlayerAuthenticator()
	{
	}

	[Address(RVA="0x115B56C", Offset="0x115B56C", VA="0x115B56C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E008", Offset="0x106E008")]
	private void <PresentGuestConfirmation>b__5_0()
	{
	}

	[Address(RVA="0x115B5D0", Offset="0x115B5D0", VA="0x115B5D0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E018", Offset="0x106E018")]
	private void <PresentGuestConfirmation>b__5_1()
	{
	}

	[Address(RVA="0x115B080", Offset="0x115B080", VA="0x115B080", Slot="9")]
	public override void AutoAuthenticate(Action<bool> completed)
	{
	}

	[Address(RVA="0x115B2A8", Offset="0x115B2A8", VA="0x115B2A8", Slot="12")]
	protected override void AutoAuthTimedOut()
	{
	}

	[Address(RVA="0x115B2D0", Offset="0x115B2D0", VA="0x115B2D0")]
	private void PresentGuestConfirmation()
	{
	}

	[Address(RVA="0x115B44C", Offset="0x115B44C", VA="0x115B44C")]
	private void RequestAuthCodeAndToken(Action<bool> completed)
	{
	}

	[Address(RVA="0x115B280", Offset="0x115B280", VA="0x115B280", Slot="10")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x115B240", Offset="0x115B240", VA="0x115B240", Slot="11")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE6C", Offset="0x104AE6C")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public AndroidPlayerAuthenticator <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action<bool> completed;

		[Address(RVA="0x115B238", Offset="0x115B238", VA="0x115B238")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x115B63C", Offset="0x115B63C", VA="0x115B63C")]
		internal void <AutoAuthenticate>b__0(bool success, string errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE7C", Offset="0x104AE7C")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public AndroidPlayerAuthenticator <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action<bool> completed;

		[FieldOffset(Offset="0x20")]
		public Action <>9__1;

		[Address(RVA="0x115B55C", Offset="0x115B55C", VA="0x115B55C")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x115B820", Offset="0x115B820", VA="0x115B820")]
		internal void <RequestAuthCodeAndToken>b__0(string serverAuthCode)
		{
		}

		[Address(RVA="0x115B958", Offset="0x115B958", VA="0x115B958")]
		internal void <RequestAuthCodeAndToken>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE8C", Offset="0x104AE8C")]
	private sealed class <>c__DisplayClass6_1
	{
		[FieldOffset(Offset="0x10")]
		public string serverAuthCode;

		[FieldOffset(Offset="0x18")]
		public AndroidPlayerAuthenticator.<>c__DisplayClass6_0 CS$<>8__locals1;

		[Address(RVA="0x115B950", Offset="0x115B950", VA="0x115B950")]
		public <>c__DisplayClass6_1()
		{
		}

		[Address(RVA="0x115BA00", Offset="0x115BA00", VA="0x115BA00")]
		internal void <RequestAuthCodeAndToken>b__2()
		{
		}
	}
}