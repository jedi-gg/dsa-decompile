using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PassportSeasonWeek : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int ActivitiesLength
		{
			[Address(RVA="0xF5744C", Offset="0xF5744C", VA="0xF5744C")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57418", Offset="0xF57418", VA="0xF57418", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF5742C", Offset="0xF5742C", VA="0xF5742C")]
		public PassportSeasonWeek __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonWeek();
		}

		[Address(RVA="0xF57420", Offset="0xF57420", VA="0xF57420", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0xF57444", Offset="0xF57444", VA="0xF57444")]
		public ulong Activities(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x24DB0CC", Offset="0x24DB0CC", VA="0x24DB0CC")]
		public static void AddActivities(FlatBufferBuilder builder, VectorOffset activitiesOffset)
		{
		}

		[Address(RVA="0x24DB1B8", Offset="0x24DB1B8", VA="0x24DB1B8")]
		public static VectorOffset CreateActivitiesVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DB07C", Offset="0x24DB07C", VA="0x24DB07C")]
		public static Offset<PassportSeasonWeek> CreatePassportSeasonWeek(FlatBufferBuilder builder, VectorOffset activitiesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PassportSeasonWeek> Gamedata.PassportSeasonWeek::CreatePassportSeasonWeek(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PassportSeasonWeek> CreatePassportSeasonWeek(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24DB108", Offset="0x24DB108", VA="0x24DB108")]
		public static Offset<PassportSeasonWeek> EndPassportSeasonWeek(FlatBufferBuilder builder)
		{
			return new Offset<PassportSeasonWeek>();
		}

		[Address(RVA="0xF57454", Offset="0xF57454", VA="0xF57454")]
		public ArraySegment<byte>? GetActivitiesBytes()
		{
			return null;
		}

		[Address(RVA="0x24DAEEC", Offset="0x24DAEEC", VA="0x24DAEEC")]
		public static PassportSeasonWeek GetRootAsPassportSeasonWeek(FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonWeek();
		}

		[Address(RVA="0x24DAEF8", Offset="0x24DAEF8", VA="0x24DAEF8")]
		public static PassportSeasonWeek GetRootAsPassportSeasonWeek(FlatBuffers.ByteBuffer _bb, PassportSeasonWeek obj)
		{
			return new PassportSeasonWeek();
		}

		[Address(RVA="0x24DB2B0", Offset="0x24DB2B0", VA="0x24DB2B0")]
		public static void StartActivitiesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DB188", Offset="0x24DB188", VA="0x24DB188")]
		public static void StartPassportSeasonWeek(FlatBufferBuilder builder)
		{
		}
	}
}