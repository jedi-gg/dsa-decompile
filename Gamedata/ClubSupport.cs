using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubSupport : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43A54", Offset="0xF43A54", VA="0xF43A54", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF43A80", Offset="0xF43A80", VA="0xF43A80")]
			get
			{
				return new ulong();
			}
		}

		public uint RequestFulfillCooldownS
		{
			[Address(RVA="0xF43A98", Offset="0xF43A98", VA="0xF43A98")]
			get
			{
				return new uint();
			}
		}

		public int RequestsLength
		{
			[Address(RVA="0xF43A90", Offset="0xF43A90", VA="0xF43A90")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF43A68", Offset="0xF43A68", VA="0xF43A68")]
		public ClubSupport __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubSupport();
		}

		[Address(RVA="0xF43A5C", Offset="0xF43A5C", VA="0xF43A5C", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2322FEC", Offset="0x2322FEC", VA="0x2322FEC")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x2323028", Offset="0x2323028", VA="0x2323028")]
		public static void AddRequestFulfillCooldownS(FlatBufferBuilder builder, uint requestFulfillCooldownS)
		{
		}

		[Address(RVA="0x2323064", Offset="0x2323064", VA="0x2323064")]
		public static void AddRequests(FlatBufferBuilder builder, VectorOffset requestsOffset)
		{
		}

		[Address(RVA="0x2322F74", Offset="0x2322F74", VA="0x2322F74")]
		public static Offset<ClubSupport> CreateClubSupport(FlatBufferBuilder builder, ulong id = 0L, VectorOffset requestsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubSupport> Gamedata.ClubSupport::CreateClubSupport(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.UInt32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubSupport> CreateClubSupport(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.UInt32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2323150", Offset="0x2323150", VA="0x2323150")]
		public static VectorOffset CreateRequestsVector(FlatBufferBuilder builder, Offset<ClubSupportRequest>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23230A0", Offset="0x23230A0", VA="0x23230A0")]
		public static Offset<ClubSupport> EndClubSupport(FlatBufferBuilder builder)
		{
			return new Offset<ClubSupport>();
		}

		[Address(RVA="0x2323284", Offset="0x2323284", VA="0x2323284")]
		public static void FinishClubSupportBuffer(FlatBufferBuilder builder, Offset<ClubSupport> offset)
		{
		}

		[Address(RVA="0x2322CAC", Offset="0x2322CAC", VA="0x2322CAC")]
		public static ClubSupport GetRootAsClubSupport(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubSupport();
		}

		[Address(RVA="0x2322CB8", Offset="0x2322CB8", VA="0x2322CB8")]
		public static ClubSupport GetRootAsClubSupport(FlatBuffers.ByteBuffer _bb, ClubSupport obj)
		{
			return new ClubSupport();
		}

		[Address(RVA="0xF43A88", Offset="0xF43A88", VA="0xF43A88")]
		public ClubSupportRequest? Requests(int j)
		{
			return null;
		}

		[Address(RVA="0x2323120", Offset="0x2323120", VA="0x2323120")]
		public static void StartClubSupport(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x2323248", Offset="0x2323248", VA="0x2323248")]
		public static void StartRequestsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}