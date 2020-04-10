using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SquadSelector : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A510", Offset="0xF3A510", VA="0xF3A510", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF3A53C", Offset="0xF3A53C", VA="0xF3A53C")]
			get
			{
				return new ulong();
			}
		}

		public int SquadsLength
		{
			[Address(RVA="0xF3A54C", Offset="0xF3A54C", VA="0xF3A54C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3A524", Offset="0xF3A524", VA="0xF3A524")]
		public SquadSelector __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SquadSelector();
		}

		[Address(RVA="0xF3A518", Offset="0xF3A518", VA="0xF3A518", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DED34", Offset="0x22DED34", VA="0x22DED34")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x22DED70", Offset="0x22DED70", VA="0x22DED70")]
		public static void AddSquads(FlatBufferBuilder builder, VectorOffset squadsOffset)
		{
		}

		[Address(RVA="0x22DECCC", Offset="0x22DECCC", VA="0x22DECCC")]
		public static Offset<SquadSelector> CreateSquadSelector(FlatBufferBuilder builder, ulong id = 0L, VectorOffset squadsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SquadSelector> Gamedata.SquadSelector::CreateSquadSelector(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SquadSelector> CreateSquadSelector(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22DEE5C", Offset="0x22DEE5C", VA="0x22DEE5C")]
		public static VectorOffset CreateSquadsVector(FlatBufferBuilder builder, Offset<SquadSelectorWeight>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22DEDAC", Offset="0x22DEDAC", VA="0x22DEDAC")]
		public static Offset<SquadSelector> EndSquadSelector(FlatBufferBuilder builder)
		{
			return new Offset<SquadSelector>();
		}

		[Address(RVA="0x22DEF90", Offset="0x22DEF90", VA="0x22DEF90")]
		public static void FinishSquadSelectorBuffer(FlatBufferBuilder builder, Offset<SquadSelector> offset)
		{
		}

		[Address(RVA="0x22DEA6C", Offset="0x22DEA6C", VA="0x22DEA6C")]
		public static SquadSelector GetRootAsSquadSelector(FlatBuffers.ByteBuffer _bb)
		{
			return new SquadSelector();
		}

		[Address(RVA="0x22DEA78", Offset="0x22DEA78", VA="0x22DEA78")]
		public static SquadSelector GetRootAsSquadSelector(FlatBuffers.ByteBuffer _bb, SquadSelector obj)
		{
			return new SquadSelector();
		}

		[Address(RVA="0xF3A544", Offset="0xF3A544", VA="0xF3A544")]
		public SquadSelectorWeight? Squads(int j)
		{
			return null;
		}

		[Address(RVA="0x22DEE2C", Offset="0x22DEE2C", VA="0x22DEE2C")]
		public static void StartSquadSelector(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x22DEF54", Offset="0x22DEF54", VA="0x22DEF54")]
		public static void StartSquadsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}