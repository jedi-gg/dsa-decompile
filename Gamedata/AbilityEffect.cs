using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct AbilityEffect : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string AssetId
		{
			[Address(RVA="0xF099EC", Offset="0xF099EC", VA="0xF099EC")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF099B8", Offset="0xF099B8", VA="0xF099B8", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF099E4", Offset="0xF099E4", VA="0xF099E4")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF099CC", Offset="0xF099CC", VA="0xF099CC")]
		public AbilityEffect __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new AbilityEffect();
		}

		[Address(RVA="0xF099C0", Offset="0xF099C0", VA="0xF099C0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EC70C", Offset="0x15EC70C", VA="0x15EC70C")]
		public static void AddAssetId(FlatBufferBuilder builder, StringOffset assetIdOffset)
		{
		}

		[Address(RVA="0x15EC6D0", Offset="0x15EC6D0", VA="0x15EC6D0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15EC668", Offset="0x15EC668", VA="0x15EC668")]
		public static Offset<AbilityEffect> CreateAbilityEffect(FlatBufferBuilder builder, ulong id = 0L, StringOffset asset_idOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.AbilityEffect> Gamedata.AbilityEffect::CreateAbilityEffect(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.AbilityEffect> CreateAbilityEffect(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15EC748", Offset="0x15EC748", VA="0x15EC748")]
		public static Offset<AbilityEffect> EndAbilityEffect(FlatBufferBuilder builder)
		{
			return new Offset<AbilityEffect>();
		}

		[Address(RVA="0x15EC7F8", Offset="0x15EC7F8", VA="0x15EC7F8")]
		public static void FinishAbilityEffectBuffer(FlatBufferBuilder builder, Offset<AbilityEffect> offset)
		{
		}

		[Address(RVA="0xF099F4", Offset="0xF099F4", VA="0xF099F4")]
		public ArraySegment<byte>? GetAssetIdBytes()
		{
			return null;
		}

		[Address(RVA="0x15EC4D0", Offset="0x15EC4D0", VA="0x15EC4D0")]
		public static AbilityEffect GetRootAsAbilityEffect(FlatBuffers.ByteBuffer _bb)
		{
			return new AbilityEffect();
		}

		[Address(RVA="0x15EC4DC", Offset="0x15EC4DC", VA="0x15EC4DC")]
		public static AbilityEffect GetRootAsAbilityEffect(FlatBuffers.ByteBuffer _bb, AbilityEffect obj)
		{
			return new AbilityEffect();
		}

		[Address(RVA="0x15EC7C8", Offset="0x15EC7C8", VA="0x15EC7C8")]
		public static void StartAbilityEffect(FlatBufferBuilder builder)
		{
		}
	}
}