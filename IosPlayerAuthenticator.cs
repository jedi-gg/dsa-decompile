using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class IosPlayerAuthenticator : APlayerAuthenticator
{
	[Attribute(Name="InjectAttribute", RVA="0x10526F0", Offset="0x10526F0")]
	[FieldOffset(Offset="0x70")]
	private SystemDialogManager _systemDialog;

	[Attribute(Name="InjectAttribute", RVA="0x1052700", Offset="0x1052700")]
	[FieldOffset(Offset="0x78")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1052710", Offset="0x1052710")]
	[FieldOffset(Offset="0x80")]
	private SharedPrefs _sharedPrefs;

	[FieldOffset(Offset="0x0")]
	private static Action<bool> s_authCompleteCallback;

	[FieldOffset(Offset="0x8")]
	private static Action<IosPlayerAuthenticator.GameCenterIdvsResult> s_gameCenterIdvsCallback;

	[FieldOffset(Offset="0x10")]
	private static bool s_gameCenterFailed;

	protected override AuthType AnonymousAuthType
	{
		[Address(RVA="0x137D87C", Offset="0x137D87C", VA="0x137D87C", Slot="14")]
		get
		{
			return new AuthType();
		}
	}

	[Address(RVA="0x137D88C", Offset="0x137D88C", VA="0x137D88C")]
	static IosPlayerAuthenticator()
	{
	}

	[Address(RVA="0x137D884", Offset="0x137D884", VA="0x137D884")]
	public IosPlayerAuthenticator()
	{
	}

	[Address(RVA="0x137CAC4", Offset="0x137CAC4", VA="0x137CAC4")]
	private void _GameCenterGenerateVerificationSignature(IosPlayerAuthenticator.GameCenterIdvsSuccess success, IosPlayerAuthenticator.GameCenterIdvsFailure failure)
	{
	}

	[Address(RVA="0x137D890", Offset="0x137D890", VA="0x137D890")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E058", Offset="0x106E058")]
	private void <PresentGuestConfirmation>b__2_0()
	{
	}

	[Address(RVA="0x137C510", Offset="0x137C510", VA="0x137C510", Slot="9")]
	public override void AutoAuthenticate(Action<bool> completed)
	{
	}

	[Address(RVA="0x137C730", Offset="0x137C730", VA="0x137C730", Slot="12")]
	protected override void AutoAuthTimedOut()
	{
	}

	[Address(RVA="0x137D004", Offset="0x137D004", VA="0x137D004")]
	private static void HandleGameCenterIdvsFailure(string reason)
	{
	}

	[Address(RVA="0x137CB24", Offset="0x137CB24", VA="0x137CB24")]
	private void HandleGamecenterIdvsResult(IosPlayerAuthenticator.GameCenterIdvsResult result)
	{
	}

	[Address(RVA="0x137CE1C", Offset="0x137CE1C", VA="0x137CE1C")]
	private static void HandleGameCenterIdvsSuccess(string publicKeyUrl, ulong timestamp, string signature, string salt, string playerId, string alias, string bundleId)
	{
	}

	[Address(RVA="0x137C7B4", Offset="0x137C7B4", VA="0x137C7B4")]
	private void PresentGuestConfirmation()
	{
	}

	[Address(RVA="0x137C8D8", Offset="0x137C8D8", VA="0x137C8D8")]
	private void RequestAuthCodeAndToken(Action<bool> completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AEEC", Offset="0x104AEEC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public IosPlayerAuthenticator <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action<bool> completed;

		[Address(RVA="0x137C728", Offset="0x137C728", VA="0x137C728")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x137D8FC", Offset="0x137D8FC", VA="0x137D8FC")]
		internal void <AutoAuthenticate>b__0(bool success, string errorCode)
		{
		}
	}

	private delegate void GameCenterIdvsFailure(string reason);

	private class GameCenterIdvsResult
	{
		[FieldOffset(Offset="0x10")]
		public string Error;

		[FieldOffset(Offset="0x18")]
		public string PublicKeyUrl;

		[FieldOffset(Offset="0x20")]
		public ulong Timestamp;

		[FieldOffset(Offset="0x28")]
		public string Signature;

		[FieldOffset(Offset="0x30")]
		public string Salt;

		[FieldOffset(Offset="0x38")]
		public string PlayerId;

		[FieldOffset(Offset="0x40")]
		public string Alias;

		[FieldOffset(Offset="0x48")]
		public string BundleId;

		[Address(RVA="0x137CFFC", Offset="0x137CFFC", VA="0x137CFFC")]
		public GameCenterIdvsResult()
		{
		}
	}

	private delegate void GameCenterIdvsSuccess(string publicKeyUrl, ulong timestamp, string signature, string salt, string playerId, string alias, string bundleId);
}