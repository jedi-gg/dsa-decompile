using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubWarChest : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43E4C", Offset="0xF43E4C", VA="0xF43E4C", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF43E78", Offset="0xF43E78", VA="0xF43E78")]
			get
			{
				return new ulong();
			}
		}

		public string Image
		{
			[Address(RVA="0xF43E98", Offset="0xF43E98", VA="0xF43E98")]
			get
			{
				return null;
			}
		}

		public ulong LootTable
		{
			[Address(RVA="0xF43EB0", Offset="0xF43EB0", VA="0xF43EB0")]
			get
			{
				return new ulong();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF43E80", Offset="0xF43E80", VA="0xF43E80")]
			get
			{
				return null;
			}
		}

		public ClubWarChestRarity Rarity
		{
			[Address(RVA="0xF43EB8", Offset="0xF43EB8", VA="0xF43EB8")]
			get
			{
				return new ClubWarChestRarity();
			}
		}

		[Address(RVA="0xF43E60", Offset="0xF43E60", VA="0xF43E60")]
		public ClubWarChest __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarChest();
		}

		[Address(RVA="0xF43E54", Offset="0xF43E54", VA="0xF43E54", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x23262F0", Offset="0x23262F0", VA="0x23262F0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x232632C", Offset="0x232632C", VA="0x232632C")]
		public static void AddImage(FlatBufferBuilder builder, StringOffset imageOffset)
		{
		}

		[Address(RVA="0x23262B4", Offset="0x23262B4", VA="0x23262B4")]
		public static void AddLootTable(FlatBufferBuilder builder, ulong lootTable)
		{
		}

		[Address(RVA="0x2326368", Offset="0x2326368", VA="0x2326368")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x23263A4", Offset="0x23263A4", VA="0x23263A4")]
		public static void AddRarity(FlatBufferBuilder builder, ClubWarChestRarity rarity)
		{
		}

		[Address(RVA="0x2326214", Offset="0x2326214", VA="0x2326214")]
		public static Offset<ClubWarChest> CreateClubWarChest(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubWarChest> Gamedata.ClubWarChest::CreateClubWarChest(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,Gamedata.ClubWarChestRarity)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubWarChest> CreateClubWarChest(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,Gamedata.ClubWarChestRarity)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x23263E0", Offset="0x23263E0", VA="0x23263E0")]
		public static Offset<ClubWarChest> EndClubWarChest(FlatBufferBuilder builder)
		{
			return new Offset<ClubWarChest>();
		}

		[Address(RVA="0x2326490", Offset="0x2326490", VA="0x2326490")]
		public static void FinishClubWarChestBuffer(FlatBufferBuilder builder, Offset<ClubWarChest> offset)
		{
		}

		[Address(RVA="0xF43EA0", Offset="0xF43EA0", VA="0xF43EA0")]
		public ArraySegment<byte>? GetImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF43E88", Offset="0xF43E88", VA="0xF43E88")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x2325F50", Offset="0x2325F50", VA="0x2325F50")]
		public static ClubWarChest GetRootAsClubWarChest(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarChest();
		}

		[Address(RVA="0x2325F5C", Offset="0x2325F5C", VA="0x2325F5C")]
		public static ClubWarChest GetRootAsClubWarChest(FlatBuffers.ByteBuffer _bb, ClubWarChest obj)
		{
			return new ClubWarChest();
		}

		[Address(RVA="0x2326460", Offset="0x2326460", VA="0x2326460")]
		public static void StartClubWarChest(FlatBufferBuilder builder)
		{
		}
	}
}