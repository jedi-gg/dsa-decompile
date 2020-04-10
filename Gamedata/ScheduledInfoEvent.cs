using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ScheduledInfoEvent : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string BannerImage
		{
			[Address(RVA="0xF588B4", Offset="0xF588B4", VA="0xF588B4")]
			get
			{
				return null;
			}
		}

		public string BannerText
		{
			[Address(RVA="0xF588CC", Offset="0xF588CC", VA="0xF588CC")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF587F8", Offset="0xF587F8", VA="0xF587F8", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.DeepLinkLocation DeepLinkLocation
		{
			[Address(RVA="0xF58914", Offset="0xF58914", VA="0xF58914")]
			get
			{
				return new Gamedata.DeepLinkLocation();
			}
		}

		public string DeepLinkSublocation
		{
			[Address(RVA="0xF5891C", Offset="0xF5891C", VA="0xF5891C")]
			get
			{
				return null;
			}
		}

		public string Description
		{
			[Address(RVA="0xF58864", Offset="0xF58864", VA="0xF58864")]
			get
			{
				return null;
			}
		}

		public ulong EventGroupId
		{
			[Address(RVA="0xF5882C", Offset="0xF5882C", VA="0xF5882C")]
			get
			{
				return new ulong();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF58824", Offset="0xF58824", VA="0xF58824")]
			get
			{
				return new ulong();
			}
		}

		public string Image
		{
			[Address(RVA="0xF5887C", Offset="0xF5887C", VA="0xF5887C")]
			get
			{
				return null;
			}
		}

		public string Name
		{
			[Address(RVA="0xF5884C", Offset="0xF5884C", VA="0xF5884C")]
			get
			{
				return null;
			}
		}

		public string PreviewText
		{
			[Address(RVA="0xF5889C", Offset="0xF5889C", VA="0xF5889C")]
			get
			{
				return null;
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF58834", Offset="0xF58834", VA="0xF58834")]
			get
			{
				return null;
			}
		}

		public int ShowcaseItemsLength
		{
			[Address(RVA="0xF588EC", Offset="0xF588EC", VA="0xF588EC")]
			get
			{
				return new int();
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF58894", Offset="0xF58894", VA="0xF58894")]
			get
			{
				return new int();
			}
		}

		public int TimesLength
		{
			[Address(RVA="0xF5890C", Offset="0xF5890C", VA="0xF5890C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5880C", Offset="0xF5880C", VA="0xF5880C")]
		public ScheduledInfoEvent __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ScheduledInfoEvent();
		}

		[Address(RVA="0xF58800", Offset="0xF58800", VA="0xF58800", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E78E8", Offset="0x24E78E8", VA="0x24E78E8")]
		public static void AddBannerImage(FlatBufferBuilder builder, StringOffset bannerImageOffset)
		{
		}

		[Address(RVA="0x24E78AC", Offset="0x24E78AC", VA="0x24E78AC")]
		public static void AddBannerText(FlatBufferBuilder builder, StringOffset bannerTextOffset)
		{
		}

		[Address(RVA="0x24E7A8C", Offset="0x24E7A8C", VA="0x24E7A8C")]
		public static void AddDeepLinkLocation(FlatBufferBuilder builder, Gamedata.DeepLinkLocation deepLinkLocation)
		{
		}

		[Address(RVA="0x24E77F8", Offset="0x24E77F8", VA="0x24E77F8")]
		public static void AddDeepLinkSublocation(FlatBufferBuilder builder, StringOffset deepLinkSublocationOffset)
		{
		}

		[Address(RVA="0x24E79D8", Offset="0x24E79D8", VA="0x24E79D8")]
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
		}

		[Address(RVA="0x24E7780", Offset="0x24E7780", VA="0x24E7780")]
		public static void AddEventGroupId(FlatBufferBuilder builder, ulong eventGroupId)
		{
		}

		[Address(RVA="0x24E77BC", Offset="0x24E77BC", VA="0x24E77BC")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24E799C", Offset="0x24E799C", VA="0x24E799C")]
		public static void AddImage(FlatBufferBuilder builder, StringOffset imageOffset)
		{
		}

		[Address(RVA="0x24E7A14", Offset="0x24E7A14", VA="0x24E7A14")]
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
		}

		[Address(RVA="0x24E7924", Offset="0x24E7924", VA="0x24E7924")]
		public static void AddPreviewText(FlatBufferBuilder builder, StringOffset previewTextOffset)
		{
		}

		[Address(RVA="0x24E7A50", Offset="0x24E7A50", VA="0x24E7A50")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x24E7870", Offset="0x24E7870", VA="0x24E7870")]
		public static void AddShowcaseItems(FlatBufferBuilder builder, VectorOffset showcaseItemsOffset)
		{
		}

		[Address(RVA="0x24E7960", Offset="0x24E7960", VA="0x24E7960")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x24E7834", Offset="0x24E7834", VA="0x24E7834")]
		public static void AddTimes(FlatBufferBuilder builder, VectorOffset timesOffset)
		{
		}

		[Address(RVA="0x24E7634", Offset="0x24E7634", VA="0x24E7634")]
		public static Offset<ScheduledInfoEvent> CreateScheduledInfoEvent(FlatBufferBuilder builder, ulong id = 0L, ulong event_group_id = 0L, StringOffset requirementOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ScheduledInfoEvent> Gamedata.ScheduledInfoEvent::CreateScheduledInfoEvent(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ScheduledInfoEvent> CreateScheduledInfoEvent(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E7B78", Offset="0x24E7B78", VA="0x24E7B78")]
		public static VectorOffset CreateShowcaseItemsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E7CAC", Offset="0x24E7CAC", VA="0x24E7CAC")]
		public static VectorOffset CreateTimesVector(FlatBufferBuilder builder, Offset<ScheduledEventTime>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E7AC8", Offset="0x24E7AC8", VA="0x24E7AC8")]
		public static Offset<ScheduledInfoEvent> EndScheduledInfoEvent(FlatBufferBuilder builder)
		{
			return new Offset<ScheduledInfoEvent>();
		}

		[Address(RVA="0x24E7DE0", Offset="0x24E7DE0", VA="0x24E7DE0")]
		public static void FinishScheduledInfoEventBuffer(FlatBufferBuilder builder, Offset<ScheduledInfoEvent> offset)
		{
		}

		[Address(RVA="0xF588BC", Offset="0xF588BC", VA="0xF588BC")]
		public ArraySegment<byte>? GetBannerImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF588D4", Offset="0xF588D4", VA="0xF588D4")]
		public ArraySegment<byte>? GetBannerTextBytes()
		{
			return null;
		}

		[Address(RVA="0xF58924", Offset="0xF58924", VA="0xF58924")]
		public ArraySegment<byte>? GetDeepLinkSublocationBytes()
		{
			return null;
		}

		[Address(RVA="0xF5886C", Offset="0xF5886C", VA="0xF5886C")]
		public ArraySegment<byte>? GetDescriptionBytes()
		{
			return null;
		}

		[Address(RVA="0xF58884", Offset="0xF58884", VA="0xF58884")]
		public ArraySegment<byte>? GetImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF58854", Offset="0xF58854", VA="0xF58854")]
		public ArraySegment<byte>? GetNameBytes()
		{
			return null;
		}

		[Address(RVA="0xF588A4", Offset="0xF588A4", VA="0xF588A4")]
		public ArraySegment<byte>? GetPreviewTextBytes()
		{
			return null;
		}

		[Address(RVA="0xF5883C", Offset="0xF5883C", VA="0xF5883C")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x24E6F1C", Offset="0x24E6F1C", VA="0x24E6F1C")]
		public static ScheduledInfoEvent GetRootAsScheduledInfoEvent(FlatBuffers.ByteBuffer _bb)
		{
			return new ScheduledInfoEvent();
		}

		[Address(RVA="0x24E6F28", Offset="0x24E6F28", VA="0x24E6F28")]
		public static ScheduledInfoEvent GetRootAsScheduledInfoEvent(FlatBuffers.ByteBuffer _bb, ScheduledInfoEvent obj)
		{
			return new ScheduledInfoEvent();
		}

		[Address(RVA="0xF588F4", Offset="0xF588F4", VA="0xF588F4")]
		public ArraySegment<byte>? GetShowcaseItemsBytes()
		{
			return null;
		}

		[Address(RVA="0xF588E4", Offset="0xF588E4", VA="0xF588E4")]
		public ulong ShowcaseItems(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x24E7B48", Offset="0x24E7B48", VA="0x24E7B48")]
		public static void StartScheduledInfoEvent(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24E7C70", Offset="0x24E7C70", VA="0x24E7C70")]
		public static void StartShowcaseItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E7DA4", Offset="0x24E7DA4", VA="0x24E7DA4")]
		public static void StartTimesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF58904", Offset="0xF58904", VA="0xF58904")]
		public ScheduledEventTime? Times(int j)
		{
			return null;
		}
	}
}