using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubWarEdge : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string A
		{
			[Address(RVA="0xF43FC0", Offset="0xF43FC0", VA="0xF43FC0")]
			get
			{
				return null;
			}
		}

		public string B
		{
			[Address(RVA="0xF43FD8", Offset="0xF43FD8", VA="0xF43FD8")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43F94", Offset="0xF43F94", VA="0xF43F94", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF43FA8", Offset="0xF43FA8", VA="0xF43FA8")]
		public ClubWarEdge __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarEdge();
		}

		[Address(RVA="0xF43F9C", Offset="0xF43F9C", VA="0xF43F9C", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2326A28", Offset="0x2326A28", VA="0x2326A28")]
		public static void AddA(FlatBufferBuilder builder, StringOffset aOffset)
		{
		}

		[Address(RVA="0x23269EC", Offset="0x23269EC", VA="0x23269EC")]
		public static void AddB(FlatBufferBuilder builder, StringOffset bOffset)
		{
		}

		[Address(RVA="0x2326984", Offset="0x2326984", VA="0x2326984")]
		public static Offset<ClubWarEdge> CreateClubWarEdge(FlatBufferBuilder builder, StringOffset aOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubWarEdge> Gamedata.ClubWarEdge::CreateClubWarEdge(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubWarEdge> CreateClubWarEdge(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2326A64", Offset="0x2326A64", VA="0x2326A64")]
		public static Offset<ClubWarEdge> EndClubWarEdge(FlatBufferBuilder builder)
		{
			return new Offset<ClubWarEdge>();
		}

		[Address(RVA="0xF43FC8", Offset="0xF43FC8", VA="0xF43FC8")]
		public ArraySegment<byte>? GetABytes()
		{
			return null;
		}

		[Address(RVA="0xF43FE0", Offset="0xF43FE0", VA="0xF43FE0")]
		public ArraySegment<byte>? GetBBytes()
		{
			return null;
		}

		[Address(RVA="0x2326818", Offset="0x2326818", VA="0x2326818")]
		public static ClubWarEdge GetRootAsClubWarEdge(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarEdge();
		}

		[Address(RVA="0x2326824", Offset="0x2326824", VA="0x2326824")]
		public static ClubWarEdge GetRootAsClubWarEdge(FlatBuffers.ByteBuffer _bb, ClubWarEdge obj)
		{
			return new ClubWarEdge();
		}

		[Address(RVA="0x2326AE4", Offset="0x2326AE4", VA="0x2326AE4")]
		public static void StartClubWarEdge(FlatBufferBuilder builder)
		{
		}
	}
}