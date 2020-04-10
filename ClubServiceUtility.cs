using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubServiceUtility : ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x105656C", Offset="0x105656C")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105657C", Offset="0x105657C")]
	[FieldOffset(Offset="0x18")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105658C", Offset="0x105658C")]
	[FieldOffset(Offset="0x20")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105659C", Offset="0x105659C")]
	[FieldOffset(Offset="0x28")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x10565AC", Offset="0x10565AC")]
	[FieldOffset(Offset="0x30")]
	private SystemDialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x10565BC", Offset="0x10565BC")]
	[FieldOffset(Offset="0x38")]
	private ProfanityFilter _profanityFilter;

	[Attribute(Name="InjectAttribute", RVA="0x10565CC", Offset="0x10565CC")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10565DC", Offset="0x10565DC")]
	[FieldOffset(Offset="0x48")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x10565EC", Offset="0x10565EC")]
	[FieldOffset(Offset="0x50")]
	private ClubDomainController _clubDc;

	[Attribute(Name="InjectAttribute", RVA="0x10565FC", Offset="0x10565FC")]
	[FieldOffset(Offset="0x58")]
	private ClubUtil _clubUtil;

	[Attribute(Name="InjectAttribute", RVA="0x105660C", Offset="0x105660C")]
	[FieldOffset(Offset="0x60")]
	private FeatureLockController _featureLockController;

	public LogCategory LogCategory
	{
		[Address(RVA="0x125DD44", Offset="0x125DD44", VA="0x125DD44", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x126366C", Offset="0x126366C", VA="0x126366C")]
	public ClubServiceUtility()
	{
	}

	[Address(RVA="0x1263674", Offset="0x1263674", VA="0x1263674")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EEB4", Offset="0x106EEB4")]
	private void <PromptToJoinAClubForClubSupport>b__24_0()
	{
	}

	[Address(RVA="0x125E970", Offset="0x125E970", VA="0x125E970")]
	public void ApproveInvite(ClubInvite invite, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::ApproveInvite(Serverproto.ClubInvite,System.Func`1<System.Boolean>,System.Action,System.String)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void ApproveInvite(Serverproto.ClubInvite,System.Func<System.Boolean>,System.Action,System.String)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x125A440", Offset="0x125A440", VA="0x125A440")]
	public void CancelJoinClub(Club club, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::CancelJoinClub(Serverproto.Club,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void CancelJoinClub(Serverproto.Club,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x125E644", Offset="0x125E644", VA="0x125E644")]
	public void CancelJoinClub(string clubId, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::CancelJoinClub(System.String,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void CancelJoinClub(System.String,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x125E0C4", Offset="0x125E0C4", VA="0x125E0C4")]
	private bool CanJoinClub()
	{
		return new bool();
	}

	[Address(RVA="0x125DD4C", Offset="0x125DD4C", VA="0x125DD4C")]
	public void CreateClub(string name, ClubSettings settings, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::CreateClub(System.String,Serverproto.ClubSettings,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void CreateClub(System.String,Serverproto.ClubSettings,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x125FA6C", Offset="0x125FA6C", VA="0x125FA6C")]
	public void DemotePlayer(PlayerProfileSimple player, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::DemotePlayer(Serverproto.PlayerProfileSimple,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void DemotePlayer(Serverproto.PlayerProfileSimple,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1253794", Offset="0x1253794", VA="0x1253794")]
	public void DonateItem(ClubItemRequest itemRequest, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::DonateItem(Serverproto.ClubItemRequest,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void DonateItem(Serverproto.ClubItemRequest,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1254C04", Offset="0x1254C04", VA="0x1254C04")]
	public void FulfillAllSupportRequests(List<ClubSupportRequest> requests, Func<bool> silence, Action success, Action acknowledgedFailure)
	{
	}

	[Address(RVA="0x125458C", Offset="0x125458C", VA="0x125458C")]
	public void FulfillSupportRequest(ClubSupportRequest supportRequest, Func<bool> silence, Action success, Action acknowledgedFailure)
	{
	}

	[Address(RVA="0x125F098", Offset="0x125F098", VA="0x125F098")]
	public void GetInvites()
	{
	}

	[Address(RVA="0x12607A0", Offset="0x12607A0", VA="0x12607A0")]
	public void GetPlayerClubSupportStatus(ClubSupportRequestType requestType, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::GetPlayerClubSupportStatus(Serverproto.ClubSupportRequestType,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void GetPlayerClubSupportStatus(Serverproto.ClubSupportRequestType,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x125E3BC", Offset="0x125E3BC", VA="0x125E3BC")]
	public void InviteToClub(string playerId, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::InviteToClub(System.String,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void InviteToClub(System.String,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x125A100", Offset="0x125A100", VA="0x125A100")]
	public void JoinClub(Club club, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::JoinClub(Serverproto.Club,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void JoinClub(Serverproto.Club,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x125FD60", Offset="0x125FD60", VA="0x125FD60")]
	public void KickPlayer(PlayerProfileSimple player, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::KickPlayer(Serverproto.PlayerProfileSimple,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void KickPlayer(Serverproto.PlayerProfileSimple,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1260054", Offset="0x1260054", VA="0x1260054")]
	public void LeaveClub(Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::LeaveClub(System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void LeaveClub(System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1261104", Offset="0x1261104", VA="0x1261104")]
	public void MarkClubSupportRequestClaimed(ClubSupportRequest supportRequest)
	{
	}

	[Address(RVA="0x125F610", Offset="0x125F610", VA="0x125F610")]
	public void PromotePlayer(PlayerProfileSimple player, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::PromotePlayer(Serverproto.PlayerProfileSimple,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void PromotePlayer(Serverproto.PlayerProfileSimple,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1260E7C", Offset="0x1260E7C", VA="0x1260E7C")]
	private void PromptToJoinAClubForClubSupport()
	{
	}

	[Address(RVA="0x125ED48", Offset="0x125ED48", VA="0x125ED48")]
	public void RejectInvite(ClubInvite invite, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::RejectInvite(Serverproto.ClubInvite,System.Func`1<System.Boolean>,System.Action,System.String)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void RejectInvite(Serverproto.ClubInvite,System.Func<System.Boolean>,System.Action,System.String)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1260AC0", Offset="0x1260AC0", VA="0x1260AC0")]
	public void RequestClubSupport(ClubSupportRequestType requestType, Func<bool> silence)
	{
	}

	[Address(RVA="0x12604EC", Offset="0x12604EC", VA="0x12604EC")]
	public void RequestItem(ulong itemId, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::RequestItem(System.UInt64,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void RequestItem(System.UInt64,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1261DF0", Offset="0x1261DF0", VA="0x1261DF0")]
	private void SendApproveInviteTelemetry(ClubInvite invite)
	{
	}

	[Address(RVA="0x1261690", Offset="0x1261690", VA="0x1261690")]
	private void SendCreateClubTelemetry(CreateClubResponse response)
	{
	}

	[Address(RVA="0x1262800", Offset="0x1262800", VA="0x1262800")]
	private void SendDemoteTelemetry(string demotedPlayerId)
	{
	}

	[Address(RVA="0x1262CE8", Offset="0x1262CE8", VA="0x1262CE8")]
	private void SendDonateItemTelemetry(ClubItemRequest itemRequest, DonateClubItemResponse response)
	{
	}

	[Address(RVA="0x1261C20", Offset="0x1261C20", VA="0x1261C20")]
	private void SendInvitePlayerTelemetry(ClubInvite invite)
	{
	}

	[Address(RVA="0x1261A6C", Offset="0x1261A6C", VA="0x1261A6C")]
	private void SendJoinClubTelemetry(string clubId, ClubInviteResponse response)
	{
	}

	[Address(RVA="0x1262438", Offset="0x1262438", VA="0x1262438")]
	private void SendKickPlayerTelemetry(string kickedPlayerId)
	{
	}

	[Address(RVA="0x1262278", Offset="0x1262278", VA="0x1262278")]
	private void SendLeaveClubTelemetry(string clubId)
	{
	}

	[Address(RVA="0x126261C", Offset="0x126261C", VA="0x126261C")]
	private void SendPromoteTelemetry(string promotedPlayerId)
	{
	}

	[Address(RVA="0x1262034", Offset="0x1262034", VA="0x1262034")]
	private void SendRejectInviteTelemetry(ClubInvite invite)
	{
	}

	[Address(RVA="0x12629E4", Offset="0x12629E4", VA="0x12629E4")]
	private void SendRequestItemTelemetry(ClubItemRequest itemRequest)
	{
	}

	[Address(RVA="0x12611B8", Offset="0x12611B8", VA="0x12611B8")]
	private void SendSupportClaimedTelemetry(ClubSupportRequest supportRequest)
	{
	}

	[Address(RVA="0x12630B4", Offset="0x12630B4", VA="0x12630B4")]
	private void SendSupportRequestedTelemetry(ClubSupportRequest supportRequest)
	{
	}

	[Address(RVA="0x126336C", Offset="0x126336C", VA="0x126336C")]
	private void SendSupportRequestFulfilledTelemetry(ClubSupportRequest supportRequest)
	{
	}

	[Address(RVA="0x1261470", Offset="0x1261470", VA="0x1261470")]
	private void ShowErrorMessage(string localizationKey, Func<bool> silence, long errorCode, string errorReasonLocKey = "", Action acknowledged = // 
	// Current member / type: System.Void ClubServiceUtility::ShowErrorMessage(System.String,System.Func`1<System.Boolean>,System.Int64,System.String,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void ShowErrorMessage(System.String,System.Func<System.Boolean>,System.Int64,System.String,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x125F2D8", Offset="0x125F2D8", VA="0x125F2D8")]
	public void UpdateClubSettings(Club club, ClubSettings newSettings, Func<bool> silence, Action done = // 
	// Current member / type: System.Void ClubServiceUtility::UpdateClubSettings(Serverproto.Club,Serverproto.ClubSettings,System.Func`1<System.Boolean>,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void UpdateClubSettings(Serverproto.Club,Serverproto.ClubSettings,System.Func<System.Boolean>,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B73C", Offset="0x104B73C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static ClubServiceUtility.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__2_2;

		[FieldOffset(Offset="0x10")]
		public static Func<bool> <>9__3_2;

		[FieldOffset(Offset="0x18")]
		public static Func<bool> <>9__6_2;

		[FieldOffset(Offset="0x20")]
		public static Func<bool> <>9__7_2;

		[FieldOffset(Offset="0x28")]
		public static Func<bool> <>9__8_2;

		[FieldOffset(Offset="0x30")]
		public static Action<GetClubInvitesResponse> <>9__9_0;

		[FieldOffset(Offset="0x38")]
		public static Action<long> <>9__9_1;

		[FieldOffset(Offset="0x40")]
		public static Func<bool> <>9__9_2;

		[FieldOffset(Offset="0x48")]
		public static Func<bool> <>9__10_2;

		[FieldOffset(Offset="0x50")]
		public static Func<bool> <>9__11_3;

		[FieldOffset(Offset="0x58")]
		public static Func<bool> <>9__12_2;

		[FieldOffset(Offset="0x60")]
		public static Func<bool> <>9__13_2;

		[FieldOffset(Offset="0x68")]
		public static Func<bool> <>9__14_3;

		[FieldOffset(Offset="0x70")]
		public static Func<bool> <>9__15_2;

		[FieldOffset(Offset="0x78")]
		public static Func<bool> <>9__16_2;

		[FieldOffset(Offset="0x80")]
		public static Action<GetPlayerClubSupportStatusResponse> <>9__17_0;

		[FieldOffset(Offset="0x88")]
		public static Action<long> <>9__17_1;

		[FieldOffset(Offset="0x90")]
		public static Func<bool> <>9__17_2;

		[FieldOffset(Offset="0x98")]
		public static Func<bool> <>9__18_2;

		[FieldOffset(Offset="0xA0")]
		public static Func<bool> <>9__19_2;

		[FieldOffset(Offset="0xA8")]
		public static Func<bool> <>9__20_2;

		[Address(RVA="0x12637C8", Offset="0x12637C8", VA="0x12637C8")]
		static <>c()
		{
		}

		[Address(RVA="0x126382C", Offset="0x126382C", VA="0x126382C")]
		public <>c()
		{
		}

		[Address(RVA="0x126384C", Offset="0x126384C", VA="0x126384C")]
		internal bool <ApproveInvite>b__7_2()
		{
			return new bool();
		}

		[Address(RVA="0x1263844", Offset="0x1263844", VA="0x1263844")]
		internal bool <CancelJoinClub>b__6_2()
		{
			return new bool();
		}

		[Address(RVA="0x1263834", Offset="0x1263834", VA="0x1263834")]
		internal bool <CreateClub>b__2_2()
		{
			return new bool();
		}

		[Address(RVA="0x126387C", Offset="0x126387C", VA="0x126387C")]
		internal bool <DemotePlayer>b__12_2()
		{
			return new bool();
		}

		[Address(RVA="0x126389C", Offset="0x126389C", VA="0x126389C")]
		internal bool <DonateItem>b__16_2()
		{
			return new bool();
		}

		[Address(RVA="0x12638C4", Offset="0x12638C4", VA="0x12638C4")]
		internal bool <FulfillAllSupportRequests>b__20_2()
		{
			return new bool();
		}

		[Address(RVA="0x12638BC", Offset="0x12638BC", VA="0x12638BC")]
		internal bool <FulfillSupportRequest>b__19_2()
		{
			return new bool();
		}

		[Address(RVA="0x126385C", Offset="0x126385C", VA="0x126385C")]
		internal void <GetInvites>b__9_0(GetClubInvitesResponse response)
		{
		}

		[Address(RVA="0x1263860", Offset="0x1263860", VA="0x1263860")]
		internal void <GetInvites>b__9_1(long errorCode)
		{
		}

		[Address(RVA="0x1263864", Offset="0x1263864", VA="0x1263864")]
		internal bool <GetInvites>b__9_2()
		{
			return new bool();
		}

		[Address(RVA="0x12638A4", Offset="0x12638A4", VA="0x12638A4")]
		internal void <GetPlayerClubSupportStatus>b__17_0(GetPlayerClubSupportStatusResponse response)
		{
		}

		[Address(RVA="0x12638A8", Offset="0x12638A8", VA="0x12638A8")]
		internal void <GetPlayerClubSupportStatus>b__17_1(long errorCode)
		{
		}

		[Address(RVA="0x12638AC", Offset="0x12638AC", VA="0x12638AC")]
		internal bool <GetPlayerClubSupportStatus>b__17_2()
		{
			return new bool();
		}

		[Address(RVA="0x126383C", Offset="0x126383C", VA="0x126383C")]
		internal bool <JoinClub>b__3_2()
		{
			return new bool();
		}

		[Address(RVA="0x1263884", Offset="0x1263884", VA="0x1263884")]
		internal bool <KickPlayer>b__13_2()
		{
			return new bool();
		}

		[Address(RVA="0x126388C", Offset="0x126388C", VA="0x126388C")]
		internal bool <LeaveClub>b__14_3()
		{
			return new bool();
		}

		[Address(RVA="0x1263874", Offset="0x1263874", VA="0x1263874")]
		internal bool <PromotePlayer>b__11_3()
		{
			return new bool();
		}

		[Address(RVA="0x1263854", Offset="0x1263854", VA="0x1263854")]
		internal bool <RejectInvite>b__8_2()
		{
			return new bool();
		}

		[Address(RVA="0x12638B4", Offset="0x12638B4", VA="0x12638B4")]
		internal bool <RequestClubSupport>b__18_2()
		{
			return new bool();
		}

		[Address(RVA="0x1263894", Offset="0x1263894", VA="0x1263894")]
		internal bool <RequestItem>b__15_2()
		{
			return new bool();
		}

		[Address(RVA="0x126386C", Offset="0x126386C", VA="0x126386C")]
		internal bool <UpdateClubSettings>b__10_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B79C", Offset="0x104B79C")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public Club club;

		[FieldOffset(Offset="0x18")]
		public ClubSettings newSettings;

		[FieldOffset(Offset="0x20")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x28")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x30")]
		public Action done;

		[Address(RVA="0x125F608", Offset="0x125F608", VA="0x125F608")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x12638CC", Offset="0x12638CC", VA="0x12638CC")]
		internal void <UpdateClubSettings>b__0(UpdateClubResponse response)
		{
		}

		[Address(RVA="0x1263980", Offset="0x1263980", VA="0x1263980")]
		internal void <UpdateClubSettings>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1263A08", Offset="0x1263A08", VA="0x1263A08")]
		internal void <UpdateClubSettings>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B7AC", Offset="0x104B7AC")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerProfileSimple player;

		[FieldOffset(Offset="0x18")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x20")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x28")]
		public Action done;

		[Address(RVA="0x125F7E0", Offset="0x125F7E0", VA="0x125F7E0")]
		public <>c__DisplayClass11_0()
		{
		}

		[Address(RVA="0x1263A98", Offset="0x1263A98", VA="0x1263A98")]
		internal void <PromotePlayer>b__1(PromoteClubMemberResponse response)
		{
		}

		[Address(RVA="0x1263B88", Offset="0x1263B88", VA="0x1263B88")]
		internal void <PromotePlayer>b__2(long errorCode)
		{
		}

		[Address(RVA="0x1263C10", Offset="0x1263C10", VA="0x1263C10")]
		internal void <PromotePlayer>b__4()
		{
		}

		[Address(RVA="0x125F7E8", Offset="0x125F7E8", VA="0x125F7E8")]
		internal void <PromotePlayer>g__DoPromote|0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B7BC", Offset="0x104B7BC")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public PlayerProfileSimple player;

		[FieldOffset(Offset="0x20")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x28")]
		public Action done;

		[Address(RVA="0x125FD58", Offset="0x125FD58", VA="0x125FD58")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x1263CA0", Offset="0x1263CA0", VA="0x1263CA0")]
		internal void <DemotePlayer>b__0(DemoteClubMemberResponse response)
		{
		}

		[Address(RVA="0x1263D90", Offset="0x1263D90", VA="0x1263D90")]
		internal void <DemotePlayer>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1263E18", Offset="0x1263E18", VA="0x1263E18")]
		internal void <DemotePlayer>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B7CC", Offset="0x104B7CC")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public PlayerProfileSimple player;

		[FieldOffset(Offset="0x20")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x28")]
		public Action done;

		[Address(RVA="0x126004C", Offset="0x126004C", VA="0x126004C")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x1263EA8", Offset="0x1263EA8", VA="0x1263EA8")]
		internal void <KickPlayer>b__0(KickClubMemberResponse response)
		{
		}

		[Address(RVA="0x1263F98", Offset="0x1263F98", VA="0x1263F98")]
		internal void <KickPlayer>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1264020", Offset="0x1264020", VA="0x1264020")]
		internal void <KickPlayer>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B7DC", Offset="0x104B7DC")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x20")]
		public Action done;

		[Address(RVA="0x1260384", Offset="0x1260384", VA="0x1260384")]
		public <>c__DisplayClass14_0()
		{
		}

		[Address(RVA="0x12643D8", Offset="0x12643D8", VA="0x12643D8")]
		internal void <LeaveClub>b__2(long errorCode)
		{
		}

		[Address(RVA="0x1264460", Offset="0x1264460", VA="0x1264460")]
		internal void <LeaveClub>b__4()
		{
		}

		[Address(RVA="0x12640B0", Offset="0x12640B0", VA="0x12640B0")]
		internal void <LeaveClub>g__LeaveClubConfirmed|0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B7EC", Offset="0x104B7EC")]
	private sealed class <>c__DisplayClass14_1
	{
		[FieldOffset(Offset="0x10")]
		public string clubId;

		[FieldOffset(Offset="0x18")]
		public ClubServiceUtility.<>c__DisplayClass14_0 CS$<>8__locals1;

		[Address(RVA="0x12643D0", Offset="0x12643D0", VA="0x12643D0")]
		public <>c__DisplayClass14_1()
		{
		}

		[Address(RVA="0x12644F0", Offset="0x12644F0", VA="0x12644F0")]
		internal void <LeaveClub>b__1(KickClubMemberResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B7FC", Offset="0x104B7FC")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x20")]
		public Action done;

		[Address(RVA="0x1260790", Offset="0x1260790", VA="0x1260790")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x12645C4", Offset="0x12645C4", VA="0x12645C4")]
		internal void <RequestItem>b__0(RequestClubItemResponse response)
		{
		}

		[Address(RVA="0x126469C", Offset="0x126469C", VA="0x126469C")]
		internal void <RequestItem>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1264724", Offset="0x1264724", VA="0x1264724")]
		internal void <RequestItem>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B80C", Offset="0x104B80C")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubItemRequest itemRequest;

		[FieldOffset(Offset="0x20")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x28")]
		public Action done;

		[Address(RVA="0x1260798", Offset="0x1260798", VA="0x1260798")]
		public <>c__DisplayClass16_0()
		{
		}

		[Address(RVA="0x12647B4", Offset="0x12647B4", VA="0x12647B4")]
		internal void <DonateItem>b__0(DonateClubItemResponse response)
		{
		}

		[Address(RVA="0x1264964", Offset="0x1264964", VA="0x1264964")]
		internal void <DonateItem>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1264A0C", Offset="0x1264A0C", VA="0x1264A0C")]
		internal void <DonateItem>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B81C", Offset="0x104B81C")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset="0x10")]
		public Action done;

		[Address(RVA="0x1260AB8", Offset="0x1260AB8", VA="0x1260AB8")]
		public <>c__DisplayClass17_0()
		{
		}

		[Address(RVA="0x1264A9C", Offset="0x1264A9C", VA="0x1264A9C")]
		internal void <GetPlayerClubSupportStatus>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B82C", Offset="0x104B82C")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public Func<bool> silence;

		[Address(RVA="0x1260E74", Offset="0x1260E74", VA="0x1260E74")]
		public <>c__DisplayClass18_0()
		{
		}

		[Address(RVA="0x1264AB0", Offset="0x1264AB0", VA="0x1264AB0")]
		internal void <RequestClubSupport>b__0(RequestClubSupportResponse response)
		{
		}

		[Address(RVA="0x1264B00", Offset="0x1264B00", VA="0x1264B00")]
		internal void <RequestClubSupport>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1264B88", Offset="0x1264B88", VA="0x1264B88")]
		internal void <RequestClubSupport>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B83C", Offset="0x104B83C")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubSupportRequest supportRequest;

		[FieldOffset(Offset="0x20")]
		public Action success;

		[FieldOffset(Offset="0x28")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x30")]
		public Action acknowledgedFailure;

		[Address(RVA="0x12610F4", Offset="0x12610F4", VA="0x12610F4")]
		public <>c__DisplayClass19_0()
		{
		}

		[Address(RVA="0x1264BFC", Offset="0x1264BFC", VA="0x1264BFC")]
		internal void <FulfillSupportRequest>b__0(FulfillClubSupportResponse response)
		{
		}

		[Address(RVA="0x1264C58", Offset="0x1264C58", VA="0x1264C58")]
		internal void <FulfillSupportRequest>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1264CE4", Offset="0x1264CE4", VA="0x1264CE4")]
		internal void <FulfillSupportRequest>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B72C", Offset="0x104B72C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x20")]
		public Action done;

		[Address(RVA="0x125E0B4", Offset="0x125E0B4", VA="0x125E0B4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1264FEC", Offset="0x1264FEC", VA="0x1264FEC")]
		internal void <CreateClub>b__0(CreateClubResponse response)
		{
		}

		[Address(RVA="0x12650B8", Offset="0x12650B8", VA="0x12650B8")]
		internal void <CreateClub>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1265140", Offset="0x1265140", VA="0x1265140")]
		internal void <CreateClub>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B84C", Offset="0x104B84C")]
	private sealed class <>c__DisplayClass20_0
	{
		[FieldOffset(Offset="0x10")]
		public List<ClubSupportRequest> requests;

		[FieldOffset(Offset="0x18")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x20")]
		public Action success;

		[FieldOffset(Offset="0x28")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x30")]
		public Action acknowledgedFailure;

		[Address(RVA="0x12610FC", Offset="0x12610FC", VA="0x12610FC")]
		public <>c__DisplayClass20_0()
		{
		}

		[Address(RVA="0x1264D58", Offset="0x1264D58", VA="0x1264D58")]
		internal void <FulfillAllSupportRequests>b__0(FulfillAllClubSupportResponse response)
		{
		}

		[Address(RVA="0x1264EEC", Offset="0x1264EEC", VA="0x1264EEC")]
		internal void <FulfillAllSupportRequests>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1264F78", Offset="0x1264F78", VA="0x1264F78")]
		internal void <FulfillAllSupportRequests>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B74C", Offset="0x104B74C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public Club club;

		[FieldOffset(Offset="0x20")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x28")]
		public Action done;

		[Address(RVA="0x125E0BC", Offset="0x125E0BC", VA="0x125E0BC")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x12651D0", Offset="0x12651D0", VA="0x12651D0")]
		internal void <JoinClub>b__0(ClubInviteResponse response)
		{
		}

		[Address(RVA="0x126539C", Offset="0x126539C", VA="0x126539C")]
		internal void <JoinClub>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1265424", Offset="0x1265424", VA="0x1265424")]
		internal void <JoinClub>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B75C", Offset="0x104B75C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x20")]
		public Action done;

		[Address(RVA="0x125E63C", Offset="0x125E63C", VA="0x125E63C")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x12654B4", Offset="0x12654B4", VA="0x12654B4")]
		internal void <InviteToClub>b__0(ClubInviteResponse response)
		{
		}

		[Address(RVA="0x126563C", Offset="0x126563C", VA="0x126563C")]
		internal void <InviteToClub>b__1(long errorCode)
		{
		}

		[Address(RVA="0x12656C4", Offset="0x12656C4", VA="0x12656C4")]
		internal void <InviteToClub>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B76C", Offset="0x104B76C")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public string clubId;

		[FieldOffset(Offset="0x20")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x28")]
		public Action done;

		[Address(RVA="0x125E968", Offset="0x125E968", VA="0x125E968")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x1265754", Offset="0x1265754", VA="0x1265754")]
		internal void <CancelJoinClub>b__0(CancelClubInviteResponse response)
		{
		}

		[Address(RVA="0x1265828", Offset="0x1265828", VA="0x1265828")]
		internal void <CancelJoinClub>b__1(long errorCode)
		{
		}

		[Address(RVA="0x12658B0", Offset="0x12658B0", VA="0x12658B0")]
		internal void <CancelJoinClub>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B77C", Offset="0x104B77C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubInvite invite;

		[FieldOffset(Offset="0x20")]
		public string errorMessage;

		[FieldOffset(Offset="0x28")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x30")]
		public Action done;

		[Address(RVA="0x125ED40", Offset="0x125ED40", VA="0x125ED40")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x1265940", Offset="0x1265940", VA="0x1265940")]
		internal void <ApproveInvite>b__0(ApproveClubInviteResponse response)
		{
		}

		[Address(RVA="0x1265AF4", Offset="0x1265AF4", VA="0x1265AF4")]
		internal void <ApproveInvite>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1265B9C", Offset="0x1265B9C", VA="0x1265B9C")]
		internal void <ApproveInvite>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B78C", Offset="0x104B78C")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubServiceUtility <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubInvite invite;

		[FieldOffset(Offset="0x20")]
		public string errorMessage;

		[FieldOffset(Offset="0x28")]
		public Func<bool> silence;

		[FieldOffset(Offset="0x30")]
		public Action done;

		[Address(RVA="0x125F090", Offset="0x125F090", VA="0x125F090")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x1265C2C", Offset="0x1265C2C", VA="0x1265C2C")]
		internal void <RejectInvite>b__0(RejectClubInviteResponse response)
		{
		}

		[Address(RVA="0x1265CDC", Offset="0x1265CDC", VA="0x1265CDC")]
		internal void <RejectInvite>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1265D84", Offset="0x1265D84", VA="0x1265D84")]
		internal void <RejectInvite>b__3()
		{
		}
	}
}