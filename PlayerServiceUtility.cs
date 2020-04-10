using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PlayerServiceUtility : ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x105B584", Offset="0x105B584")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105B594", Offset="0x105B594")]
	[FieldOffset(Offset="0x18")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105B5A4", Offset="0x105B5A4")]
	[FieldOffset(Offset="0x20")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105B5B4", Offset="0x105B5B4")]
	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B5C4", Offset="0x105B5C4")]
	[FieldOffset(Offset="0x30")]
	private SystemDialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105B5D4", Offset="0x105B5D4")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	public LogCategory LogCategory
	{
		[Address(RVA="0x13443E0", Offset="0x13443E0", VA="0x13443E0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x1344B00", Offset="0x1344B00", VA="0x1344B00")]
	public PlayerServiceUtility()
	{
	}

	[Address(RVA="0x13443E8", Offset="0x13443E8", VA="0x13443E8")]
	public void AddFriend(string friendPlayerId, int friendListCount, Action successCallback = // 
	// Current member / type: System.Void PlayerServiceUtility::AddFriend(System.String,System.Int32,System.Action,System.Action,System.Func`1<System.Boolean>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void AddFriend(System.String,System.Int32,System.Action,System.Action,System.Func<System.Boolean>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1344930", Offset="0x1344930", VA="0x1344930")]
	private void SendFriendInviteTelemetry(long referenceId, string targetPlayerId)
	{
	}

	[Address(RVA="0x13447AC", Offset="0x13447AC", VA="0x13447AC")]
	private void ShowErrorMessage(Func<bool> silence, long errorCode, Action acknowledged = // 
	// Current member / type: System.Void PlayerServiceUtility::ShowErrorMessage(System.Func`1<System.Boolean>,System.Int64,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void ShowErrorMessage(System.Func<System.Boolean>,System.Int64,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C67C", Offset="0x104C67C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public string friendPlayerId;

		[FieldOffset(Offset="0x20")]
		public Action successCallback;

		[FieldOffset(Offset="0x28")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x30")]
		public Action failureCallback;

		[Address(RVA="0x134479C", Offset="0x134479C", VA="0x134479C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1344B08", Offset="0x1344B08", VA="0x1344B08")]
		internal void <AddFriend>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1344C0C", Offset="0x1344C0C", VA="0x1344C0C")]
		internal void <AddFriend>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C68C", Offset="0x104C68C")]
	private sealed class <>c__DisplayClass2_1
	{
		[FieldOffset(Offset="0x10")]
		public FriendsListModifyRequest request;

		[FieldOffset(Offset="0x18")]
		public PlayerServiceUtility.<>c__DisplayClass2_0 CS$<>8__locals1;

		[Address(RVA="0x13447A4", Offset="0x13447A4", VA="0x13447A4")]
		public <>c__DisplayClass2_1()
		{
		}

		[Address(RVA="0x1344C80", Offset="0x1344C80", VA="0x1344C80")]
		internal void <AddFriend>b__0(FriendsListModifyResponse response)
		{
		}
	}
}