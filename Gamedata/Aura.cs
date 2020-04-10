using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct Aura : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string AssetId
		{
			[Address(RVA="0xF09EEC", Offset="0xF09EEC", VA="0xF09EEC")]
			get
			{
				return null;
			}
		}

		public string AuraDescriptionLocKey
		{
			[Address(RVA="0xF09F1C", Offset="0xF09F1C", VA="0xF09F1C")]
			get
			{
				return null;
			}
		}

		public string AuraNameLocKey
		{
			[Address(RVA="0xF09F04", Offset="0xF09F04", VA="0xF09F04")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF09EB8", Offset="0xF09EB8", VA="0xF09EB8", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF09EE4", Offset="0xF09EE4", VA="0xF09EE4")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF09ECC", Offset="0xF09ECC", VA="0xF09ECC")]
		public Aura __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Aura();
		}

		[Address(RVA="0xF09EC0", Offset="0xF09EC0", VA="0xF09EC0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EEFAC", Offset="0x15EEFAC", VA="0x15EEFAC")]
		public static void AddAssetId(FlatBufferBuilder builder, StringOffset assetIdOffset)
		{
		}

		[Address(RVA="0x15EEF34", Offset="0x15EEF34", VA="0x15EEF34")]
		public static void AddAuraDescriptionLocKey(FlatBufferBuilder builder, StringOffset auraDescriptionLocKeyOffset)
		{
		}

		[Address(RVA="0x15EEF70", Offset="0x15EEF70", VA="0x15EEF70")]
		public static void AddAuraNameLocKey(FlatBufferBuilder builder, StringOffset auraNameLocKeyOffset)
		{
		}

		[Address(RVA="0x15EEEF8", Offset="0x15EEEF8", VA="0x15EEEF8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15EEE68", Offset="0x15EEE68", VA="0x15EEE68")]
		public static Offset<Aura> CreateAura(FlatBufferBuilder builder, ulong id = 0L, StringOffset asset_idOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.Aura> Gamedata.Aura::CreateAura(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.Aura> CreateAura(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15EEFE8", Offset="0x15EEFE8", VA="0x15EEFE8")]
		public static Offset<Aura> EndAura(FlatBufferBuilder builder)
		{
			return new Offset<Aura>();
		}

		[Address(RVA="0x15EF098", Offset="0x15EF098", VA="0x15EF098")]
		public static void FinishAuraBuffer(FlatBufferBuilder builder, Offset<Aura> offset)
		{
		}

		[Address(RVA="0xF09EF4", Offset="0xF09EF4", VA="0xF09EF4")]
		public ArraySegment<byte>? GetAssetIdBytes()
		{
			return null;
		}

		[Address(RVA="0xF09F24", Offset="0xF09F24", VA="0xF09F24")]
		public ArraySegment<byte>? GetAuraDescriptionLocKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF09F0C", Offset="0xF09F0C", VA="0xF09F0C")]
		public ArraySegment<byte>? GetAuraNameLocKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x15EEC20", Offset="0x15EEC20", VA="0x15EEC20")]
		public static Aura GetRootAsAura(FlatBuffers.ByteBuffer _bb)
		{
			return new Aura();
		}

		[Address(RVA="0x15EEC2C", Offset="0x15EEC2C", VA="0x15EEC2C")]
		public static Aura GetRootAsAura(FlatBuffers.ByteBuffer _bb, Aura obj)
		{
			return new Aura();
		}

		[Address(RVA="0x15EF068", Offset="0x15EF068", VA="0x15EF068")]
		public static void StartAura(FlatBufferBuilder builder)
		{
		}
	}
}