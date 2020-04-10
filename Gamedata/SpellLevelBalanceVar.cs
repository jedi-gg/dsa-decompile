using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SpellLevelBalanceVar : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A0E8", Offset="0xF3A0E8", VA="0xF3A0E8", Slot="5")]
			get
			{
				return null;
			}
		}

		public int ValuesLength
		{
			[Address(RVA="0xF3A11C", Offset="0xF3A11C", VA="0xF3A11C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3A0FC", Offset="0xF3A0FC", VA="0xF3A0FC")]
		public SpellLevelBalanceVar __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SpellLevelBalanceVar();
		}

		[Address(RVA="0xF3A0F0", Offset="0xF3A0F0", VA="0xF3A0F0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DCBAC", Offset="0x22DCBAC", VA="0x22DCBAC")]
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
		}

		[Address(RVA="0x22DCB5C", Offset="0x22DCB5C", VA="0x22DCB5C")]
		public static Offset<SpellLevelBalanceVar> CreateSpellLevelBalanceVar(FlatBufferBuilder builder, VectorOffset valuesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SpellLevelBalanceVar> Gamedata.SpellLevelBalanceVar::CreateSpellLevelBalanceVar(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SpellLevelBalanceVar> CreateSpellLevelBalanceVar(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22DCC98", Offset="0x22DCC98", VA="0x22DCC98")]
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, float[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22DCBE8", Offset="0x22DCBE8", VA="0x22DCBE8")]
		public static Offset<SpellLevelBalanceVar> EndSpellLevelBalanceVar(FlatBufferBuilder builder)
		{
			return new Offset<SpellLevelBalanceVar>();
		}

		[Address(RVA="0x22DC9B4", Offset="0x22DC9B4", VA="0x22DC9B4")]
		public static SpellLevelBalanceVar GetRootAsSpellLevelBalanceVar(FlatBuffers.ByteBuffer _bb)
		{
			return new SpellLevelBalanceVar();
		}

		[Address(RVA="0x22DC9C0", Offset="0x22DC9C0", VA="0x22DC9C0")]
		public static SpellLevelBalanceVar GetRootAsSpellLevelBalanceVar(FlatBuffers.ByteBuffer _bb, SpellLevelBalanceVar obj)
		{
			return new SpellLevelBalanceVar();
		}

		[Address(RVA="0xF3A124", Offset="0xF3A124", VA="0xF3A124")]
		public ArraySegment<byte>? GetValuesBytes()
		{
			return null;
		}

		[Address(RVA="0x22DCC68", Offset="0x22DCC68", VA="0x22DCC68")]
		public static void StartSpellLevelBalanceVar(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x22DCD90", Offset="0x22DCD90", VA="0x22DCD90")]
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF3A114", Offset="0xF3A114", VA="0xF3A114")]
		public float Values(int j)
		{
			return new float();
		}
	}
}