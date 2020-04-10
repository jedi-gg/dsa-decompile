using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct OccasionSchedule : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56E28", Offset="0xF56E28", VA="0xF56E28", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint DurationS
		{
			[Address(RVA="0xF56E5C", Offset="0xF56E5C", VA="0xF56E5C")]
			get
			{
				return new uint();
			}
		}

		public int SegmentsLength
		{
			[Address(RVA="0xF56E6C", Offset="0xF56E6C", VA="0xF56E6C")]
			get
			{
				return new int();
			}
		}

		public uint StartTimestamp
		{
			[Address(RVA="0xF56E54", Offset="0xF56E54", VA="0xF56E54")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF56E3C", Offset="0xF56E3C", VA="0xF56E3C")]
		public OccasionSchedule __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new OccasionSchedule();
		}

		[Address(RVA="0xF56E30", Offset="0xF56E30", VA="0xF56E30", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D7AC4", Offset="0x24D7AC4", VA="0x24D7AC4")]
		public static void AddDurationS(FlatBufferBuilder builder, uint durationS)
		{
		}

		[Address(RVA="0x24D7A88", Offset="0x24D7A88", VA="0x24D7A88")]
		public static void AddSegments(FlatBufferBuilder builder, VectorOffset segmentsOffset)
		{
		}

		[Address(RVA="0x24D7B00", Offset="0x24D7B00", VA="0x24D7B00")]
		public static void AddStartTimestamp(FlatBufferBuilder builder, uint startTimestamp)
		{
		}

		[Address(RVA="0x24D7A10", Offset="0x24D7A10", VA="0x24D7A10")]
		public static Offset<OccasionSchedule> CreateOccasionSchedule(FlatBufferBuilder builder, uint start_timestamp = 0, uint duration_s = 0, VectorOffset segmentsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.OccasionSchedule> Gamedata.OccasionSchedule::CreateOccasionSchedule(FlatBuffers.FlatBufferBuilder,System.UInt32,System.UInt32,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.OccasionSchedule> CreateOccasionSchedule(FlatBuffers.FlatBufferBuilder,System.UInt32,System.UInt32,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D7BEC", Offset="0x24D7BEC", VA="0x24D7BEC")]
		public static VectorOffset CreateSegmentsVector(FlatBufferBuilder builder, Offset<OccasionSegment>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D7B3C", Offset="0x24D7B3C", VA="0x24D7B3C")]
		public static Offset<OccasionSchedule> EndOccasionSchedule(FlatBufferBuilder builder)
		{
			return new Offset<OccasionSchedule>();
		}

		[Address(RVA="0x24D7764", Offset="0x24D7764", VA="0x24D7764")]
		public static OccasionSchedule GetRootAsOccasionSchedule(FlatBuffers.ByteBuffer _bb)
		{
			return new OccasionSchedule();
		}

		[Address(RVA="0x24D7770", Offset="0x24D7770", VA="0x24D7770")]
		public static OccasionSchedule GetRootAsOccasionSchedule(FlatBuffers.ByteBuffer _bb, OccasionSchedule obj)
		{
			return new OccasionSchedule();
		}

		[Address(RVA="0xF56E64", Offset="0xF56E64", VA="0xF56E64")]
		public OccasionSegment? Segments(int j)
		{
			return null;
		}

		[Address(RVA="0x24D7BBC", Offset="0x24D7BBC", VA="0x24D7BBC")]
		public static void StartOccasionSchedule(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24D7CE4", Offset="0x24D7CE4", VA="0x24D7CE4")]
		public static void StartSegmentsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}