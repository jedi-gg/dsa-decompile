using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitSkin : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string BattlePrefab
		{
			[Address(RVA="0xF0BFBC", Offset="0xF0BFBC", VA="0xF0BFBC")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BF68", Offset="0xF0BF68", VA="0xF0BF68", Slot="5")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0BFEC", Offset="0xF0BFEC", VA="0xF0BFEC")]
			get
			{
				return null;
			}
		}

		public string Prefab
		{
			[Address(RVA="0xF0BFA4", Offset="0xF0BFA4", VA="0xF0BFA4")]
			get
			{
				return null;
			}
		}

		public ulong SkinItemId
		{
			[Address(RVA="0xF0BF94", Offset="0xF0BF94", VA="0xF0BF94")]
			get
			{
				return new ulong();
			}
		}

		public uint SkinItemRequiredCount
		{
			[Address(RVA="0xF0BF9C", Offset="0xF0BF9C", VA="0xF0BF9C")]
			get
			{
				return new uint();
			}
		}

		public string UnitIcon
		{
			[Address(RVA="0xF0BFD4", Offset="0xF0BFD4", VA="0xF0BFD4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0BF7C", Offset="0xF0BF7C", VA="0xF0BF7C")]
		public UnitSkin __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitSkin();
		}

		[Address(RVA="0xF0BF70", Offset="0xF0BF70", VA="0xF0BF70", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167E258", Offset="0x167E258", VA="0x167E258")]
		public static void AddBattlePrefab(FlatBufferBuilder builder, StringOffset battlePrefabOffset)
		{
		}

		[Address(RVA="0x167E1E0", Offset="0x167E1E0", VA="0x167E1E0")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x167E294", Offset="0x167E294", VA="0x167E294")]
		public static void AddPrefab(FlatBufferBuilder builder, StringOffset prefabOffset)
		{
		}

		[Address(RVA="0x167E1A4", Offset="0x167E1A4", VA="0x167E1A4")]
		public static void AddSkinItemId(FlatBufferBuilder builder, ulong skinItemId)
		{
		}

		[Address(RVA="0x167E2D0", Offset="0x167E2D0", VA="0x167E2D0")]
		public static void AddSkinItemRequiredCount(FlatBufferBuilder builder, uint skinItemRequiredCount)
		{
		}

		[Address(RVA="0x167E21C", Offset="0x167E21C", VA="0x167E21C")]
		public static void AddUnitIcon(FlatBufferBuilder builder, StringOffset unitIconOffset)
		{
		}

		[Address(RVA="0x167E0EC", Offset="0x167E0EC", VA="0x167E0EC")]
		public static Offset<UnitSkin> CreateUnitSkin(FlatBufferBuilder builder, ulong skin_item_id = 0L, uint skin_item_required_count = 0, StringOffset prefabOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitSkin> Gamedata.UnitSkin::CreateUnitSkin(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitSkin> CreateUnitSkin(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x167E30C", Offset="0x167E30C", VA="0x167E30C")]
		public static Offset<UnitSkin> EndUnitSkin(FlatBufferBuilder builder)
		{
			return new Offset<UnitSkin>();
		}

		[Address(RVA="0xF0BFC4", Offset="0xF0BFC4", VA="0xF0BFC4")]
		public ArraySegment<byte>? GetBattlePrefabBytes()
		{
			return null;
		}

		[Address(RVA="0xF0BFF4", Offset="0xF0BFF4", VA="0xF0BFF4")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0BFAC", Offset="0xF0BFAC", VA="0xF0BFAC")]
		public ArraySegment<byte>? GetPrefabBytes()
		{
			return null;
		}

		[Address(RVA="0x167DDFC", Offset="0x167DDFC", VA="0x167DDFC")]
		public static UnitSkin GetRootAsUnitSkin(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitSkin();
		}

		[Address(RVA="0x167DE08", Offset="0x167DE08", VA="0x167DE08")]
		public static UnitSkin GetRootAsUnitSkin(FlatBuffers.ByteBuffer _bb, UnitSkin obj)
		{
			return new UnitSkin();
		}

		[Address(RVA="0xF0BFDC", Offset="0xF0BFDC", VA="0xF0BFDC")]
		public ArraySegment<byte>? GetUnitIconBytes()
		{
			return null;
		}

		[Address(RVA="0x167E38C", Offset="0x167E38C", VA="0x167E38C")]
		public static void StartUnitSkin(FlatBufferBuilder builder)
		{
		}
	}
}