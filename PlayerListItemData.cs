using Il2CppDummyDll;
using Serverproto;
using System;

public class PlayerListItemData
{
	[FieldOffset(Offset="0x10")]
	public readonly Serverproto.PlayerProfileSimple PlayerProfileSimple;

	[FieldOffset(Offset="0x18")]
	public readonly bool IsLocalPlayer;

	[FieldOffset(Offset="0x1C")]
	public readonly int? Rank;

	[FieldOffset(Offset="0x24")]
	public readonly int? RankDelta;

	[FieldOffset(Offset="0x30")]
	public readonly ulong? CurrentScore;

	[FieldOffset(Offset="0x40")]
	public readonly string AvatarPath;

	public ulong AvatarId
	{
		[Address(RVA="0x133D624", Offset="0x133D624", VA="0x133D624")]
		get
		{
			return new ulong();
		}
	}

	public ulong ClubAvatarId
	{
		[Address(RVA="0x133DDC8", Offset="0x133DDC8", VA="0x133DDC8")]
		get
		{
			return new ulong();
		}
	}

	public string ClubId
	{
		[Address(RVA="0x133DD68", Offset="0x133DD68", VA="0x133DD68")]
		get
		{
			return null;
		}
	}

	public string ClubName
	{
		[Address(RVA="0x133DD98", Offset="0x133DD98", VA="0x133DD98")]
		get
		{
			return null;
		}
	}

	public Serverproto.ClubRole ClubRole
	{
		[Address(RVA="0x133D4EC", Offset="0x133D4EC", VA="0x133D4EC")]
		get
		{
			return new Serverproto.ClubRole();
		}
	}

	public string Id
	{
		[Address(RVA="0x133DD08", Offset="0x133DD08", VA="0x133DD08")]
		get
		{
			return null;
		}
	}

	public string Username
	{
		[Address(RVA="0x133DD38", Offset="0x133DD38", VA="0x133DD38")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x133DDF8", Offset="0x133DDF8", VA="0x133DDF8")]
	public PlayerListItemData(Serverproto.PlayerProfileSimple pps, bool isLocalPlayer, int? rank = // 
	// Current member / type: System.Void PlayerListItemData::.ctor(Serverproto.PlayerProfileSimple,System.Boolean,System.Nullable`1<System.Int32>,System.Nullable`1<System.Int32>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void .ctor(Serverproto.PlayerProfileSimple,System.Boolean,System.Nullable<System.Int32>,System.Nullable<System.Int32>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x133DE90", Offset="0x133DE90", VA="0x133DE90")]
	public PlayerListItemData(Serverproto.PlayerProfileSimple pps, bool isLocalPlayer, string avatarPath)
	{
	}

	[Address(RVA="0x133DED8", Offset="0x133DED8", VA="0x133DED8")]
	public PlayerListItemData(PlayerLeaderboardEntry leaderboardEntry, int rank, bool isLocalPlayer)
	{
	}
}