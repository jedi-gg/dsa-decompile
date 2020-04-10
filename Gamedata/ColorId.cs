using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ColorId : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF4447C", Offset="0xF4447C", VA="0xF4447C", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.Color? Color
		{
			[Address(RVA="0xF444B0", Offset="0xF444B0", VA="0xF444B0")]
			get
			{
				return null;
			}
		}

		public uint Id
		{
			[Address(RVA="0xF444A8", Offset="0xF444A8", VA="0xF444A8")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF44490", Offset="0xF44490", VA="0xF44490")]
		public ColorId __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ColorId();
		}

		[Address(RVA="0xF44484", Offset="0xF44484", VA="0xF44484", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x232A054", Offset="0x232A054", VA="0x232A054")]
		public static void AddColor(FlatBufferBuilder builder, Offset<Gamedata.Color> colorOffset)
		{
		}

		[Address(RVA="0x232A090", Offset="0x232A090", VA="0x232A090")]
		public static void AddId(FlatBufferBuilder builder, uint id)
		{
		}

		[Address(RVA="0x2329FEC", Offset="0x2329FEC", VA="0x2329FEC")]
		public static Offset<ColorId> CreateColorId(FlatBufferBuilder builder, uint id = 0, Offset<Gamedata.Color> colorOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ColorId> Gamedata.ColorId::CreateColorId(FlatBuffers.FlatBufferBuilder,System.UInt32,FlatBuffers.Offset`1<Gamedata.Color>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ColorId> CreateColorId(FlatBuffers.FlatBufferBuilder,System.UInt32,FlatBuffers.Offset<Gamedata.Color>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x232A0CC", Offset="0x232A0CC", VA="0x232A0CC")]
		public static Offset<ColorId> EndColorId(FlatBufferBuilder builder)
		{
			return new Offset<ColorId>();
		}

		[Address(RVA="0x2329E04", Offset="0x2329E04", VA="0x2329E04")]
		public static ColorId GetRootAsColorId(FlatBuffers.ByteBuffer _bb)
		{
			return new ColorId();
		}

		[Address(RVA="0x2329E10", Offset="0x2329E10", VA="0x2329E10")]
		public static ColorId GetRootAsColorId(FlatBuffers.ByteBuffer _bb, ColorId obj)
		{
			return new ColorId();
		}

		[Address(RVA="0x232A14C", Offset="0x232A14C", VA="0x232A14C")]
		public static void StartColorId(FlatBufferBuilder builder)
		{
		}
	}
}