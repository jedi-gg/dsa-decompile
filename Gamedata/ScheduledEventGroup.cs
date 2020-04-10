using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ScheduledEventGroup : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58660", Offset="0xF58660", VA="0xF58660", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Description
		{
			[Address(RVA="0xF586AC", Offset="0xF586AC", VA="0xF586AC")]
			get
			{
				return null;
			}
		}

		public bool DisableTimer
		{
			[Address(RVA="0xF5871C", Offset="0xF5871C", VA="0xF5871C")]
			get
			{
				return new bool();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5868C", Offset="0xF5868C", VA="0xF5868C")]
			get
			{
				return new ulong();
			}
		}

		public string Image
		{
			[Address(RVA="0xF586C4", Offset="0xF586C4", VA="0xF586C4")]
			get
			{
				return null;
			}
		}

		public string MarqueeImage
		{
			[Address(RVA="0xF58704", Offset="0xF58704", VA="0xF58704")]
			get
			{
				return null;
			}
		}

		public string Name
		{
			[Address(RVA="0xF58694", Offset="0xF58694", VA="0xF58694")]
			get
			{
				return null;
			}
		}

		public int ShowcaseItemsLength
		{
			[Address(RVA="0xF586EC", Offset="0xF586EC", VA="0xF586EC")]
			get
			{
				return new int();
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF586DC", Offset="0xF586DC", VA="0xF586DC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF58674", Offset="0xF58674", VA="0xF58674")]
		public ScheduledEventGroup __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ScheduledEventGroup();
		}

		[Address(RVA="0xF58668", Offset="0xF58668", VA="0xF58668", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E6854", Offset="0x24E6854", VA="0x24E6854")]
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
		}

		[Address(RVA="0x24E68CC", Offset="0x24E68CC", VA="0x24E68CC")]
		public static void AddDisableTimer(FlatBufferBuilder builder, bool disableTimer)
		{
		}

		[Address(RVA="0x24E6728", Offset="0x24E6728", VA="0x24E6728")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24E6818", Offset="0x24E6818", VA="0x24E6818")]
		public static void AddImage(FlatBufferBuilder builder, StringOffset imageOffset)
		{
		}

		[Address(RVA="0x24E6764", Offset="0x24E6764", VA="0x24E6764")]
		public static void AddMarqueeImage(FlatBufferBuilder builder, StringOffset marqueeImageOffset)
		{
		}

		[Address(RVA="0x24E6890", Offset="0x24E6890", VA="0x24E6890")]
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
		}

		[Address(RVA="0x24E67A0", Offset="0x24E67A0", VA="0x24E67A0")]
		public static void AddShowcaseItems(FlatBufferBuilder builder, VectorOffset showcaseItemsOffset)
		{
		}

		[Address(RVA="0x24E67DC", Offset="0x24E67DC", VA="0x24E67DC")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x24E6648", Offset="0x24E6648", VA="0x24E6648")]
		public static Offset<ScheduledEventGroup> CreateScheduledEventGroup(FlatBufferBuilder builder, ulong id = 0L, StringOffset nameOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ScheduledEventGroup> Gamedata.ScheduledEventGroup::CreateScheduledEventGroup(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ScheduledEventGroup> CreateScheduledEventGroup(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E69B8", Offset="0x24E69B8", VA="0x24E69B8")]
		public static VectorOffset CreateShowcaseItemsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E6908", Offset="0x24E6908", VA="0x24E6908")]
		public static Offset<ScheduledEventGroup> EndScheduledEventGroup(FlatBufferBuilder builder)
		{
			return new Offset<ScheduledEventGroup>();
		}

		[Address(RVA="0x24E6AEC", Offset="0x24E6AEC", VA="0x24E6AEC")]
		public static void FinishScheduledEventGroupBuffer(FlatBufferBuilder builder, Offset<ScheduledEventGroup> offset)
		{
		}

		[Address(RVA="0xF586B4", Offset="0xF586B4", VA="0xF586B4")]
		public ArraySegment<byte>? GetDescriptionBytes()
		{
			return null;
		}

		[Address(RVA="0xF586CC", Offset="0xF586CC", VA="0xF586CC")]
		public ArraySegment<byte>? GetImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF5870C", Offset="0xF5870C", VA="0xF5870C")]
		public ArraySegment<byte>? GetMarqueeImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF5869C", Offset="0xF5869C", VA="0xF5869C")]
		public ArraySegment<byte>? GetNameBytes()
		{
			return null;
		}

		[Address(RVA="0x24E6208", Offset="0x24E6208", VA="0x24E6208")]
		public static ScheduledEventGroup GetRootAsScheduledEventGroup(FlatBuffers.ByteBuffer _bb)
		{
			return new ScheduledEventGroup();
		}

		[Address(RVA="0x24E6214", Offset="0x24E6214", VA="0x24E6214")]
		public static ScheduledEventGroup GetRootAsScheduledEventGroup(FlatBuffers.ByteBuffer _bb, ScheduledEventGroup obj)
		{
			return new ScheduledEventGroup();
		}

		[Address(RVA="0xF586F4", Offset="0xF586F4", VA="0xF586F4")]
		public ArraySegment<byte>? GetShowcaseItemsBytes()
		{
			return null;
		}

		[Address(RVA="0xF586E4", Offset="0xF586E4", VA="0xF586E4")]
		public ulong ShowcaseItems(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x24E6988", Offset="0x24E6988", VA="0x24E6988")]
		public static void StartScheduledEventGroup(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24E6AB0", Offset="0x24E6AB0", VA="0x24E6AB0")]
		public static void StartShowcaseItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}