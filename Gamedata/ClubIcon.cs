using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubIcon : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF439BC", Offset="0xF439BC", VA="0xF439BC", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Icon
		{
			[Address(RVA="0xF439F0", Offset="0xF439F0", VA="0xF439F0")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF439E8", Offset="0xF439E8", VA="0xF439E8")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF439D0", Offset="0xF439D0", VA="0xF439D0")]
		public ClubIcon __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubIcon();
		}

		[Address(RVA="0xF439C4", Offset="0xF439C4", VA="0xF439C4", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2322B84", Offset="0x2322B84", VA="0x2322B84")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x2322B48", Offset="0x2322B48", VA="0x2322B48")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x2322AE0", Offset="0x2322AE0", VA="0x2322AE0")]
		public static Offset<ClubIcon> CreateClubIcon(FlatBufferBuilder builder, ulong id = 0L, StringOffset iconOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubIcon> Gamedata.ClubIcon::CreateClubIcon(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubIcon> CreateClubIcon(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2322BC0", Offset="0x2322BC0", VA="0x2322BC0")]
		public static Offset<ClubIcon> EndClubIcon(FlatBufferBuilder builder)
		{
			return new Offset<ClubIcon>();
		}

		[Address(RVA="0x2322C70", Offset="0x2322C70", VA="0x2322C70")]
		public static void FinishClubIconBuffer(FlatBufferBuilder builder, Offset<ClubIcon> offset)
		{
		}

		[Address(RVA="0xF439F8", Offset="0xF439F8", VA="0xF439F8")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0x2322948", Offset="0x2322948", VA="0x2322948")]
		public static ClubIcon GetRootAsClubIcon(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubIcon();
		}

		[Address(RVA="0x2322954", Offset="0x2322954", VA="0x2322954")]
		public static ClubIcon GetRootAsClubIcon(FlatBuffers.ByteBuffer _bb, ClubIcon obj)
		{
			return new ClubIcon();
		}

		[Address(RVA="0x2322C40", Offset="0x2322C40", VA="0x2322C40")]
		public static void StartClubIcon(FlatBufferBuilder builder)
		{
		}
	}
}