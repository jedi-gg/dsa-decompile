using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleCinematic : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A1C0", Offset="0xF0A1C0", VA="0xF0A1C0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0A1EC", Offset="0xF0A1EC", VA="0xF0A1EC")]
			get
			{
				return new ulong();
			}
		}

		public string Prefab
		{
			[Address(RVA="0xF0A1F4", Offset="0xF0A1F4", VA="0xF0A1F4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0A1D4", Offset="0xF0A1D4", VA="0xF0A1D4")]
		public BattleCinematic __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleCinematic();
		}

		[Address(RVA="0xF0A1C8", Offset="0xF0A1C8", VA="0xF0A1C8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F012C", Offset="0x15F012C", VA="0x15F012C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F0168", Offset="0x15F0168", VA="0x15F0168")]
		public static void AddPrefab(FlatBufferBuilder builder, StringOffset prefabOffset)
		{
		}

		[Address(RVA="0x15F00C4", Offset="0x15F00C4", VA="0x15F00C4")]
		public static Offset<BattleCinematic> CreateBattleCinematic(FlatBufferBuilder builder, ulong id = 0L, StringOffset prefabOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleCinematic> Gamedata.BattleCinematic::CreateBattleCinematic(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleCinematic> CreateBattleCinematic(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F01A4", Offset="0x15F01A4", VA="0x15F01A4")]
		public static Offset<BattleCinematic> EndBattleCinematic(FlatBufferBuilder builder)
		{
			return new Offset<BattleCinematic>();
		}

		[Address(RVA="0x15F0254", Offset="0x15F0254", VA="0x15F0254")]
		public static void FinishBattleCinematicBuffer(FlatBufferBuilder builder, Offset<BattleCinematic> offset)
		{
		}

		[Address(RVA="0xF0A1FC", Offset="0xF0A1FC", VA="0xF0A1FC")]
		public ArraySegment<byte>? GetPrefabBytes()
		{
			return null;
		}

		[Address(RVA="0x15EFF2C", Offset="0x15EFF2C", VA="0x15EFF2C")]
		public static BattleCinematic GetRootAsBattleCinematic(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleCinematic();
		}

		[Address(RVA="0x15EFF38", Offset="0x15EFF38", VA="0x15EFF38")]
		public static BattleCinematic GetRootAsBattleCinematic(FlatBuffers.ByteBuffer _bb, BattleCinematic obj)
		{
			return new BattleCinematic();
		}

		[Address(RVA="0x15F0224", Offset="0x15F0224", VA="0x15F0224")]
		public static void StartBattleCinematic(FlatBufferBuilder builder)
		{
		}
	}
}