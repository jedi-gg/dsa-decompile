using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreGrantChance : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3ABC0", Offset="0xF3ABC0", VA="0xF3ABC0", Slot="5")]
			get
			{
				return null;
			}
		}

		public float Chance
		{
			[Address(RVA="0xF3ABEC", Offset="0xF3ABEC", VA="0xF3ABEC")]
			get
			{
				return new float();
			}
		}

		public ulong Grant
		{
			[Address(RVA="0xF3ABF4", Offset="0xF3ABF4", VA="0xF3ABF4")]
			get
			{
				return new ulong();
			}
		}

		public StoreGrant? GrantOverride
		{
			[Address(RVA="0xF3ABFC", Offset="0xF3ABFC", VA="0xF3ABFC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF3ABD4", Offset="0xF3ABD4", VA="0xF3ABD4")]
		public StoreGrantChance __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreGrantChance();
		}

		[Address(RVA="0xF3ABC8", Offset="0xF3ABC8", VA="0xF3ABC8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22E6C8C", Offset="0x22E6C8C", VA="0x22E6C8C")]
		public static void AddChance(FlatBufferBuilder builder, float chance)
		{
		}

		[Address(RVA="0x22E6C14", Offset="0x22E6C14", VA="0x22E6C14")]
		public static void AddGrant(FlatBufferBuilder builder, ulong grant)
		{
		}

		[Address(RVA="0x22E6C50", Offset="0x22E6C50", VA="0x22E6C50")]
		public static void AddGrantOverride(FlatBufferBuilder builder, Offset<StoreGrant> grantOverrideOffset)
		{
		}

		[Address(RVA="0x22E6B94", Offset="0x22E6B94", VA="0x22E6B94")]
		public static Offset<StoreGrantChance> CreateStoreGrantChance(FlatBufferBuilder builder, float chance = 0f, ulong grant = 0L, Offset<StoreGrant> grant_overrideOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.StoreGrantChance> Gamedata.StoreGrantChance::CreateStoreGrantChance(FlatBuffers.FlatBufferBuilder,System.Single,System.UInt64,FlatBuffers.Offset`1<Gamedata.StoreGrant>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.StoreGrantChance> CreateStoreGrantChance(FlatBuffers.FlatBufferBuilder,System.Single,System.UInt64,FlatBuffers.Offset<Gamedata.StoreGrant>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22E6CD0", Offset="0x22E6CD0", VA="0x22E6CD0")]
		public static Offset<StoreGrantChance> EndStoreGrantChance(FlatBufferBuilder builder)
		{
			return new Offset<StoreGrantChance>();
		}

		[Address(RVA="0x22E693C", Offset="0x22E693C", VA="0x22E693C")]
		public static StoreGrantChance GetRootAsStoreGrantChance(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreGrantChance();
		}

		[Address(RVA="0x22E6948", Offset="0x22E6948", VA="0x22E6948")]
		public static StoreGrantChance GetRootAsStoreGrantChance(FlatBuffers.ByteBuffer _bb, StoreGrantChance obj)
		{
			return new StoreGrantChance();
		}

		[Address(RVA="0x22E6D50", Offset="0x22E6D50", VA="0x22E6D50")]
		public static void StartStoreGrantChance(FlatBufferBuilder builder)
		{
		}
	}
}