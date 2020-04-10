using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitRangeName : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BC90", Offset="0xF0BC90", VA="0xF0BC90", Slot="5")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0BCC4", Offset="0xF0BCC4", VA="0xF0BCC4")]
			get
			{
				return null;
			}
		}

		public float RangeValue
		{
			[Address(RVA="0xF0BCBC", Offset="0xF0BCBC", VA="0xF0BCBC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF0BCA4", Offset="0xF0BCA4", VA="0xF0BCA4")]
		public UnitRangeName __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitRangeName();
		}

		[Address(RVA="0xF0BC98", Offset="0xF0BC98", VA="0xF0BC98", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167CA7C", Offset="0x167CA7C", VA="0x167CA7C")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x167CAB8", Offset="0x167CAB8", VA="0x167CAB8")]
		public static void AddRangeValue(FlatBufferBuilder builder, float rangeValue)
		{
		}

		[Address(RVA="0x167CA14", Offset="0x167CA14", VA="0x167CA14")]
		public static Offset<UnitRangeName> CreateUnitRangeName(FlatBufferBuilder builder, float range_value = 0f, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitRangeName> Gamedata.UnitRangeName::CreateUnitRangeName(FlatBuffers.FlatBufferBuilder,System.Single,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitRangeName> CreateUnitRangeName(FlatBuffers.FlatBufferBuilder,System.Single,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x167CAFC", Offset="0x167CAFC", VA="0x167CAFC")]
		public static Offset<UnitRangeName> EndUnitRangeName(FlatBufferBuilder builder)
		{
			return new Offset<UnitRangeName>();
		}

		[Address(RVA="0xF0BCCC", Offset="0xF0BCCC", VA="0xF0BCCC")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x167C87C", Offset="0x167C87C", VA="0x167C87C")]
		public static UnitRangeName GetRootAsUnitRangeName(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitRangeName();
		}

		[Address(RVA="0x167C888", Offset="0x167C888", VA="0x167C888")]
		public static UnitRangeName GetRootAsUnitRangeName(FlatBuffers.ByteBuffer _bb, UnitRangeName obj)
		{
			return new UnitRangeName();
		}

		[Address(RVA="0x167CB7C", Offset="0x167CB7C", VA="0x167CB7C")]
		public static void StartUnitRangeName(FlatBufferBuilder builder)
		{
		}
	}
}