using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ScheduledEventTime : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public OccasionRef? ActiveOccasion
		{
			[Address(RVA="0xF587A4", Offset="0xF587A4", VA="0xF587A4")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58770", Offset="0xF58770", VA="0xF58770", Slot="5")]
			get
			{
				return null;
			}
		}

		public OccasionRef? PreviewOccasion
		{
			[Address(RVA="0xF5879C", Offset="0xF5879C", VA="0xF5879C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF58784", Offset="0xF58784", VA="0xF58784")]
		public ScheduledEventTime __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ScheduledEventTime();
		}

		[Address(RVA="0xF58778", Offset="0xF58778", VA="0xF58778", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E6DEC", Offset="0x24E6DEC", VA="0x24E6DEC")]
		public static void AddActiveOccasion(FlatBufferBuilder builder, Offset<OccasionRef> activeOccasionOffset)
		{
		}

		[Address(RVA="0x24E6E28", Offset="0x24E6E28", VA="0x24E6E28")]
		public static void AddPreviewOccasion(FlatBufferBuilder builder, Offset<OccasionRef> previewOccasionOffset)
		{
		}

		[Address(RVA="0x24E6D84", Offset="0x24E6D84", VA="0x24E6D84")]
		public static Offset<ScheduledEventTime> CreateScheduledEventTime(FlatBufferBuilder builder, Offset<OccasionRef> preview_occasionOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ScheduledEventTime> Gamedata.ScheduledEventTime::CreateScheduledEventTime(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset`1<Gamedata.OccasionRef>,FlatBuffers.Offset`1<Gamedata.OccasionRef>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ScheduledEventTime> CreateScheduledEventTime(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset<Gamedata.OccasionRef>,FlatBuffers.Offset<Gamedata.OccasionRef>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E6E64", Offset="0x24E6E64", VA="0x24E6E64")]
		public static Offset<ScheduledEventTime> EndScheduledEventTime(FlatBufferBuilder builder)
		{
			return new Offset<ScheduledEventTime>();
		}

		[Address(RVA="0x24E6B28", Offset="0x24E6B28", VA="0x24E6B28")]
		public static ScheduledEventTime GetRootAsScheduledEventTime(FlatBuffers.ByteBuffer _bb)
		{
			return new ScheduledEventTime();
		}

		[Address(RVA="0x24E6B34", Offset="0x24E6B34", VA="0x24E6B34")]
		public static ScheduledEventTime GetRootAsScheduledEventTime(FlatBuffers.ByteBuffer _bb, ScheduledEventTime obj)
		{
			return new ScheduledEventTime();
		}

		[Address(RVA="0x24E6EE4", Offset="0x24E6EE4", VA="0x24E6EE4")]
		public static void StartScheduledEventTime(FlatBufferBuilder builder)
		{
		}
	}
}