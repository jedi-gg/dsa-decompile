using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleMutator : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A718", Offset="0xF0A718", VA="0xF0A718", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0A744", Offset="0xF0A744", VA="0xF0A744")]
			get
			{
				return new ulong();
			}
		}

		public int VisualEffectsLength
		{
			[Address(RVA="0xF0A754", Offset="0xF0A754", VA="0xF0A754")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF0A72C", Offset="0xF0A72C", VA="0xF0A72C")]
		public BattleMutator __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMutator();
		}

		[Address(RVA="0xF0A720", Offset="0xF0A720", VA="0xF0A720", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F32F4", Offset="0x15F32F4", VA="0x15F32F4")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F3330", Offset="0x15F3330", VA="0x15F3330")]
		public static void AddVisualEffects(FlatBufferBuilder builder, VectorOffset visualEffectsOffset)
		{
		}

		[Address(RVA="0x15F328C", Offset="0x15F328C", VA="0x15F328C")]
		public static Offset<BattleMutator> CreateBattleMutator(FlatBufferBuilder builder, ulong id = 0L, VectorOffset visual_effectsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleMutator> Gamedata.BattleMutator::CreateBattleMutator(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleMutator> CreateBattleMutator(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F341C", Offset="0x15F341C", VA="0x15F341C")]
		public static VectorOffset CreateVisualEffectsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F336C", Offset="0x15F336C", VA="0x15F336C")]
		public static Offset<BattleMutator> EndBattleMutator(FlatBufferBuilder builder)
		{
			return new Offset<BattleMutator>();
		}

		[Address(RVA="0x15F3550", Offset="0x15F3550", VA="0x15F3550")]
		public static void FinishBattleMutatorBuffer(FlatBufferBuilder builder, Offset<BattleMutator> offset)
		{
		}

		[Address(RVA="0x15F3078", Offset="0x15F3078", VA="0x15F3078")]
		public static BattleMutator GetRootAsBattleMutator(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMutator();
		}

		[Address(RVA="0x15F3084", Offset="0x15F3084", VA="0x15F3084")]
		public static BattleMutator GetRootAsBattleMutator(FlatBuffers.ByteBuffer _bb, BattleMutator obj)
		{
			return new BattleMutator();
		}

		[Address(RVA="0xF0A75C", Offset="0xF0A75C", VA="0xF0A75C")]
		public ArraySegment<byte>? GetVisualEffectsBytes()
		{
			return null;
		}

		[Address(RVA="0x15F33EC", Offset="0x15F33EC", VA="0x15F33EC")]
		public static void StartBattleMutator(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F3514", Offset="0x15F3514", VA="0x15F3514")]
		public static void StartVisualEffectsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF0A74C", Offset="0xF0A74C", VA="0xF0A74C")]
		public ulong VisualEffects(int j)
		{
			return new ulong();
		}
	}
}